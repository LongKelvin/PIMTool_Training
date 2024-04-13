using PIMTool.Core.Wrapper.Interfaces;
using PIMTool.Entities.Enums;
using PIMTool.Winforms.Events;
using PIMTool.Winforms.Interfaces;

namespace PIMTool.Winforms.UserControls
{
    public partial class NewProject : BaseUserControl, INavigationHandler
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public NewProject(IRepositoryWrapper repositoryWrapper)
        {
            InitializeComponent();

            _repositoryWrapper = repositoryWrapper;
        }

        public void NavigateTo(string userControlName, object[]? data = null)
        {
            NavigationRequested?.Invoke(this, new NavigationEventArgs(userControlName, data));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigateTo(nameof(ProjectList));
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            NavigateTo(nameof(ProjectList));

            // Handle create project button click
        }

        private void LoadGroupDataComboBox()
        {
            var groupData = _repositoryWrapper.Groups.GetAllAsync().ToList();
            cmbGroup.DataSource = groupData;
            cmbGroup.DisplayMember = "GroupName";
        }

        private void LoadProjectStatusDefaultCombobox()
        {
            ProjectStatus[] projectStatus = (ProjectStatus[])Enum.GetValues(typeof(ProjectStatus));
            cmbStatus.DataSource = projectStatus;
        }

        private void NewProject_Load(object sender, EventArgs e)
        {
            //Init combobox data

            LoadGroupDataComboBox();
            LoadProjectStatusDefaultCombobox();
        }
    }
}