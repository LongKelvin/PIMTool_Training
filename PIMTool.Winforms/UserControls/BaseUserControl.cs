using PIMTool.Winforms.Events;

namespace PIMTool.Winforms.UserControls
{
    public partial class BaseUserControl : MetroSet_UI.Forms.MetroSetForm
    {
        public EventHandler<NavigationEventArgs> NavigationRequested { get; set; }
        public object[]? NavigationData { get; set; }

        public BaseUserControl()
        {
            InitializeComponent();
        }
    }
}