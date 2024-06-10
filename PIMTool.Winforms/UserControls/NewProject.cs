using MetroSet_UI.Forms;

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
        private List<string> _listCustomerName;

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
            // Show confirm messagebox before creating project
            // if OK then create new project
            var confirmResult = MetroSetMessageBox.Show(this,"Are you sure to create this project?",
                "Confirm Create Project",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            // Create new project
             _repositoryWrapper.Projects.AddAsync(new Project
            {   
                 
                ProjectNumber = int.Parse(txtProjectNumber.Text),
                Name = txtProjectName.Text,
                Customer = txtCustomer.Text,
                GroupId = ((Group)cmbGroup.SelectedItem!).Id,
                Status = cmbStatus.SelectedItem!.ToString()!,
                StartDate = dtStartDate.Value,
                EndDate = dtEndDate.Value,
                
                Employees = multiSelectBoxMember.GetSelectedItems().Select(x => new Employee
                {
                    Id = _listEmployees.First(y => y.Visa == x).Id
                }).ToList()
            });

            _repositoryWrapper.SaveChanges();
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

            // Init customer name
            LoadListCustomerName();


        }

        private void LoadListCustomerName()
        {
            _listCustomerName = ([.. _repositoryWrapper.Projects
                .GetAllAsync()
                .Select(x => x.Customer)]);
        }

        private void btnAutoGenerate_Click(object sender, EventArgs e)
        {
            // auto generate a integer number for project number
            Random random = new Random();
            txtProjectNumber.Text = random.Next(1000, 9999).ToString();

        }


        /// <summary>
        ///  This is UI functionality to search customer name in textbox and show suggestion list in textbox autocomplete source  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            //// Check if the _listCustomerName is initialized
            //if (_listCustomerName == null)
            //{
            //    return;
            //}

            //var customerName = txtCustomer.Text.ToLower();

            //// Efficiently filter the customer names
            //var filteredCustomerNames = _listCustomerName
            //    .Where(x => x.ToLower().Contains(customerName))
            //    .ToArray();  // Use ToArray for optimal performance with AddRange

            //// Initialize the AutoCompleteCustomSource if needed
            //if (txtCustomer.AutoCompleteCustomSource == null)
            //{
            //    txtCustomer.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            //}

            //// Update AutoCompleteCustomSource only if there are changes
            //if (!txtCustomer.AutoCompleteCustomSource.Cast<string>().SequenceEqual(filteredCustomerNames))
            //{
            //    txtCustomer.AutoCompleteCustomSource.Clear();
            //    txtCustomer.AutoCompleteCustomSource.AddRange(filteredCustomerNames);
            //}

            //// Set the autocomplete mode and source if not already set
            //if (txtCustomer.AutoCompleteMode != AutoCompleteMode.SuggestAppend)
            //{
            //    txtCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //}

            //if (txtCustomer.AutoCompleteSource != AutoCompleteSource.CustomSource)
            //{
            //    txtCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //}
        }


    }
}