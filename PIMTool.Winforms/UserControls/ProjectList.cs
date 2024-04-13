using PIMTool.Winforms.Events;
using PIMTool.Winforms.Interfaces;

namespace PIMTool.Winforms.UserControls
{
    public partial class ProjectList : BaseUserControl, INavigationHandler
    {
        public ProjectList()
        {
            InitializeComponent();
        }

        public void NavigateTo(string userControlName, object[]? data = null)
        {
            NavigationRequested.Invoke(this, new NavigationEventArgs(userControlName, data));
        }

        private void ProjectList_Load(object sender, EventArgs e)
        {
            label1.Text = $"{nameof(ProjectList)} is loading)";
        }
    }
}