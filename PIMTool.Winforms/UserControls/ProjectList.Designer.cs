using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

using MetroSet_UI.Controls;

namespace PIMTool.Winforms.UserControls
{
    partial class ProjectList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();

            dataGridViewProjects = new MaterialDataTable();
            SelectColumn = new DataGridViewCheckBoxColumn();
            DeleteColumn = new DataGridViewButtonColumn();
            txtSearchBox = new MetroSetTextBox();
            cmbProjectStatus = new MetroSetComboBox();
            btnSearch = new MetroSetButton();
            btnReset = new MetroSetButton();
            lblProjectList = new MetroSetLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjects).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProjects
            // 
            dataGridViewProjects.ShowVerticalScroll = true;
            dataGridViewProjects.ColorStripColor = Primary.Blue100;
            dataGridViewProjects.ShowColorStripping = true;
            dataGridViewProjects.AllowUserToAddRows = false;
            dataGridViewProjects.AllowUserToDeleteRows = false;
            dataGridViewProjects.AllowUserToResizeRows = false;
            dataGridViewProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjects.BackgroundColor = Color.White;
            dataGridViewProjects.BorderStyle = BorderStyle.None;
            dataGridViewProjects.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewProjects.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridViewProjects.ScrollBars = ScrollBars.Vertical;
            //dataGridViewProjects.ShowVerticalScroll = true;
            
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProjects.ColumnHeadersHeight = 56;
            dataGridViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewProjects.Columns.AddRange(new DataGridViewColumn[] { DeleteColumn, SelectColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 81, 181);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProjects.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProjects.Depth = 0;
            dataGridViewProjects.EnableHeadersVisualStyles = false;
            dataGridViewProjects.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewProjects.GridColor = Color.FromArgb(95, 207, 255);
            dataGridViewProjects.Location = new Point(15, 179);
            dataGridViewProjects.MouseState = MouseState.HOVER;
            dataGridViewProjects.Name = "dataGridViewProjects";
            dataGridViewProjects.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProjects.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewProjects.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProjects.RowTemplate.Height = 24;
            dataGridViewProjects.ScrollBars = ScrollBars.None;
            dataGridViewProjects.ShowVerticalScroll = false;
            dataGridViewProjects.Size = new Size(1101, 400);
            dataGridViewProjects.TabIndex = 0;
            dataGridViewProjects.DataError += DataGridViewProjects_DataError;
            dataGridViewProjects.CellContentClick += DataGridViewProjects_DeleteButton_CellContentClick;
            dataGridViewProjects.CellContentClick += DataGridViewProjects_SelectColumn_CellContentClick;
            dataGridViewProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // SelectColumn
            // 
           

            SelectColumn.HeaderText = "Select";
            SelectColumn.Name = "SelectColumn";
            SelectColumn.ReadOnly = false;
            SelectColumn.DisplayIndex = 0;
            SelectColumn.DataPropertyName = "IsSelected";

            // 
            // DeleteColumn
            // 
            DeleteColumn.HeaderText = "Delete";
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.ReadOnly = true;
            DeleteColumn.Text = "Delete";
            DeleteColumn.UseColumnTextForButtonValue = true;

            // format the columns button to be a MetroSetButton
            DeleteColumn.FlatStyle = FlatStyle.Flat;
            DeleteColumn.DefaultCellStyle.NullValue = "Delete";
            DeleteColumn.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteColumn.DefaultCellStyle.ForeColor = Color.SkyBlue;
            // set button color when mouse hover on it
            DeleteColumn.DefaultCellStyle.BackColor = Color.FromArgb(35, 120,195);
            DeleteColumn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 120, 195);
            DeleteColumn.DefaultCellStyle.SelectionForeColor = Color.White;
            DeleteColumn.DefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            DeleteColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DeleteColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            

            // 
            // txtSearchBox
            // 
            txtSearchBox.AutoCompleteCustomSource = null;
            txtSearchBox.AutoCompleteMode = AutoCompleteMode.None;
            txtSearchBox.AutoCompleteSource = AutoCompleteSource.None;
            txtSearchBox.BorderColor = Color.FromArgb(155, 155, 155);
            txtSearchBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtSearchBox.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtSearchBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtSearchBox.Font = new Font("Microsoft Sans Serif", 10F);
            txtSearchBox.HoverColor = Color.FromArgb(102, 102, 102);
            txtSearchBox.Image = null;
            txtSearchBox.IsDerivedStyle = true;
            txtSearchBox.Lines = null;
            txtSearchBox.Location = new Point(15, 100);
            txtSearchBox.MaxLength = 32767;
            txtSearchBox.Multiline = false;
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.ReadOnly = false;
            txtSearchBox.Size = new Size(385, 30);
            txtSearchBox.Style = MetroSet_UI.Enums.Style.Light;
            txtSearchBox.StyleManager = null;
            txtSearchBox.TabIndex = 0;
            txtSearchBox.TextAlign = HorizontalAlignment.Left;
            txtSearchBox.ThemeAuthor = "Narwin";
            txtSearchBox.ThemeName = "MetroLite";
            txtSearchBox.UseSystemPasswordChar = false;
            txtSearchBox.WatermarkText = "";
            // 
            // cmbProjectStatus
            // 
            cmbProjectStatus.AllowDrop = true;
            cmbProjectStatus.ArrowColor = Color.FromArgb(150, 150, 150);
            cmbProjectStatus.BackColor = Color.Transparent;
            cmbProjectStatus.BackgroundColor = Color.FromArgb(238, 238, 238);
            cmbProjectStatus.BorderColor = Color.FromArgb(150, 150, 150);
            cmbProjectStatus.CausesValidation = false;
            cmbProjectStatus.DisabledBackColor = Color.FromArgb(204, 204, 204);
            cmbProjectStatus.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            cmbProjectStatus.DisabledForeColor = Color.FromArgb(136, 136, 136);
            cmbProjectStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cmbProjectStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProjectStatus.Font = new Font("Microsoft Sans Serif", 11F);
            cmbProjectStatus.IsDerivedStyle = true;
            cmbProjectStatus.ItemHeight = 26;
            cmbProjectStatus.Location = new Point(430, 100);
            cmbProjectStatus.Name = "cmbProjectStatus";
            cmbProjectStatus.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            cmbProjectStatus.SelectedItemForeColor = Color.White;
            cmbProjectStatus.Size = new Size(250, 32);
            cmbProjectStatus.Style = MetroSet_UI.Enums.Style.Light;
            cmbProjectStatus.StyleManager = null;
            cmbProjectStatus.TabIndex = 1;
            cmbProjectStatus.ThemeAuthor = "Narwin";
            cmbProjectStatus.ThemeName = "MetroLite";
            // 
            // btnSearch
            // 
            btnSearch.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnSearch.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnSearch.DisabledForeColor = Color.Gray;
            btnSearch.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnSearch.HoverColor = Color.FromArgb(95, 207, 255);
            btnSearch.HoverTextColor = Color.White;
            btnSearch.IsDerivedStyle = true;
            btnSearch.Location = new Point(773, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnSearch.NormalColor = Color.FromArgb(65, 177, 225);
            btnSearch.NormalTextColor = Color.White;
            btnSearch.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnSearch.PressColor = Color.FromArgb(35, 147, 195);
            btnSearch.PressTextColor = Color.White;
            btnSearch.Size = new Size(134, 35);
            btnSearch.Style = MetroSet_UI.Enums.Style.Light;
            btnSearch.StyleManager = null;
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search Project";
            btnSearch.ThemeAuthor = "Narwin";
            btnSearch.ThemeName = "MetroLite";
            btnSearch.Click += SearchButton_Click;
            // 
            // btnReset
            // 
            btnReset.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnReset.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnReset.DisabledForeColor = Color.Gray;
            btnReset.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Transparent;
            btnReset.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnReset.HoverColor = Color.FromArgb(95, 207, 255);
            btnReset.HoverTextColor = Color.White;
            btnReset.IsDerivedStyle = true;
            btnReset.Location = new Point(934, 101);
            btnReset.Name = "btnReset";
            btnReset.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnReset.NormalColor = Color.FromArgb(65, 177, 225);
            btnReset.NormalTextColor = Color.White;
            btnReset.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnReset.PressColor = Color.FromArgb(35, 147, 195);
            btnReset.PressTextColor = Color.White;
            btnReset.Size = new Size(100, 35);
            btnReset.Style = MetroSet_UI.Enums.Style.Light;
            btnReset.StyleManager = null;
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.ThemeAuthor = "Narwin";
            btnReset.ThemeName = "MetroLite";
            btnReset.Click += ResetSearchButton_Click;
            // 
            // lblProjectList
            // 
            lblProjectList.AutoSize = true;
            lblProjectList.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblProjectList.IsDerivedStyle = true;
            lblProjectList.Location = new Point(20, 20);
            lblProjectList.Name = "lblProjectList";
            lblProjectList.Size = new Size(161, 37);
            lblProjectList.Style = MetroSet_UI.Enums.Style.Light;
            lblProjectList.StyleManager = null;
            lblProjectList.TabIndex = 4;
            lblProjectList.Text = "Project List";
            lblProjectList.ThemeAuthor = "Narwin";
            lblProjectList.ThemeName = "MetroLite";


            // 
            // lblSelectedProjects
            // 
            lblSelectedProjects = new MetroSetLabel();
            lblSelectedProjects.AutoSize = true;
            lblSelectedProjects.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSelectedProjects.IsDerivedStyle = true;
            lblSelectedProjects.Location = new Point(15, 600);
            lblSelectedProjects.Name = "lblSelectedProjects";
            lblSelectedProjects.Size = new Size(0, 0);
            lblSelectedProjects.Style = MetroSet_UI.Enums.Style.Light;
            lblSelectedProjects.StyleManager = null;
            lblSelectedProjects.TabIndex = 5;
            lblSelectedProjects.Text = "Selected: ";
            lblSelectedProjects.ThemeAuthor = "Narwin";
            lblSelectedProjects.ThemeName = "MetroLite";
            Controls.Add(lblSelectedProjects);

            // Create a label to display the number of selected projects
            lblSelectedProjectCount = new MetroSetLabel();
            lblSelectedProjectCount.AutoSize = true;
            lblSelectedProjectCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSelectedProjectCount.IsDerivedStyle = true;
            lblSelectedProjectCount.Location = new Point(lblSelectedProjects.Right, lblSelectedProjects.Top);
            lblSelectedProjectCount.Name = "lblSelectedProjectCount";
            lblSelectedProjectCount.Size = new Size(0, 0);
            lblSelectedProjectCount.Style = MetroSet_UI.Enums.Style.Light;
            lblSelectedProjectCount.StyleManager = null;
            lblSelectedProjectCount.TabIndex = 7;
            lblSelectedProjectCount.Text = "0";
            lblSelectedProjectCount.ThemeAuthor = "Narwin";
            lblSelectedProjectCount.ThemeName = "MetroLite";
            Controls.Add(lblSelectedProjectCount);

            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected = new MetroSetButton();
            btnDeleteSelected.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnDeleteSelected.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnDeleteSelected.DisabledForeColor = Color.Gray;
            btnDeleteSelected.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteSelected.ForeColor = Color.Transparent;
            btnDeleteSelected.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnDeleteSelected.HoverColor = Color.FromArgb(95, 207, 255);
            btnDeleteSelected.HoverTextColor = Color.Red;
            btnDeleteSelected.IsDerivedStyle = true;
            btnDeleteSelected.Location = new Point(1016, 600);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnDeleteSelected.NormalColor = Color.FromArgb(65, 177, 225);
            btnDeleteSelected.NormalTextColor = Color.White;
            btnDeleteSelected.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnDeleteSelected.PressColor = Color.FromArgb(35, 147, 195);
            btnDeleteSelected.PressTextColor = Color.White;
            btnDeleteSelected.Size = new Size(150, 35);
            btnDeleteSelected.Style = MetroSet_UI.Enums.Style.Light;
            btnDeleteSelected.BackgroundImage = SystemIcons.Asterisk.ToBitmap();
            btnDeleteSelected.StyleManager = null;
            btnDeleteSelected.TabIndex = 6;
            btnDeleteSelected.Text = "Delete Projects";
            btnDeleteSelected.ThemeAuthor = "Narwin";
            btnDeleteSelected.ThemeName = "MetroLite";
            btnDeleteSelected.Click += DeleteSelectedProjects_Click;
            Controls.Add(btnDeleteSelected);


            // 
            // ProjectList
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 720);
            Controls.Add(lblProjectList);
            Controls.Add(txtSearchBox);
            Controls.Add(cmbProjectStatus);
            Controls.Add(btnSearch);
            Controls.Add(btnReset);
            Controls.Add(dataGridViewProjects);
            Name = "ProjectList";
            Load += ProjectList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialDataTable dataGridViewProjects;
        private DataGridViewButtonColumn DeleteColumn;
        private DataGridViewCheckBoxColumn SelectColumn;

        private MetroSetTextBox txtSearchBox;
        private MetroSetComboBox cmbProjectStatus;
        private MetroSetButton btnSearch;
        private MetroSetButton btnReset;
        private MetroSetLabel lblProjectList;
        private MetroSetLabel lblSelectedProjects;
        private MetroSetButton btnDeleteSelected;
        private MetroSetLabel lblSelectedProjectCount;
    }
}
