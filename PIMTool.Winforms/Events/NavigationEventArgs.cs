namespace PIMTool.Winforms.Events
{
    public class NavigationEventArgs : EventArgs
    {
        public string UserControlName { get; }
        public object[]? Data { get; }

        public NavigationEventArgs(string userControlName, object[]? data = null)
        {
            UserControlName = userControlName;
            Data = data;
        }
    }
}
