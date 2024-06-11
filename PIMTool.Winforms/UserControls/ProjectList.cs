﻿using Microsoft.Extensions.Logging;

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

            // Bind projects to the DataGridView
            dataGridViewProjects.DataSource = projects;
            dataGridViewProjects.Columns["TimeStamp"].Visible = false;
            dataGridViewProjects.Columns["IsSelected"].DisplayIndex = 0;
            dataGridViewProjects.Columns["IsSelected"].Selected = true;
            dataGridViewProjects.Columns["Id"].DisplayIndex = 1;
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

        private void FilterProjects(string name, int number, string customer, string status)
        {
            // Filter projects based on the provided criteria
            //var filteredProjects = _repositoryWrapper.Projects.GetByConditionAsync(name, number, customer, status);

            // Bind filtered projects to the DataGridView
            //dataGridViewProjects.DataSource = filteredProjects;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Get search criteria from UI controls
            string name = ""; // Get name from UI control
            int number = 0;   // Get number from UI control
            string customer = ""; // Get customer from UI control
            string status = "";   // Get status from UI control

            // Filter projects based on search criteria
            FilterProjects(name, number, customer, status);
        }

        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            // Clear search criteria UI controls
            // Example: txtName.Text = "";
            // Example: numNumber.Value = 0;
            // Example: txtCustomer.Text = "";
            // Example: cboStatus.SelectedIndex = -1;

            // Reload all projects
            LoadProjects();
        }

        private void LoadProjectStatusDefaultCombobox()
        {
            ProjectStatus[] projectStatus = (ProjectStatus[])Enum.GetValues(typeof(ProjectStatus));
            cmbProjectStatus.DataSource = projectStatus;
        }

        private void dataGridViewProjects_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Log the error or display a custom error message
            _logger.LogError(e.Exception, "Data error occurred: " + e.Exception.Message);
            e.ThrowException = false;
        }
    }
}