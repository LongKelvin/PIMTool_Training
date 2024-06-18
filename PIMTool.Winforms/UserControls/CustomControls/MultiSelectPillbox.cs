using System.ComponentModel;

namespace PIMTool.Winforms.UserControls.CustomControls
{
    public partial class MultiSelectBox : UserControl
    {
        private List<string>? items;
        private readonly HashSet<string> selectedItems = [];

        private bool listBoxSelectionChanging;

        public MultiSelectBox()
        {
            InitializeComponent();

            // Wire up event handlers
            this.GotFocus += MultiSelectPillbox_GotFocus!;
            this.LostFocus += MultiSelectPillbox_LostFocus!;
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


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new string? Text
        {
            get => searchTextBox.Text;
            set
            {
                searchTextBox.Text = value;

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
            listBox.BackColor = Color.White;
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

        private void MultiSelectPillbox_GotFocus(object sender, EventArgs e)
        {
            AdjustListBoxHeight();
            PositionListBoxAboveOtherControls();
            ShowList();
        }

        private void MultiSelectPillbox_LostFocus(object sender, EventArgs e)
        {
            HideList();
            BackColor = Color.White;
            //BorderStyle = BorderStyle.None;
        }

        private void AdjustListBoxHeight()
        {
            int maxHeight = Screen.PrimaryScreen!.WorkingArea.Height; // Maximum height of the screen
            int itemCount = this.listBox.Items.Count;
            int itemHeight = this.listBox.ItemHeight;

            int totalListBoxHeight = Math.Min(itemCount * itemHeight, maxHeight); // Ensure the height doesn't exceed the screen height
            this.listBox.Height = totalListBoxHeight;
        }

        private void PositionListBoxAboveOtherControls()
        {
            Point listBoxLocation = this.PointToScreen(new Point(0, -this.listBox.Height)); // Position above the MultiSelectBox
            this.listBox.Location = listBoxLocation;
            this.listBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void HideList()
        {
            this.listBox.Visible = false;
            listBox.BackColor = Color.White;
            listBox.BorderStyle = BorderStyle.None;
            listBox.SendToBack();
        }

        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Check if the item is selected
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                // Set the background color to the system's window color
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
            }
            else
            {
                // Set the background color to the default
                e.DrawBackground();
            }

            // Draw the item text
            string itemText = ((ListBox)sender).Items[e.Index].ToString()!;

            // Draw the item text
            e.Graphics.DrawString(itemText, e.Font!, Brushes.Black, e.Bounds, StringFormat.GenericDefault);

            // Draw the focus rectangle if the ListBox has focus
            e.DrawFocusRectangle();
        }

        private void MultiSelectPillbox_Load(object sender, EventArgs e)
        {
            // Set the ListBox's DrawMode property
            this.listBox.DrawMode = DrawMode.OwnerDrawFixed;

            // Set the border color
            this.listBox.BackColor = SystemColors.Window;
            this.listBox.BorderStyle = BorderStyle.FixedSingle;

            // Subscribe to the DrawItem event
            this.listBox.DrawItem += new DrawItemEventHandler(ListBox_DrawItem!);
        }
    }
}