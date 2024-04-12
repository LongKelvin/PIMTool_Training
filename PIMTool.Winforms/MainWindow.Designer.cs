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
            button3 = new MetroSetButton();
            button2 = new MetroSetButton();
            button1 = new MetroSetButton();
            panelContentViews = new Panel();
            _metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            panelMenu.SuspendLayout();
            tableLayoutPanel_Menus.SuspendLayout();
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
            panelMenu.Size = new Size(200, 368);
            panelMenu.TabIndex = 0;
            // 
            // tableLayoutPanel_Menus
            // 
            tableLayoutPanel_Menus.ColumnCount = 1;
            tableLayoutPanel_Menus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menus.Controls.Add(button3, 0, 2);
            tableLayoutPanel_Menus.Controls.Add(button2, 0, 1);
            tableLayoutPanel_Menus.Controls.Add(button1, 0, 0);
            tableLayoutPanel_Menus.Dock = DockStyle.Top;
            tableLayoutPanel_Menus.Location = new Point(0, 0);
            tableLayoutPanel_Menus.Name = "tableLayoutPanel_Menus";
            tableLayoutPanel_Menus.RowCount = 3;
            tableLayoutPanel_Menus.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_Menus.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_Menus.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_Menus.Size = new Size(200, 148);
            tableLayoutPanel_Menus.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(3, 101);
            button3.Name = "button3";
            button3.Size = new Size(194, 44);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 52);
            button2.Name = "button2";
            button2.Size = new Size(194, 43);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(194, 43);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.Click += button1_Click;
            // 
            // panelContentViews
            // 
            panelContentViews.Dock = DockStyle.Fill;
            panelContentViews.Location = new Point(212, 70);
            panelContentViews.Name = "panelContentViews";
            panelContentViews.Size = new Size(576, 368);
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
            _metroSetControlBox1.Location = new Point(1026, 13);
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
            metroSetControlBox1.Location = new Point(688, 14);
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
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(metroSetControlBox1);
            Controls.Add(panelContentViews);
            Controls.Add(panelMenu);
            Controls.Add(_metroSetControlBox1);
            Name = "MainWindow";
            StyleManager = styleManager1;
            Text = "Main Window";
            panelMenu.ResumeLayout(false);
            tableLayoutPanel_Menus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelContentViews;
        private TableLayoutPanel tableLayoutPanel_Menus;
        private MetroSetButton button3;
        private MetroSetButton button2;
        private MetroSetButton button1;

        private MetroSet_UI.Controls.MetroSetControlBox _metroSetControlBox1;
        private StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}
