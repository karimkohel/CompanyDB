
namespace CompanyUI
{
    partial class HomeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.HomeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDepartmentSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.HomeTitleLabel = new System.Windows.Forms.Label();
            this.DepartmentListBox = new System.Windows.Forms.ListBox();
            this.findDepartmentEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeMenuStrip
            // 
            this.HomeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.searchToolStripMenuItem1,
            this.findToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.HomeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.HomeMenuStrip.Name = "HomeMenuStrip";
            this.HomeMenuStrip.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.HomeMenuStrip.Size = new System.Drawing.Size(1131, 27);
            this.HomeMenuStrip.TabIndex = 0;
            this.HomeMenuStrip.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEmployeeToolStripMenuItem,
            this.newDepartmentToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newEmployeeToolStripMenuItem
            // 
            this.newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            this.newEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newEmployeeToolStripMenuItem.Text = "New Employee";
            this.newEmployeeToolStripMenuItem.Click += new System.EventHandler(this.newEmployeeToolStripMenuItem_Click);
            // 
            // newDepartmentToolStripMenuItem
            // 
            this.newDepartmentToolStripMenuItem.Name = "newDepartmentToolStripMenuItem";
            this.newDepartmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newDepartmentToolStripMenuItem.Text = "New Department";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(190, 23);
            this.searchToolStripMenuItem.Tag = "";
            this.searchToolStripMenuItem.ToolTipText = "\r\n";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.searchToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchToolStripMenuItem1.Enabled = false;
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(57, 23);
            this.searchToolStripMenuItem1.Text = "Search:";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findEmployeeToolStripMenuItem,
            this.findDepartmentToolStripMenuItem});
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.findToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // findEmployeeToolStripMenuItem
            // 
            this.findEmployeeToolStripMenuItem.Name = "findEmployeeToolStripMenuItem";
            this.findEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findEmployeeToolStripMenuItem.Text = "Find employee";
            // 
            // findDepartmentToolStripMenuItem
            // 
            this.findDepartmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findDepartmentEmployeesToolStripMenuItem,
            this.findDepartmentSalaryToolStripMenuItem});
            this.findDepartmentToolStripMenuItem.Name = "findDepartmentToolStripMenuItem";
            this.findDepartmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findDepartmentToolStripMenuItem.Text = "Find Department";
            // 
            // findDepartmentSalaryToolStripMenuItem
            // 
            this.findDepartmentSalaryToolStripMenuItem.Name = "findDepartmentSalaryToolStripMenuItem";
            this.findDepartmentSalaryToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.findDepartmentSalaryToolStripMenuItem.Text = "Find Department Salary";
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.ItemHeight = 30;
            this.EmployeeListBox.Location = new System.Drawing.Point(27, 238);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(512, 332);
            this.EmployeeListBox.TabIndex = 1;
            this.EmployeeListBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeListBox_SelectedIndexChanged);
            // 
            // HomeTitleLabel
            // 
            this.HomeTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeTitleLabel.AutoSize = true;
            this.HomeTitleLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitleLabel.Location = new System.Drawing.Point(433, 61);
            this.HomeTitleLabel.Name = "HomeTitleLabel";
            this.HomeTitleLabel.Size = new System.Drawing.Size(264, 59);
            this.HomeTitleLabel.TabIndex = 2;
            this.HomeTitleLabel.Text = "CompanyDB";
            this.HomeTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DepartmentListBox
            // 
            this.DepartmentListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepartmentListBox.FormattingEnabled = true;
            this.DepartmentListBox.ItemHeight = 30;
            this.DepartmentListBox.Location = new System.Drawing.Point(592, 238);
            this.DepartmentListBox.Name = "DepartmentListBox";
            this.DepartmentListBox.Size = new System.Drawing.Size(512, 332);
            this.DepartmentListBox.TabIndex = 3;
            // 
            // findDepartmentEmployeesToolStripMenuItem
            // 
            this.findDepartmentEmployeesToolStripMenuItem.Name = "findDepartmentEmployeesToolStripMenuItem";
            this.findDepartmentEmployeesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.findDepartmentEmployeesToolStripMenuItem.Text = "Find Department Employees";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findMoreToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // findMoreToolStripMenuItem
            // 
            this.findMoreToolStripMenuItem.Name = "findMoreToolStripMenuItem";
            this.findMoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findMoreToolStripMenuItem.Text = "Find More";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contactUsToolStripMenuItem.Text = "Contact us";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 670);
            this.Controls.Add(this.DepartmentListBox);
            this.Controls.Add(this.HomeTitleLabel);
            this.Controls.Add(this.EmployeeListBox);
            this.Controls.Add(this.HomeMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.HomeMenuStrip.ResumeLayout(false);
            this.HomeMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip HomeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Label HomeTitleLabel;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findDepartmentSalaryToolStripMenuItem;
        private System.Windows.Forms.ListBox DepartmentListBox;
        private System.Windows.Forms.ToolStripMenuItem findDepartmentEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findMoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
    }
}

