namespace PIMTool.Winforms.Controls
{
    public class CustomUserControl
    {
        public UserControl UserControl { get; set; }
        public string Name { get; set; }

        public CustomUserControl()
        {
            Name = "UserControl_Default";
            UserControl = new UserControl();
        }

        public CustomUserControl(string name, UserControl userControl)
        {
            Name = name;
            UserControl = userControl;
        }
    }
}