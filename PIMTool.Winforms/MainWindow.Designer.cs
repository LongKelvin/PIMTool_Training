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
            panelMenu = new Panel();
            tableLayoutPanel_Menus = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelContentViews = new Panel();
            panelMenu.SuspendLayout();
            tableLayoutPanel_Menus.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(tableLayoutPanel_Menus);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 450);
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
            button3.UseVisualStyleBackColor = true;
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
            button2.UseVisualStyleBackColor = true;
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
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelContentViews
            // 
            panelContentViews.Dock = DockStyle.Fill;
            panelContentViews.Location = new Point(200, 0);
            panelContentViews.Name = "panelContentViews";
            panelContentViews.Size = new Size(600, 450);
            panelContentViews.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContentViews);
            Controls.Add(panelMenu);
            Name = "MainWindow";
            Text = "Main Window";
            panelMenu.ResumeLayout(false);
            tableLayoutPanel_Menus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelContentViews;
        private TableLayoutPanel tableLayoutPanel_Menus;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
