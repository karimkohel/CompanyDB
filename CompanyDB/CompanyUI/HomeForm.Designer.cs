﻿
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
            this.searchEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectDepartmentDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectEmployeeDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDataseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDatabaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDepartmentEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDepartmentSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.HomeTitleLabel = new System.Windows.Forms.Label();
            this.DepartmentListBox = new System.Windows.Forms.ListBox();
            this.HomeOpenFileDialoge = new System.Windows.Forms.OpenFileDialog();
            this.HomeFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.LoadEmployeeDBButton = new System.Windows.Forms.Button();
            this.CreateEmployeeDbButton = new System.Windows.Forms.Button();
            this.CreateDepartmentDbButton = new System.Windows.Forms.Button();
            this.LoadDepartmentDBButton = new System.Windows.Forms.Button();
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
            this.newDepartmentToolStripMenuItem,
            this.searchEmployeeToolStripMenuItem,
            this.searchDepartmentToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newEmployeeToolStripMenuItem
            // 
            this.newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            this.newEmployeeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newEmployeeToolStripMenuItem.Text = "New Employee";
            this.newEmployeeToolStripMenuItem.Click += new System.EventHandler(this.newEmployeeToolStripMenuItem_Click);
            // 
            // newDepartmentToolStripMenuItem
            // 
            this.newDepartmentToolStripMenuItem.Name = "newDepartmentToolStripMenuItem";
            this.newDepartmentToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newDepartmentToolStripMenuItem.Text = "New Department";
            this.newDepartmentToolStripMenuItem.Click += new System.EventHandler(this.newDepartmentToolStripMenuItem_Click);
            // 
            // searchEmployeeToolStripMenuItem
            // 
            this.searchEmployeeToolStripMenuItem.Name = "searchEmployeeToolStripMenuItem";
            this.searchEmployeeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.searchEmployeeToolStripMenuItem.Text = "Search Employee";
            // 
            // searchDepartmentToolStripMenuItem
            // 
            this.searchDepartmentToolStripMenuItem.Name = "searchDepartmentToolStripMenuItem";
            this.searchDepartmentToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.searchDepartmentToolStripMenuItem.Text = "Search Department";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectDepartmentDatabaseToolStripMenuItem,
            this.connectEmployeeDatabaseToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // connectDepartmentDatabaseToolStripMenuItem
            // 
            this.connectDepartmentDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDatabaseToolStripMenuItem,
            this.importDatabaseToolStripMenuItem});
            this.connectDepartmentDatabaseToolStripMenuItem.Name = "connectDepartmentDatabaseToolStripMenuItem";
            this.connectDepartmentDatabaseToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.connectDepartmentDatabaseToolStripMenuItem.Text = "Connect Department database";
            // 
            // newDatabaseToolStripMenuItem
            // 
            this.newDatabaseToolStripMenuItem.Name = "newDatabaseToolStripMenuItem";
            this.newDatabaseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newDatabaseToolStripMenuItem.Text = "New Database";
            this.newDatabaseToolStripMenuItem.Click += new System.EventHandler(this.newDepDatabaseToolStripMenuItem_Click);
            // 
            // importDatabaseToolStripMenuItem
            // 
            this.importDatabaseToolStripMenuItem.Name = "importDatabaseToolStripMenuItem";
            this.importDatabaseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.importDatabaseToolStripMenuItem.Text = "Import Database";
            this.importDatabaseToolStripMenuItem.Click += new System.EventHandler(this.importDepDatabaseToolStripMenuItem_Click);
            // 
            // connectEmployeeDatabaseToolStripMenuItem
            // 
            this.connectEmployeeDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDataseToolStripMenuItem,
            this.importDatabaseToolStripMenuItem1});
            this.connectEmployeeDatabaseToolStripMenuItem.Name = "connectEmployeeDatabaseToolStripMenuItem";
            this.connectEmployeeDatabaseToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.connectEmployeeDatabaseToolStripMenuItem.Text = "Connect Employee Database";
            // 
            // newDataseToolStripMenuItem
            // 
            this.newDataseToolStripMenuItem.Name = "newDataseToolStripMenuItem";
            this.newDataseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newDataseToolStripMenuItem.Text = "New Database";
            this.newDataseToolStripMenuItem.Click += new System.EventHandler(this.newEmpDataseToolStripMenuItem_Click);
            // 
            // importDatabaseToolStripMenuItem1
            // 
            this.importDatabaseToolStripMenuItem1.Name = "importDatabaseToolStripMenuItem1";
            this.importDatabaseToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.importDatabaseToolStripMenuItem1.Text = "Import Database";
            this.importDatabaseToolStripMenuItem1.Click += new System.EventHandler(this.importEmpDatabaseToolStripMenuItem1_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(190, 23);
            this.searchToolStripMenuItem.Tag = "";
            this.searchToolStripMenuItem.ToolTipText = "\r\n";
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
            this.findEmployeeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.findEmployeeToolStripMenuItem.Text = "Find employee";
            // 
            // findDepartmentToolStripMenuItem
            // 
            this.findDepartmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findDepartmentEmployeesToolStripMenuItem,
            this.findDepartmentSalaryToolStripMenuItem});
            this.findDepartmentToolStripMenuItem.Name = "findDepartmentToolStripMenuItem";
            this.findDepartmentToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.findDepartmentToolStripMenuItem.Text = "Find Department";
            // 
            // findDepartmentEmployeesToolStripMenuItem
            // 
            this.findDepartmentEmployeesToolStripMenuItem.Name = "findDepartmentEmployeesToolStripMenuItem";
            this.findDepartmentEmployeesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.findDepartmentEmployeesToolStripMenuItem.Text = "Find Department Employees";
            // 
            // findDepartmentSalaryToolStripMenuItem
            // 
            this.findDepartmentSalaryToolStripMenuItem.Name = "findDepartmentSalaryToolStripMenuItem";
            this.findDepartmentSalaryToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.findDepartmentSalaryToolStripMenuItem.Text = "Find All Departments Salary";
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
            this.findMoreToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.findMoreToolStripMenuItem.Text = "About us";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.contactUsToolStripMenuItem.Text = "Contact us";
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
            // HomeOpenFileDialoge
            // 
            this.HomeOpenFileDialoge.FileName = "departments.csv";
            // 
            // LoadEmployeeDBButton
            // 
            this.LoadEmployeeDBButton.BackColor = System.Drawing.Color.White;
            this.LoadEmployeeDBButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LoadEmployeeDBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadEmployeeDBButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadEmployeeDBButton.Location = new System.Drawing.Point(209, 576);
            this.LoadEmployeeDBButton.Name = "LoadEmployeeDBButton";
            this.LoadEmployeeDBButton.Size = new System.Drawing.Size(149, 35);
            this.LoadEmployeeDBButton.TabIndex = 9;
            this.LoadEmployeeDBButton.Text = "Load Employee DB";
            this.LoadEmployeeDBButton.UseVisualStyleBackColor = false;
            this.LoadEmployeeDBButton.Click += new System.EventHandler(this.importEmpDatabaseToolStripMenuItem1_Click);
            // 
            // CreateEmployeeDbButton
            // 
            this.CreateEmployeeDbButton.BackColor = System.Drawing.Color.White;
            this.CreateEmployeeDbButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CreateEmployeeDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateEmployeeDbButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEmployeeDbButton.Location = new System.Drawing.Point(209, 617);
            this.CreateEmployeeDbButton.Name = "CreateEmployeeDbButton";
            this.CreateEmployeeDbButton.Size = new System.Drawing.Size(149, 35);
            this.CreateEmployeeDbButton.TabIndex = 10;
            this.CreateEmployeeDbButton.Text = "Create Employee DB";
            this.CreateEmployeeDbButton.UseVisualStyleBackColor = false;
            this.CreateEmployeeDbButton.Click += new System.EventHandler(this.newEmpDataseToolStripMenuItem_Click);
            // 
            // CreateDepartmentDbButton
            // 
            this.CreateDepartmentDbButton.BackColor = System.Drawing.Color.White;
            this.CreateDepartmentDbButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CreateDepartmentDbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateDepartmentDbButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateDepartmentDbButton.Location = new System.Drawing.Point(777, 617);
            this.CreateDepartmentDbButton.Name = "CreateDepartmentDbButton";
            this.CreateDepartmentDbButton.Size = new System.Drawing.Size(149, 35);
            this.CreateDepartmentDbButton.TabIndex = 12;
            this.CreateDepartmentDbButton.Text = "Create Department DB";
            this.CreateDepartmentDbButton.UseVisualStyleBackColor = false;
            this.CreateDepartmentDbButton.Click += new System.EventHandler(this.newDepDatabaseToolStripMenuItem_Click);
            // 
            // LoadDepartmentDBButton
            // 
            this.LoadDepartmentDBButton.BackColor = System.Drawing.Color.White;
            this.LoadDepartmentDBButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LoadDepartmentDBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadDepartmentDBButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDepartmentDBButton.Location = new System.Drawing.Point(777, 576);
            this.LoadDepartmentDBButton.Name = "LoadDepartmentDBButton";
            this.LoadDepartmentDBButton.Size = new System.Drawing.Size(149, 35);
            this.LoadDepartmentDBButton.TabIndex = 11;
            this.LoadDepartmentDBButton.Text = "Load Department DB";
            this.LoadDepartmentDBButton.UseVisualStyleBackColor = false;
            this.LoadDepartmentDBButton.Click += new System.EventHandler(this.importDepDatabaseToolStripMenuItem_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 670);
            this.Controls.Add(this.CreateDepartmentDbButton);
            this.Controls.Add(this.LoadDepartmentDBButton);
            this.Controls.Add(this.CreateEmployeeDbButton);
            this.Controls.Add(this.LoadEmployeeDBButton);
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
        private System.Windows.Forms.ToolStripMenuItem searchEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectDepartmentDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectEmployeeDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDataseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDatabaseToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog HomeOpenFileDialoge;
        private System.Windows.Forms.FolderBrowserDialog HomeFolderBrowser;
        private System.Windows.Forms.Button LoadEmployeeDBButton;
        private System.Windows.Forms.Button CreateEmployeeDbButton;
        private System.Windows.Forms.Button CreateDepartmentDbButton;
        private System.Windows.Forms.Button LoadDepartmentDBButton;
    }
}

