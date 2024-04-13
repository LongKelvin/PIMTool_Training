using PIMTool.Winforms.UserControls;

namespace PIMTool.Winforms.Controls
{
    public class WindowsContainerManager
    {
        public Dictionary<string, UserControl> WindowsContainer { get; private set; }
        public UserControl? CurrentWindow { get; private set; }
        public Control? ParrentControl { get; set; }

        public WindowsContainerManager()
        {
            WindowsContainer = [];
            CurrentWindow = new UserControl();
            ParrentControl = null;
        }

        public WindowsContainerManager(
            Dictionary<string, UserControl> windowsContainer,
            Control parrentControl,
            UserControl? currentWindow = null)
        {
            WindowsContainer = windowsContainer;
            CurrentWindow = currentWindow ?? windowsContainer.First().Value;
            ParrentControl = parrentControl;

            AddUserControl(ParrentControl, windowsContainer);
        }

        public virtual void Display(string userControlName, object[]? data = null)
        {
            if (WindowsContainer.TryGetValue(userControlName, out UserControl? value))
            {
                if (CurrentWindow != null)
                {
                    CurrentWindow.Visible = false;
                }

                value.BringToFront();
                value.Visible = true;

                if (value is BaseUserControl baseUserControl)
                {
                    baseUserControl.NavigationData = data;
                }

                CurrentWindow = value;
            }
        }

        public void AddUserControl(Control parrentControl, params UserControl[] userControls)
        {
            ParrentControl = parrentControl;
            WindowsContainer ??= [];

            foreach (var control in userControls)
            {
                if (control is BaseUserControl baseUserControl)
                {
                    HandleDynamicNavigation(baseUserControl);
                }

                WindowsContainer.TryAdd(control.GetType().Name, control);
                parrentControl.Controls.Add(control);
                control.Visible = false;
            }
        }

        public void AddUserControl(Control parrentControl, Dictionary<string, UserControl> userControlDictionary)
        {
            ParrentControl = parrentControl;
            WindowsContainer ??= [];

            // Add each user control to the parrentControl and subscribe to NavigationRequested event
            foreach (var kvp in userControlDictionary)
            {
                if (kvp.Value is BaseUserControl baseUserControl)
                {
                    HandleDynamicNavigation(baseUserControl);
                }

                parrentControl.Controls.Add(kvp.Value);
                WindowsContainer.TryAdd(kvp.Key, kvp.Value);
                kvp.Value.Visible = false;
            }
        }

        public void NavigateTo(string userControlName, object[]? data = null)
        {
            Display(userControlName, data);
        }

        private void HandleDynamicNavigation(BaseUserControl userControl)
        {
            if (userControl is BaseUserControl baseUserControl)
            {
                baseUserControl.NavigationRequested += (sender, e) =>
                {
                    NavigateTo(e.UserControlName, e.Data);
                };
            }
        }
    }
}