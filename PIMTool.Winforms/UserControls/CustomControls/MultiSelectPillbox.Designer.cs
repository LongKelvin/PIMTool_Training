using System.Configuration;

namespace PIMTool.Winforms.UserControls.CustomControls
{
    partial class MultiSelectBox
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox listBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            BackColor = Color.White;
            this.SuspendLayout();

            // 
            // searchTextBox
            // 
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchTextBox.Location = new System.Drawing.Point(0, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(150, 20);

            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.searchTextBox.GotFocus += new System.EventHandler(this.SearchTextBox_GotFocus);
            this.searchTextBox.LostFocus += new System.EventHandler(this.SearchTextBox_LostFocus);

            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 20);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox.Size = new System.Drawing.Size(150, 130);
            this.listBox.TabIndex = 1;
            this.listBox.Visible = false;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            this.listBox.LostFocus += new System.EventHandler(this.ListBox_LostFocus);
            this.listBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            this.listBox.MouseClick += ListBox_MouseClick;
            this.listBox.BorderStyle = BorderStyle.None;
            this.listBox.SelectionMode = SelectionMode.MultiSimple;
            this.listBox.BringToFront();


            // 
            // MultiSelectBox
            // 
           
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.searchTextBox);
            this.Name = "MultiSelectBox";
            this.Size = new System.Drawing.Size(150, 150);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
