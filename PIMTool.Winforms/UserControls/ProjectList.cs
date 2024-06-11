using MetroSet_UI.Forms;

using Microsoft.Extensions.Logging;

using PIMTool.Core.Wrapper.Interfaces;
using PIMTool.Entities.Enums;
using PIMTool.Shared.DTOs;
using PIMTool.Winforms.Events;
using PIMTool.Winforms.Interfaces;

namespace PIMTool.Winforms.UserControls
{
    public partial class ProjectList : BaseUserControl, INavigationHandler
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly ILogger<ProjectList> _logger;

        public ProjectList(IRepositoryWrapper repositoryWrapper, ILogger<ProjectList> logger)
        {
            InitializeComponent();
            _repositoryWrapper = repositoryWrapper;
            _logger = logger;

            LoadProjects();
        }

        public void LoadProjects()
        {
            // Load projects from the repository
            var projects = _repositoryWrapper.Projects.GetAllAsync().Select(x => new ProjectDto
            {
                Id = x.Id,
                Name = x.Name,
                Status = x.Status,
                ProjectNumber = x.ProjectNumber,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Customer = x.Customer,
                IsSelected = false
            }).ToList();

            BindProjectsToDataGridView(projects);
        }

        private void BindProjectsToDataGridView(List<ProjectDto> projects)
        {
            // Bind projects to the DataGridView
            dataGridViewProjects.DataSource = projects;

            dataGridViewProjects.Columns["TimeStamp"].Visible = false;
            dataGridViewProjects.Columns["Id"].DisplayIndex = 1;
            dataGridViewProjects.Columns["ProjectNumber"].DisplayIndex = 2;
            dataGridViewProjects.Columns["Name"].DisplayIndex = 3;
            dataGridViewProjects.Columns["Customer"].DisplayIndex = 4;
            dataGridViewProjects.Columns["Status"].DisplayIndex = 5;
            dataGridViewProjects.Columns["StartDate"].DisplayIndex = 6;
            dataGridViewProjects.Columns["EndDate"].DisplayIndex = 7;
            dataGridViewProjects.Columns["DeleteColumn"].DisplayIndex = 8;
        }

        private void DataGridViewProjects_DeleteButton_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProjects.Columns["DeleteColumn"].Index)
            {
                var result = MetroSetMessageBox.Show(this, "Are you sure you want to delete this project?",
                    "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == DialogResult.No)
                    return;

                var project = (ProjectDto)dataGridViewProjects.Rows[e.RowIndex].DataBoundItem;
                _repositoryWrapper.Projects.Delete(project.Id);
                _repositoryWrapper.SaveChanges();
                LoadProjects();
            }
        }

        public void NavigateTo(string userControlName, object[]? data = null)
        {
            NavigationRequested.Invoke(this, new NavigationEventArgs(userControlName, data));
        }

        private void ProjectList_Load(object sender, EventArgs e)
        {
            LoadProjectStatusDefaultCombobox();
            LoadProjects();
        }

        private void FilterProjects(string keyword, string status)
        {
            if (string.IsNullOrEmpty(keyword) && string.IsNullOrEmpty(status))
            {
                LoadProjects();
                return;
            }

            // handle status is "ALL"
            if (status == "ALL")
            {
                status = string.Empty;
            }

            // Build search criteria based on keyword and status, if status is empty then search by keyword only
            var projects = _repositoryWrapper.Projects.GetByConditionAsync(x =>
                (string.IsNullOrEmpty(keyword) || x.Name.ToLower().Contains(keyword.ToLower())) &&
                (string.IsNullOrEmpty(status) || x.Status.ToLower().Contains(status.ToLower()))).Select(x => new ProjectDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Status = x.Status,
                    ProjectNumber = x.ProjectNumber,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Customer = x.Customer,
                    IsSelected = false
                }).ToList();

            // Bind projects to the DataGridView
            BindProjectsToDataGridView(projects);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var keyWord = txtSearchBox.Text;
            string status = cmbProjectStatus.SelectedItem!.ToString()!;

            // Filter projects based on search criteria
            FilterProjects(keyWord, status);
        }

        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            // Clear search criteria UI controls
            cmbProjectStatus.SelectedIndex = 0;
            txtSearchBox.Text = string.Empty;

            // Reload all projects
            LoadProjects();
        }

        private void LoadProjectStatusDefaultCombobox()
        {
            ProjectStatus[] projectStatus = (ProjectStatus[])Enum.GetValues(typeof(ProjectStatus));

            List<string> projectStatusList = new(projectStatus.Length + 1)
            {
                "ALL"
            };
            projectStatusList.AddRange(projectStatus.Select(status => status.ToString()));

            cmbProjectStatus.DataSource = projectStatusList;
        }

        private void DataGridViewProjects_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Log the error or display a custom error message
            _logger.LogError(e.Exception, "Data error occurred: " + e.Exception!.Message);
            e.ThrowException = false;
        }

        private void DataGridViewProjects_SelectColumn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProjects.Columns["SelectColumn"].Index)
            {
                var project = (ProjectDto)dataGridViewProjects.Rows[e.RowIndex].DataBoundItem;
                project.IsSelected = !project.IsSelected;
            }

            // Update the lblSelectedProjectCount
            lblSelectedProjectCount.Text = GetSelectedProjects().Count.ToString();
        }

        public List<ProjectDto> GetSelectedProjects()
        {
            var selectedProjects = new List<ProjectDto>();

            foreach (DataGridViewRow row in dataGridViewProjects.Rows)
            {
                var project = (ProjectDto)row.DataBoundItem;
                if (project.IsSelected)
                {
                    selectedProjects.Add(project);
                }
            }

            return selectedProjects;
        }

        private void DeleteSelectedProjects_Click(object sender, EventArgs e)
        {
            var result = MetroSetMessageBox.Show(this, "Are you sure you want to delete selected projects?",
                "Delete Selected Projects", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (result == DialogResult.No)
                return;

            var selectedProjects = GetSelectedProjects();
            _repositoryWrapper.Projects.Delete(selectedProjects.Select(x => x.Id).ToArray());
            _repositoryWrapper.SaveChanges();
            LoadProjects();
        }
    }
}