using PIMTool.Winforms.Events;

namespace PIMTool.Winforms.UserControls
{
    public partial class BaseUserControl : UserControl
    {
        public EventHandler<NavigationEventArgs> NavigationRequested { get; set; }
        public object[]? NavigationData { get; set; }
        public BaseUserControl()
        {
            InitializeComponent();
        }
    }
}
