using MetroSet_UI.Components;
using MetroSet_UI.Controls;

namespace PIMTool.Winforms
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            styleManager1 = new StyleManager();
            panelMenu = new Panel();
            tableLayoutPanel_Menus = new TableLayoutPanel();
            btnNewProject = new MetroSetButton();
            btnProjectList = new MetroSetButton();
            panelContentViews = new Panel();
            _metroSetControlBox1 = new MetroSetControlBox();
            metroSetControlBox1 = new MetroSetControlBox();
            panelBottom = new Panel();
            labelBottom = new Label();
            panelMenu.SuspendLayout();
            tableLayoutPanel_Menus.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // styleManager1
            // 
            styleManager1.CustomTheme = "C:\\Users\\KLO1HC\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            styleManager1.MetroForm = this;
            styleManager1.Style = MetroSet_UI.Enums.Style.Light;
            styleManager1.ThemeAuthor = "Narwin";
            styleManager1.ThemeName = "MetroLite";
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(tableLayoutPanel_Menus);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(12, 70);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(296, 718);
            panelMenu.TabIndex = 0;
            // 
            // tableLayoutPanel_Menus
            // 
            tableLayoutPanel_Menus.ColumnCount = 1;
            tableLayoutPanel_Menus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menus.Controls.Add(btnNewProject, 0, 1);
            tableLayoutPanel_Menus.Controls.Add(btnProjectList, 0, 0);
            tableLayoutPanel_Menus.Dock = DockStyle.Top;
            tableLayoutPanel_Menus.Location = new Point(0, 0);
            tableLayoutPanel_Menus.Name = "tableLayoutPanel_Menus";
            tableLayoutPanel_Menus.RowCount = 3;
            tableLayoutPanel_Menus.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_Menus.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_Menus.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_Menus.Size = new Size(296, 148);
            tableLayoutPanel_Menus.TabIndex = 0;
            // 
            // btnNewProject
            // 
            btnNewProject.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnNewProject.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnNewProject.DisabledForeColor = Color.Gray;
            btnNewProject.Dock = DockStyle.Fill;
            btnNewProject.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewProject.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnNewProject.HoverColor = Color.FromArgb(95, 207, 255);
            btnNewProject.HoverTextColor = Color.White;
            btnNewProject.IsDerivedStyle = true;
            btnNewProject.Location = new Point(3, 52);
            btnNewProject.Name = "btnNewProject";
            btnNewProject.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnNewProject.NormalColor = Color.FromArgb(65, 177, 225);
            btnNewProject.NormalTextColor = Color.White;
            btnNewProject.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnNewProject.PressColor = Color.FromArgb(35, 147, 195);
            btnNewProject.PressTextColor = Color.White;
            btnNewProject.Size = new Size(290, 43);
            btnNewProject.Style = MetroSet_UI.Enums.Style.Light;
            btnNewProject.StyleManager = null;
            btnNewProject.TabIndex = 1;
            btnNewProject.Text = "New";
            btnNewProject.ThemeAuthor = "Narwin";
            btnNewProject.ThemeName = "MetroLite";
            btnNewProject.Click += button2_Click;
            // 
            // btnProjectList
            // 
            btnProjectList.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnProjectList.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnProjectList.DisabledForeColor = Color.Gray;
            btnProjectList.Dock = DockStyle.Fill;
            btnProjectList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProjectList.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnProjectList.HoverColor = Color.FromArgb(95, 207, 255);
            btnProjectList.HoverTextColor = Color.White;
            btnProjectList.IsDerivedStyle = true;
            btnProjectList.Location = new Point(3, 3);
            btnProjectList.Name = "btnProjectList";
            btnProjectList.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnProjectList.NormalColor = Color.FromArgb(65, 177, 225);
            btnProjectList.NormalTextColor = Color.White;
            btnProjectList.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnProjectList.PressColor = Color.FromArgb(35, 147, 195);
            btnProjectList.PressTextColor = Color.White;
            btnProjectList.Size = new Size(290, 43);
            btnProjectList.Style = MetroSet_UI.Enums.Style.Light;
            btnProjectList.StyleManager = null;
            btnProjectList.TabIndex = 0;
            btnProjectList.Text = "Project List";
            btnProjectList.ThemeAuthor = "Narwin";
            btnProjectList.ThemeName = "MetroLite";
            btnProjectList.Click += button1_Click;
            // 
            // panelContentViews
            // 
            panelContentViews.Dock = DockStyle.Top;
            panelContentViews.Location = new Point(308, 70);
            panelContentViews.Name = "panelContentViews";
            panelContentViews.Size = new Size(1180, 670);
            panelContentViews.TabIndex = 1;
            // 
            // _metroSetControlBox1
            // 
            _metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _metroSetControlBox1.BackColor = Color.Transparent;
            _metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            _metroSetControlBox1.CloseHoverForeColor = Color.White;
            _metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            _metroSetControlBox1.DisabledForeColor = Color.DimGray;
            _metroSetControlBox1.IsDerivedStyle = true;
            _metroSetControlBox1.Location = new Point(1726, 13);
            _metroSetControlBox1.MaximizeBox = true;
            _metroSetControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            _metroSetControlBox1.MaximizeHoverForeColor = Color.Gray;
            _metroSetControlBox1.MaximizeNormalForeColor = Color.Gray;
            _metroSetControlBox1.MinimizeBox = true;
            _metroSetControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            _metroSetControlBox1.MinimizeHoverForeColor = Color.Gray;
            _metroSetControlBox1.MinimizeNormalForeColor = Color.Gray;
            _metroSetControlBox1.Name = "_metroSetControlBox1";
            _metroSetControlBox1.Size = new Size(100, 25);
            _metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            _metroSetControlBox1.StyleManager = styleManager1;
            _metroSetControlBox1.TabIndex = 1;
            _metroSetControlBox1.Text = "_metroSetControlBox1";
            _metroSetControlBox1.ThemeAuthor = "Narwin";
            _metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.BackColor = Color.Transparent;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(1388, 14);
            metroSetControlBox1.MaximizeBox = true;
            metroSetControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroSetControlBox1.MinimizeBox = true;
            metroSetControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroSetControlBox1.Name = "metroSetControlBox1";
            metroSetControlBox1.Size = new Size(100, 25);
            metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetControlBox1.StyleManager = styleManager1;
            metroSetControlBox1.TabIndex = 2;
            metroSetControlBox1.Text = "metroSetControlBox1";
            metroSetControlBox1.ThemeAuthor = "Narwin";
            metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(labelBottom);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(308, 746);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1180, 42);
            panelBottom.TabIndex = 3;
            // 
            // labelBottom
            // 
            labelBottom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelBottom.AutoSize = true;
            labelBottom.ForeColor = Color.DimGray;
            labelBottom.Location = new Point(403, 11);
            labelBottom.Name = "labelBottom";
            labelBottom.Size = new Size(208, 22);
            labelBottom.TabIndex = 0;
            labelBottom.Text = "PIMTool Training Project";
            labelBottom.TextAlign = ContentAlignment.MiddleCenter;
            labelBottom.UseMnemonic = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 800);
            Controls.Add(panelBottom);
            Controls.Add(metroSetControlBox1);
            Controls.Add(panelContentViews);
            Controls.Add(panelMenu);
            Controls.Add(_metroSetControlBox1);
            MaximumSize = new Size(1500, 800);
            MinimumSize = new Size(1500, 800);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            StyleManager = styleManager1;
            Text = "Main Window";
            Load += MainWindow_Load;
            panelMenu.ResumeLayout(false);
            tableLayoutPanel_Menus.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelContentViews;
        private TableLayoutPanel tableLayoutPanel_Menus;
        private MetroSetButton btnNewProject;
        private MetroSetButton btnProjectList;

        private MetroSet_UI.Controls.MetroSetControlBox _metroSetControlBox1;
        private StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private Panel panelBottom;
        private Label labelBottom;
    }
}
