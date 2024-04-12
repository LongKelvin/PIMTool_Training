using MetroSet_UI.Controls;

namespace PIMTool.Winforms.UserControls
{
    partial class NewProject
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
            lblNewProject = new MetroSetLabel();
            lblProjectNumber = new MetroSetLabel();
            txtProjectNumber = new MetroSetTextBox();
            lblProjectName = new MetroSetLabel();
            txtProjectName = new MetroSetTextBox();
            lblCustomer = new MetroSetLabel();
            txtCustomer = new MetroSetTextBox();
            lblGroup = new MetroSetLabel();
            cmbGroup = new MetroSetComboBox();
            lblMember = new MetroSetLabel();
            txtMember = new MetroSetTextBox();
            lblStatus = new MetroSetLabel();
            cmbStatus = new MetroSetComboBox();
            lblStartDate = new MetroSetLabel();
            dtStartDate = new DateTimePicker();
            lblEndDate = new MetroSetLabel();
            dtEndDate = new DateTimePicker();
            btnCancel = new MetroSetButton();
            btnCreateProject = new MetroSetButton();
            SuspendLayout();
            // 
            // lblNewProject
            // 
            lblNewProject.AutoSize = true;
            lblNewProject.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNewProject.IsDerivedStyle = true;
            lblNewProject.Location = new Point(20, 20);
            lblNewProject.Name = "lblNewProject";
            lblNewProject.Size = new Size(174, 37);
            lblNewProject.Style = MetroSet_UI.Enums.Style.Light;
            lblNewProject.StyleManager = null;
            lblNewProject.TabIndex = 0;
            lblNewProject.Text = "New Project";
            lblNewProject.ThemeAuthor = "Narwin";
            lblNewProject.ThemeName = "MetroLite";
            // 
            // lblProjectNumber
            // 
            lblProjectNumber.AutoSize = true;
            lblProjectNumber.Font = new Font("Microsoft Sans Serif", 10F);
            lblProjectNumber.IsDerivedStyle = true;
            lblProjectNumber.Location = new Point(20, 100);
            lblProjectNumber.Name = "lblProjectNumber";
            lblProjectNumber.Size = new Size(106, 17);
            lblProjectNumber.Style = MetroSet_UI.Enums.Style.Light;
            lblProjectNumber.StyleManager = null;
            lblProjectNumber.TabIndex = 1;
            lblProjectNumber.Text = "Project Number";
            lblProjectNumber.ThemeAuthor = "Narwin";
            lblProjectNumber.ThemeName = "MetroLite";
            // 
            // txtProjectNumber
            // 
            txtProjectNumber.AutoCompleteCustomSource = null;
            txtProjectNumber.AutoCompleteMode = AutoCompleteMode.None;
            txtProjectNumber.AutoCompleteSource = AutoCompleteSource.None;
            txtProjectNumber.BorderColor = Color.FromArgb(155, 155, 155);
            txtProjectNumber.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtProjectNumber.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtProjectNumber.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtProjectNumber.Font = new Font("Microsoft Sans Serif", 10F);
            txtProjectNumber.HoverColor = Color.FromArgb(102, 102, 102);
            txtProjectNumber.Image = null;
            txtProjectNumber.IsDerivedStyle = true;
            txtProjectNumber.Lines = null;
            txtProjectNumber.Location = new Point(220, 100);
            txtProjectNumber.MaxLength = 32767;
            txtProjectNumber.Multiline = false;
            txtProjectNumber.Name = "txtProjectNumber";
            txtProjectNumber.ReadOnly = false;
            txtProjectNumber.Size = new Size(300, 30);
            txtProjectNumber.Style = MetroSet_UI.Enums.Style.Light;
            txtProjectNumber.StyleManager = null;
            txtProjectNumber.TabIndex = 2;
            txtProjectNumber.TextAlign = HorizontalAlignment.Left;
            txtProjectNumber.ThemeAuthor = "Narwin";
            txtProjectNumber.ThemeName = "MetroLite";
            txtProjectNumber.UseSystemPasswordChar = false;
            txtProjectNumber.WatermarkText = "";
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Font = new Font("Microsoft Sans Serif", 10F);
            lblProjectName.IsDerivedStyle = true;
            lblProjectName.Location = new Point(20, 180);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(93, 17);
            lblProjectName.Style = MetroSet_UI.Enums.Style.Light;
            lblProjectName.StyleManager = null;
            lblProjectName.TabIndex = 3;
            lblProjectName.Text = "Project Name";
            lblProjectName.ThemeAuthor = "Narwin";
            lblProjectName.ThemeName = "MetroLite";
            // 
            // txtProjectName
            // 
            txtProjectName.AutoCompleteCustomSource = null;
            txtProjectName.AutoCompleteMode = AutoCompleteMode.None;
            txtProjectName.AutoCompleteSource = AutoCompleteSource.None;
            txtProjectName.BorderColor = Color.FromArgb(155, 155, 155);
            txtProjectName.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtProjectName.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtProjectName.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtProjectName.Font = new Font("Microsoft Sans Serif", 10F);
            txtProjectName.HoverColor = Color.FromArgb(102, 102, 102);
            txtProjectName.Image = null;
            txtProjectName.IsDerivedStyle = true;
            txtProjectName.Lines = null;
            txtProjectName.Location = new Point(220, 180);
            txtProjectName.MaxLength = 32767;
            txtProjectName.Multiline = false;
            txtProjectName.Name = "txtProjectName";
            txtProjectName.ReadOnly = false;
            txtProjectName.Size = new Size(600, 30);
            txtProjectName.Style = MetroSet_UI.Enums.Style.Light;
            txtProjectName.StyleManager = null;
            txtProjectName.TabIndex = 4;
            txtProjectName.TextAlign = HorizontalAlignment.Left;
            txtProjectName.ThemeAuthor = "Narwin";
            txtProjectName.ThemeName = "MetroLite";
            txtProjectName.UseSystemPasswordChar = false;
            txtProjectName.WatermarkText = "";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Microsoft Sans Serif", 10F);
            lblCustomer.IsDerivedStyle = true;
            lblCustomer.Location = new Point(20, 260);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(68, 17);
            lblCustomer.Style = MetroSet_UI.Enums.Style.Light;
            lblCustomer.StyleManager = null;
            lblCustomer.TabIndex = 5;
            lblCustomer.Text = "Customer";
            lblCustomer.ThemeAuthor = "Narwin";
            lblCustomer.ThemeName = "MetroLite";
            // 
            // txtCustomer
            // 
            txtCustomer.AutoCompleteCustomSource = null;
            txtCustomer.AutoCompleteMode = AutoCompleteMode.None;
            txtCustomer.AutoCompleteSource = AutoCompleteSource.None;
            txtCustomer.BorderColor = Color.FromArgb(155, 155, 155);
            txtCustomer.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtCustomer.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtCustomer.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtCustomer.Font = new Font("Microsoft Sans Serif", 10F);
            txtCustomer.HoverColor = Color.FromArgb(102, 102, 102);
            txtCustomer.Image = null;
            txtCustomer.IsDerivedStyle = true;
            txtCustomer.Lines = null;
            txtCustomer.Location = new Point(220, 260);
            txtCustomer.MaxLength = 32767;
            txtCustomer.Multiline = false;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = false;
            txtCustomer.Size = new Size(600, 30);
            txtCustomer.Style = MetroSet_UI.Enums.Style.Light;
            txtCustomer.StyleManager = null;
            txtCustomer.TabIndex = 6;
            txtCustomer.TextAlign = HorizontalAlignment.Left;
            txtCustomer.ThemeAuthor = "Narwin";
            txtCustomer.ThemeName = "MetroLite";
            txtCustomer.UseSystemPasswordChar = false;
            txtCustomer.WatermarkText = "";
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Font = new Font("Microsoft Sans Serif", 10F);
            lblGroup.IsDerivedStyle = true;
            lblGroup.Location = new Point(20, 340);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(48, 17);
            lblGroup.Style = MetroSet_UI.Enums.Style.Light;
            lblGroup.StyleManager = null;
            lblGroup.TabIndex = 7;
            lblGroup.Text = "Group";
            lblGroup.ThemeAuthor = "Narwin";
            lblGroup.ThemeName = "MetroLite";
            // 
            // cmbGroup
            // 
            cmbGroup.AllowDrop = true;
            cmbGroup.ArrowColor = Color.FromArgb(150, 150, 150);
            cmbGroup.BackColor = Color.Transparent;
            cmbGroup.BackgroundColor = Color.FromArgb(238, 238, 238);
            cmbGroup.BorderColor = Color.FromArgb(150, 150, 150);
            cmbGroup.CausesValidation = false;
            cmbGroup.DisabledBackColor = Color.FromArgb(204, 204, 204);
            cmbGroup.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            cmbGroup.DisabledForeColor = Color.FromArgb(136, 136, 136);
            cmbGroup.DrawMode = DrawMode.OwnerDrawFixed;
            cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGroup.Font = new Font("Microsoft Sans Serif", 11F);
            cmbGroup.FormattingEnabled = true;
            cmbGroup.IsDerivedStyle = true;
            cmbGroup.ItemHeight = 26;
            cmbGroup.Location = new Point(220, 340);
            cmbGroup.Name = "cmbGroup";
            cmbGroup.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            cmbGroup.SelectedItemForeColor = Color.White;
            cmbGroup.Size = new Size(300, 32);
            cmbGroup.Style = MetroSet_UI.Enums.Style.Light;
            cmbGroup.StyleManager = null;
            cmbGroup.TabIndex = 8;
            cmbGroup.ThemeAuthor = "Narwin";
            cmbGroup.ThemeName = "MetroLite";
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.Font = new Font("Microsoft Sans Serif", 10F);
            lblMember.IsDerivedStyle = true;
            lblMember.Location = new Point(20, 420);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(59, 17);
            lblMember.Style = MetroSet_UI.Enums.Style.Light;
            lblMember.StyleManager = null;
            lblMember.TabIndex = 9;
            lblMember.Text = "Member";
            lblMember.ThemeAuthor = "Narwin";
            lblMember.ThemeName = "MetroLite";
            // 
            // txtMember
            // 
            txtMember.AutoCompleteCustomSource = null;
            txtMember.AutoCompleteMode = AutoCompleteMode.None;
            txtMember.AutoCompleteSource = AutoCompleteSource.None;
            txtMember.BorderColor = Color.FromArgb(155, 155, 155);
            txtMember.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtMember.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtMember.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtMember.Font = new Font("Microsoft Sans Serif", 10F);
            txtMember.HoverColor = Color.FromArgb(102, 102, 102);
            txtMember.Image = null;
            txtMember.IsDerivedStyle = true;
            txtMember.Lines = null;
            txtMember.Location = new Point(220, 420);
            txtMember.MaxLength = 32767;
            txtMember.Multiline = false;
            txtMember.Name = "txtMember";
            txtMember.ReadOnly = false;
            txtMember.Size = new Size(300, 30);
            txtMember.Style = MetroSet_UI.Enums.Style.Light;
            txtMember.StyleManager = null;
            txtMember.TabIndex = 10;
            txtMember.TextAlign = HorizontalAlignment.Left;
            txtMember.ThemeAuthor = "Narwin";
            txtMember.ThemeName = "MetroLite";
            txtMember.UseSystemPasswordChar = false;
            txtMember.WatermarkText = "";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 10F);
            lblStatus.IsDerivedStyle = true;
            lblStatus.Location = new Point(20, 500);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(48, 17);
            lblStatus.Style = MetroSet_UI.Enums.Style.Light;
            lblStatus.StyleManager = null;
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status";
            lblStatus.ThemeAuthor = "Narwin";
            lblStatus.ThemeName = "MetroLite";
            // 
            // cmbStatus
            // 
            cmbStatus.AllowDrop = true;
            cmbStatus.ArrowColor = Color.FromArgb(150, 150, 150);
            cmbStatus.BackColor = Color.Transparent;
            cmbStatus.BackgroundColor = Color.FromArgb(238, 238, 238);
            cmbStatus.BorderColor = Color.FromArgb(150, 150, 150);
            cmbStatus.CausesValidation = false;
            cmbStatus.DisabledBackColor = Color.FromArgb(204, 204, 204);
            cmbStatus.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            cmbStatus.DisabledForeColor = Color.FromArgb(136, 136, 136);
            cmbStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Microsoft Sans Serif", 11F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.IsDerivedStyle = true;
            cmbStatus.ItemHeight = 26;
            cmbStatus.Location = new Point(220, 500);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            cmbStatus.SelectedItemForeColor = Color.White;
            cmbStatus.Size = new Size(300, 32);
            cmbStatus.Style = MetroSet_UI.Enums.Style.Light;
            cmbStatus.StyleManager = null;
            cmbStatus.TabIndex = 12;
            cmbStatus.ThemeAuthor = "Narwin";
            cmbStatus.ThemeName = "MetroLite";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Microsoft Sans Serif", 10F);
            lblStartDate.IsDerivedStyle = true;
            lblStartDate.Location = new Point(20, 580);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(72, 17);
            lblStartDate.Style = MetroSet_UI.Enums.Style.Light;
            lblStartDate.StyleManager = null;
            lblStartDate.TabIndex = 13;
            lblStartDate.Text = "Start Date";
            lblStartDate.ThemeAuthor = "Narwin";
            lblStartDate.ThemeName = "MetroLite";
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(220, 580);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(300, 23);
            dtStartDate.TabIndex = 14;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Microsoft Sans Serif", 10F);
            lblEndDate.IsDerivedStyle = true;
            lblEndDate.Location = new Point(600, 580);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(67, 17);
            lblEndDate.Style = MetroSet_UI.Enums.Style.Light;
            lblEndDate.StyleManager = null;
            lblEndDate.TabIndex = 15;
            lblEndDate.Text = "End Date";
            lblEndDate.ThemeAuthor = "Narwin";
            lblEndDate.ThemeName = "MetroLite";
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new Point(800, 580);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(300, 23);
            dtEndDate.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnCancel.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnCancel.DisabledForeColor = Color.Gray;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10F);
            btnCancel.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnCancel.HoverColor = Color.FromArgb(95, 207, 255);
            btnCancel.HoverTextColor = Color.White;
            btnCancel.IsDerivedStyle = true;
            btnCancel.Location = new Point(737, 660);
            btnCancel.Name = "btnCancel";
            btnCancel.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnCancel.NormalColor = Color.FromArgb(65, 177, 225);
            btnCancel.NormalTextColor = Color.White;
            btnCancel.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnCancel.PressColor = Color.FromArgb(35, 147, 195);
            btnCancel.PressTextColor = Color.White;
            btnCancel.Size = new Size(150, 40);
            btnCancel.Style = MetroSet_UI.Enums.Style.Light;
            btnCancel.StyleManager = null;
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.ThemeAuthor = "Narwin";
            btnCancel.ThemeName = "MetroLite";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreateProject
            // 
            btnCreateProject.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnCreateProject.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnCreateProject.DisabledForeColor = Color.Gray;
            btnCreateProject.Font = new Font("Microsoft Sans Serif", 10F);
            btnCreateProject.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnCreateProject.HoverColor = Color.FromArgb(95, 207, 255);
            btnCreateProject.HoverTextColor = Color.White;
            btnCreateProject.IsDerivedStyle = true;
            btnCreateProject.Location = new Point(950, 660);
            btnCreateProject.Name = "btnCreateProject";
            btnCreateProject.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnCreateProject.NormalColor = Color.FromArgb(65, 177, 225);
            btnCreateProject.NormalTextColor = Color.White;
            btnCreateProject.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnCreateProject.PressColor = Color.FromArgb(35, 147, 195);
            btnCreateProject.PressTextColor = Color.White;
            btnCreateProject.Size = new Size(150, 40);
            btnCreateProject.Style = MetroSet_UI.Enums.Style.Light;
            btnCreateProject.StyleManager = null;
            btnCreateProject.TabIndex = 18;
            btnCreateProject.Text = "Create Project";
            btnCreateProject.ThemeAuthor = "Narwin";
            btnCreateProject.ThemeName = "MetroLite";
            btnCreateProject.Click += btnCreateProject_Click;
            // 
            // NewProject
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            Controls.Add(btnCreateProject);
            Controls.Add(btnCancel);
            Controls.Add(dtEndDate);
            Controls.Add(lblEndDate);
            Controls.Add(dtStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(txtMember);
            Controls.Add(lblMember);
            Controls.Add(cmbGroup);
            Controls.Add(lblGroup);
            Controls.Add(txtCustomer);
            Controls.Add(lblCustomer);
            Controls.Add(txtProjectName);
            Controls.Add(lblProjectName);
            Controls.Add(txtProjectNumber);
            Controls.Add(lblProjectNumber);
            Controls.Add(lblNewProject);
            Name = "NewProject";
            Size = new Size(1150, 720);
            Load += NewProject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private MetroSetLabel lblNewProject;
        private MetroSetLabel lblProjectNumber;
        private MetroSetTextBox txtProjectNumber;
        private MetroSetLabel lblProjectName;
        private MetroSetTextBox txtProjectName;
        private MetroSetLabel lblCustomer;
        private MetroSetTextBox txtCustomer;
        private MetroSetLabel lblGroup;
        private MetroSetComboBox cmbGroup;
        private MetroSetLabel lblMember;
        private MetroSetTextBox txtMember;
        private MetroSetLabel lblStatus;
        private MetroSetComboBox cmbStatus;
        private MetroSetLabel lblStartDate;
        private DateTimePicker dtStartDate;
        private MetroSetLabel lblEndDate;
        private DateTimePicker dtEndDate;
        private MetroSetButton btnCancel;
        private MetroSetButton btnCreateProject;
    }


    #endregion
}

