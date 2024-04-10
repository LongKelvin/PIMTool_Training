namespace PIMTool.Winforms.Controls
{
    public class NavigationControl
    {
        private List<CustomUserControl> _listUserControls { get; set; }
        private Panel _panel { get; set; }

        public NavigationControl()
        {
            _listUserControls = [];
            _panel = new Panel();
        }

        public NavigationControl(List<CustomUserControl> listUserControls, Panel panel)
        {
            _listUserControls = listUserControls;
            _panel = panel;

            AddUserControl();
        }

        private void AddUserControl()
        {
            for (int index = 0; index < _listUserControls.Count; index++)
            {
                _listUserControls[index].UserControl.Dock = DockStyle.Fill;
                _panel.Controls.Add(_listUserControls[index].UserControl);
            }
        }

        public void Display(int index)
        {
            if (index < _listUserControls.Count)
            {
                _listUserControls[index].UserControl.BringToFront();
            }
        }

        public void Display(string windowName)
        {
            var window = _listUserControls.Find(x => x.Name.Equals(windowName, StringComparison.OrdinalIgnoreCase));
            if (window != null)
            {
                _listUserControls!.Find(x => x.Name.Equals(window.Name))!.UserControl.BringToFront();
            }
        }
    }
}