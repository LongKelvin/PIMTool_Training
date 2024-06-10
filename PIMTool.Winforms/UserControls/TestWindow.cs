using PIMTool.Winforms.Events;
using PIMTool.Winforms.Interfaces;
using PIMTool.Winforms.UserControls.CustomControls;

namespace PIMTool.Winforms.UserControls
{
    public partial class TestWindow : BaseUserControl, INavigationHandler
    {
        private MultiSelectBox multiSelectPillbox;
        private Button showSelectedButton;

        public TestWindow()
        {
            InitializeComponent();
            InitializeMultiSelectPillboxComponent();
        }

        public void NavigateTo(string userControlName, object[]? data = null)
        {
            NavigationRequested?.Invoke(this, new NavigationEventArgs(userControlName, data));
        }

        private void InitializeMultiSelectPillboxComponent()
        {
            this.multiSelectPillbox = new MultiSelectBox();
            this.showSelectedButton = new Button();

            this.showSelectedButton.Text = "Show Selected";
            this.showSelectedButton.Click += ShowSelectedButton_Click!;

            List<string> suggestionList = new List<string>();
            // Set properties
            for (int i = 0; i < 100; i++)
            {
                suggestionList.Add($"Test_{i + 1}");
            }
            this.multiSelectPillbox.DataSource = suggestionList;

            // Layout
            this.Controls.Add(this.multiSelectPillbox);
            this.Controls.Add(this.showSelectedButton);
            this.multiSelectPillbox.Dock = DockStyle.Top;
            this.showSelectedButton.Dock = DockStyle.Bottom;

            // Form properties
            this.Text = "Multi-Select Pillbox Example";
            this.Size = new Size(300, 400);
        }

        private void ShowSelectedButton_Click(object sender, EventArgs e)
        {
            var selectedItems = this.multiSelectPillbox.GetSelectedItems();
            MessageBox.Show("Selected Items: " + string.Join(", ", selectedItems));
        }
    }
}