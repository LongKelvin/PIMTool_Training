using PIMTool.Core.Wrapper.Interfaces;
using PIMTool.Entities.Enums;
using PIMTool.Winforms.Controls;
using PIMTool.Winforms.Interfaces;

namespace PIMTool.Winforms.UserControls
{
    public partial class NewProject : UserControl, INavigationHandler
    {
        private readonly NavigationControl _navigationControl;
        private readonly IRepositoryWrapper _repositoryWrapper;

        public NewProject(NavigationControl navigationControl, IRepositoryWrapper repositoryWrapper)
        {
            InitializeComponent();

            _navigationControl = navigationControl;
            _repositoryWrapper = repositoryWrapper;
        }

        public void NavigateTo(string userControlName)
        {
            _navigationControl.Display(userControlName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigateTo(nameof(ProjectList));
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
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