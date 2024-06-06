using PIMTool.Winforms.UserControls;

namespace PIMTool.Winforms.Controls
{
    public class WindowsContainerManager
    {
        public Dictionary<string, BaseUserControl> WindowsContainer { get; private set; }
        public BaseUserControl? CurrentWindow { get; private set; }
        public Control? ParrentControl { get; set; }

        public WindowsContainerManager()
        {
            WindowsContainer = [];
            CurrentWindow = new BaseUserControl();
            ParrentControl = null;
        }

        public WindowsContainerManager(
            Dictionary<string, BaseUserControl> windowsContainer,
            Control parrentControl,
            BaseUserControl? currentWindow = null)
        {
            WindowsContainer = windowsContainer;
            CurrentWindow = currentWindow ?? windowsContainer.First().Value;
            ParrentControl = parrentControl;

            AddUserControl(ParrentControl, windowsContainer);
        }

        public virtual void Display(string userControlName, object[]? data = null)
        {
            if (WindowsContainer.TryGetValue(userControlName, out BaseUserControl? value))
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

        public void AddUserControl(Control parrentControl, params BaseUserControl[] userControls)
        {
            ParrentControl = parrentControl;
            WindowsContainer ??= [];

            foreach (var control in userControls)
            {
                if (control is BaseUserControl baseUserControl)
                {
                    HandleDynamicNavigation(baseUserControl);
                }

                control.TopLevel = false;
                control.Dock = DockStyle.Fill;
                control.AllowResize = false;
                control.AllowDrop = false;
                control.Moveable = false;

                WindowsContainer.TryAdd(control.GetType().Name, control);
                parrentControl.Controls.Add(control);
                control.Visible = false;
            }
        }

        public void AddUserControl(Control parrentControl, Dictionary<string, BaseUserControl> userControlDictionary)
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

                kvp.Value.TopLevel = false;
                kvp.Value.Dock = DockStyle.Fill;
                kvp.Value.AllowResize = false;
                kvp.Value.AllowDrop = false;
                kvp.Value.Moveable = false;

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