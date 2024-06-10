using PIMTool.Core.Wrapper.Interfaces;
using PIMTool.Entities;
using PIMTool.Entities.Enums;
using PIMTool.Winforms.Events;
using PIMTool.Winforms.Interfaces;

namespace PIMTool.Winforms.UserControls
{
    public partial class NewProject : BaseUserControl, INavigationHandler
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private List<Employee> _listEmployees;

        public NewProject(IRepositoryWrapper repositoryWrapper)
        {
            InitializeComponent();
            _repositoryWrapper = repositoryWrapper;
        }

        /// <summary>
        /// This is non UI functionality
        /// </summary>
        /// <param name="empName"></param>
        /// <returns></returns>

        private List<Employee> GetListOfEmployees(string? empName = null)
        {
            if (string.IsNullOrEmpty(empName))
                return [.. _repositoryWrapper.Employees.GetAllAsync()];

            return [.. _repositoryWrapper.Employees.GetByConditionAsync(
                x => x.FirstName.ToLower().Contains(empName.ToLower()))];
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
        }

        private void LoadGroupDataComboBox()
        {
            var groupData = _repositoryWrapper.Groups.GetAllAsync()
                .Where(x => (!string.IsNullOrEmpty(x.GroupName))).ToList();
            cmbGroup.DataSource = groupData;
            cmbGroup.DisplayMember = "GroupName";
        }

        private void LoadProjectStatusDefaultCombobox()
        {
            ProjectStatus[] projectStatus = (ProjectStatus[])Enum.GetValues(typeof(ProjectStatus));
            cmbStatus.DataSource = projectStatus;
        }

        private void LoadAllMemberVisaToMultiSelectListByDefault()
        {
            // Init list members
            _listEmployees = GetListOfEmployees();
            multiSelectBoxMember.DataSource = _listEmployees.Select(x => x.Visa).ToList();
        }

        private void NewProject_Load(object sender, EventArgs e)
        {
            //Init combobox data
            LoadGroupDataComboBox();
            LoadProjectStatusDefaultCombobox();

            // Init multiple selectbox data
            LoadAllMemberVisaToMultiSelectListByDefault();


        }
    }
}