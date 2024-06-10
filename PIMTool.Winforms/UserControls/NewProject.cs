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
        private List<string> _listEmployeeName;
        private List<string> _listSelectedEmployees;

        // UI Component
        private ListBox _employeeSuggestionList;

        public NewProject(IRepositoryWrapper repositoryWrapper)
        {
            InitializeComponent();
            _repositoryWrapper = repositoryWrapper;

            // UI Control Initilize
            txtMember.AutoCompleteCustomSource = [];

            // Create and hide the suggestion ListBox
            _employeeSuggestionList = new ListBox
            {
                Visible = false
            };
            _employeeSuggestionList.DrawItem += SuggestionList_DrawItem; // Register DrawItem event handler
            Controls.Add(_employeeSuggestionList);

            // Event handler for text changes
            txtMember.TextChanged += TxtMember_TextChanged;

            // Event handler for handling Enter or semicolon key press
            txtMember.KeyDown += TxtMember_KeyDown;

            // Data fetching
            _listEmployeeName = GetListOfEmployees().Select(x => x.FirstName)
                .Where(x => !string.IsNullOrEmpty(x)).ToList();

            for (int i = 0; i < 20; i++)
            {
                _listEmployeeName.Add($"test_{i}");
            }
        }

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

        private void NewProject_Load(object sender, EventArgs e)
        {
            //Init combobox data
            LoadGroupDataComboBox();
            LoadProjectStatusDefaultCombobox();

            List<string> matchingMembers = _listEmployeeName;

            // Clear the existing auto-complete suggestions
            txtMember.AutoCompleteCustomSource?.Clear();

            // Add the new matching members to the auto-complete suggestions

            txtMember.AutoCompleteCustomSource?.AddRange([.. matchingMembers]);
            txtMember.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMember.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void SuggestionList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            string suggestion = _employeeSuggestionList.Items[e.Index].ToString()!;

            string text = txtMember.Text;
            string[] parts = text.Split(';');
            string lastWord = parts.Length > 0 ? parts[parts.Length - 1] : "";

            // Highlight matching text based on lastWord
            int startIndex = suggestion.IndexOf(lastWord, StringComparison.CurrentCultureIgnoreCase);
            if (startIndex >= 0)
            {
                e.DrawBackground();
                e.Graphics.DrawString(suggestion.Substring(0, startIndex), e.Font, Brushes.Black, e.Bounds);
                e.Graphics.DrawString(suggestion.Substring(startIndex, lastWord.Length), e.Font, Brushes.LightBlue, e.Bounds);
                e.Graphics.DrawString(suggestion.Substring(startIndex + lastWord.Length), e.Font, Brushes.Black, e.Bounds);
            }
        }

        private void TxtMember_TextChanged(object sender, EventArgs e)
        {
            string text = txtMember.Text;
            string[] parts = text.Split(';');
            string lastWord = parts.Length > 0 ? parts[parts.Length - 1] : "";

            // Update suggestion list asynchronously
            _employeeSuggestionList.Items.Clear();
            _employeeSuggestionList.Visible = false;

            var suggestions = GetListOfEmployees(lastWord);
            _employeeSuggestionList.Items.AddRange([.. suggestions]);
            _employeeSuggestionList.Visible = suggestions.Count != 0;

            // Position and show suggestion list (adjust as needed)
            _employeeSuggestionList.Location = new Point(txtMember.Left, txtMember.Bottom);
        }

        private void SuggestionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_employeeSuggestionList.SelectedItem != null)
            {
                string selectedSuggestion = _employeeSuggestionList.SelectedItem.ToString()!;
                txtMember.Text += $";{selectedSuggestion}"; // Add semicolon after selection
                _employeeSuggestionList.Visible = false; // Hide suggestion list
            }
        }

        private void TxtMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.OemSemicolon)
            {
                _listSelectedEmployees = [.. txtMember.Text.Split(';')];
                _listSelectedEmployees.RemoveAll(string.IsNullOrEmpty); // Remove empty entries
                txtMember.Text = string.Join(";", _listSelectedEmployees); // Update text with selected members
            }
        }
    }
}