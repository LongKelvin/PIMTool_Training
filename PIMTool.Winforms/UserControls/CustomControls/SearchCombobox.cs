using MetroSet_UI.Controls;

namespace PIMTool.Winforms.UserControls.CustomControls
{
    public partial class SearchCombobox : UserControl
    {
        private MetroSetTextBox _textBox;
        private MetroSetListBox _listBox;

        public SearchCombobox()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Initialize TextBox
            _textBox = new MetroSetTextBox
            {
                Dock = DockStyle.Top
            };
            _textBox.TextChanged += TextBox_TextChanged;
            _textBox.KeyDown += TextBox_KeyDown;

            // Initialize ListBox
            _listBox = new MetroSetListBox
            {
                Dock = DockStyle.Fill,
                Visible = false
            };
            _listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;

            // Add controls to UserControl
            Controls.Add(_listBox);
            Controls.Add(_textBox);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Perform filtering based on user input
            string input = _textBox.Text.Trim();
            List<string> matchingItems = QueryMatchingItems(input);

            // Update the ListBox with matching items
            UpdateListBox(matchingItems);

            // Show/hide the ListBox based on whether there are matching items
            _listBox.Visible = matchingItems.Count > 0;
        }

        private void UpdateListBox(List<string> matchingItems)
        {
            // Clear existing items in the ListBox
            _listBox.Items.Clear();

            // Add matching items to the ListBox
            foreach (string item in matchingItems)
            {
                _listBox.Items.Add(item);
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Hide the ListBox when the user presses Enter
            if (e.KeyCode == Keys.Enter)
            {
                _listBox.Visible = false;
            }
        }

        private void ListBox_SelectedIndexChanged(object sender)
        {
            // Update the TextBox with the selected item
            _textBox.Text = _listBox.SelectedItem.ToString();
            _listBox.Visible = false;
        }

        private List<string> QueryMatchingItems(string input)
        {
            // Perform your database query or any other logic to find matching items
            // For demonstration purposes, returning some dummy data
            return ["Item 1", "Item 2", "Item 3"];
        }
    }
}