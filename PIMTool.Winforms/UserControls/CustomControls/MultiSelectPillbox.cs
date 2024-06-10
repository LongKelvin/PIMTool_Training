using System.ComponentModel;

namespace PIMTool.Winforms.UserControls.CustomControls
{
    public partial class MultiSelectPillbox : UserControl
    {
        private List<string>? items;
        private readonly HashSet<string> selectedItems = [];

        private bool listBoxSelectionChanging;

        public MultiSelectPillbox()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<string>? DataSource
        {
            get => items;
            set
            {
                items = value;
                UpdateItems();
            }
        }

        private void UpdateItems()
        {
            listBox.Items.Clear();
            if (items != null)
            {
                listBox.Items.AddRange([.. items]);
            }
        }

        private void SearchTextBox_GotFocus(object sender, EventArgs e)
        {
            ShowList();
        }

        private void SearchTextBox_LostFocus(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                if (!listBox.Focused)
                {
                    listBox.Visible = false;
                }
            }));
        }

        private void ListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && listBox.SelectedIndex != ListBox.NoMatches)
            {
                UpdateSelectedItems();
                UpdateSearchBox();
            }
        }

        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                listBoxSelectionChanging = true;
                listBox.SelectedIndex = index;
                listBoxSelectionChanging = false;
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!listBoxSelectionChanging)
            {
                UpdateSelectedItems();
                UpdateSearchBox();
            }
        }

        private void UpdateSearchBox()
        {
            searchTextBox.Text = string.Join(";", selectedItems) + ";";
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filter = searchTextBox.Text.Contains(';')
                ? searchTextBox.Text.Split(';').LastOrDefault()!.ToLower()
                : searchTextBox.Text.ToLower();

            var filteredItems = items?.Where(item => item.Contains(filter, StringComparison.CurrentCultureIgnoreCase) && !selectedItems.Contains(item)).ToList() ?? [];
            listBox.Items.Clear();
            listBox.Items.AddRange([.. filteredItems]);

            string[] remainItems = searchTextBox.Text.Split(';', StringSplitOptions.RemoveEmptyEntries);

            selectedItems.Clear();
            foreach (string item in remainItems)
            {
                if (items?.Contains(item) == true && !selectedItems.Contains(item))
                {
                    selectedItems.Add(item);
                }
            }

            ShowList();
        }

        private void ListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                listBox.SelectedIndex = index;
                UpdateSelectedItems();
                UpdateSearchBox();
            }
        }

        private void UpdateSelectedItems()
        {
            foreach (string item in listBox.SelectedItems)
            {
                selectedItems.Add(item);
            }

            this.Text = string.Join(";", selectedItems) + ";";
            listBox.Refresh();
        }

        private void ShowList()
        {
            listBox.Visible = listBox.Items.Count > 0;
            listBox.BringToFront();
        }

        public List<string> GetSelectedItems()
        {
            return [.. selectedItems];
        }

        private void ListBox_LostFocus(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                if (!searchTextBox.Focused)
                {
                    listBox.Visible = false;
                }
            }));
        }

    }
}
