
namespace CompanyUI
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.AddEmployeeTitleLabel = new System.Windows.Forms.Label();
            this.AddEmployeeLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.MinitLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.SexRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SexRadioButton2 = new System.Windows.Forms.RadioButton();
            this.AddEmployeeLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddEmployeeTitleLabel
            // 
            this.AddEmployeeTitleLabel.AutoSize = true;
            this.AddEmployeeTitleLabel.Location = new System.Drawing.Point(363, 9);
            this.AddEmployeeTitleLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.AddEmployeeTitleLabel.Name = "AddEmployeeTitleLabel";
            this.AddEmployeeTitleLabel.Size = new System.Drawing.Size(206, 40);
            this.AddEmployeeTitleLabel.TabIndex = 0;
            this.AddEmployeeTitleLabel.Text = "Add Employee";
            // 
            // AddEmployeeLayoutPanel
            // 
            this.AddEmployeeLayoutPanel.ColumnCount = 4;
            this.AddEmployeeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AddEmployeeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AddEmployeeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AddEmployeeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AddEmployeeLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.AddEmployeeLayoutPanel.Controls.Add(this.FirstNameLabel, 0, 0);
            this.AddEmployeeLayoutPanel.Controls.Add(this.LastNameLabel, 0, 1);
            this.AddEmployeeLayoutPanel.Controls.Add(this.SexLabel, 0, 2);
            this.AddEmployeeLayoutPanel.Controls.Add(this.BirthdayLabel, 0, 3);
            this.AddEmployeeLayoutPanel.Controls.Add(this.AddressLabel, 0, 4);
            this.AddEmployeeLayoutPanel.Controls.Add(this.SSNLabel, 2, 0);
            this.AddEmployeeLayoutPanel.Controls.Add(this.DepartmentLabel, 2, 1);
            this.AddEmployeeLayoutPanel.Controls.Add(this.SalaryLabel, 2, 2);
            this.AddEmployeeLayoutPanel.Controls.Add(this.MinitLabel, 2, 3);
            this.AddEmployeeLayoutPanel.Controls.Add(this.FirstNameTextBox, 1, 0);
            this.AddEmployeeLayoutPanel.Controls.Add(this.LastNameTextBox, 1, 1);
            this.AddEmployeeLayoutPanel.Controls.Add(this.AddressTextBox, 1, 4);
            this.AddEmployeeLayoutPanel.Controls.Add(this.SSNTextBox, 3, 0);
            this.AddEmployeeLayoutPanel.Controls.Add(this.SalaryTextBox, 3, 2);
            this.AddEmployeeLayoutPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeLayoutPanel.Location = new System.Drawing.Point(29, 108);
            this.AddEmployeeLayoutPanel.Name = "AddEmployeeLayoutPanel";
            this.AddEmployeeLayoutPanel.RowCount = 5;
            this.AddEmployeeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AddEmployeeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AddEmployeeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AddEmployeeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AddEmployeeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AddEmployeeLayoutPanel.Size = new System.Drawing.Size(878, 434);
            this.AddEmployeeLayoutPanel.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(3, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(213, 86);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name : ";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(3, 86);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(213, 86);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name : ";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SexLabel
            // 
            this.SexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexLabel.Location = new System.Drawing.Point(3, 172);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(213, 86);
            this.SexLabel.TabIndex = 2;
            this.SexLabel.Text = "Sex : ";
            this.SexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayLabel.Location = new System.Drawing.Point(3, 258);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(213, 86);
            this.BirthdayLabel.TabIndex = 3;
            this.BirthdayLabel.Text = "Birthday : ";
            this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddressLabel
            // 
            this.AddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(3, 344);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(213, 90);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address : ";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SSNLabel
            // 
            this.SSNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSNLabel.Location = new System.Drawing.Point(441, 0);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(213, 86);
            this.SSNLabel.TabIndex = 5;
            this.SSNLabel.Text = "SSN :";
            this.SSNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLabel.Location = new System.Drawing.Point(441, 86);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(213, 86);
            this.DepartmentLabel.TabIndex = 6;
            this.DepartmentLabel.Text = "Department :";
            this.DepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryLabel.Location = new System.Drawing.Point(441, 172);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(213, 86);
            this.SalaryLabel.TabIndex = 7;
            this.SalaryLabel.Text = "Salary :";
            this.SalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinitLabel
            // 
            this.MinitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinitLabel.AutoSize = true;
            this.MinitLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinitLabel.Location = new System.Drawing.Point(441, 258);
            this.MinitLabel.Name = "MinitLabel";
            this.MinitLabel.Size = new System.Drawing.Size(213, 86);
            this.MinitLabel.TabIndex = 8;
            this.MinitLabel.Text = "Minit :";
            this.MinitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameTextBox.Location = new System.Drawing.Point(241, 25);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(174, 36);
            this.FirstNameTextBox.TabIndex = 9;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameTextBox.Location = new System.Drawing.Point(241, 111);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(174, 36);
            this.LastNameTextBox.TabIndex = 10;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressTextBox.Location = new System.Drawing.Point(241, 371);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(174, 36);
            this.AddressTextBox.TabIndex = 11;
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SSNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SSNTextBox.Location = new System.Drawing.Point(680, 25);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(174, 36);
            this.SSNTextBox.TabIndex = 12;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaryTextBox.Location = new System.Drawing.Point(680, 197);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(174, 36);
            this.SalaryTextBox.TabIndex = 13;
            // 
            // SexRadioButton
            // 
            this.SexRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SexRadioButton.AutoSize = true;
            this.SexRadioButton.Location = new System.Drawing.Point(27, 23);
            this.SexRadioButton.Name = "SexRadioButton";
            this.SexRadioButton.Size = new System.Drawing.Size(51, 34);
            this.SexRadioButton.TabIndex = 14;
            this.SexRadioButton.TabStop = true;
            this.SexRadioButton.Text = "M";
            this.SexRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SexRadioButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SexRadioButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SexRadioButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(222, 175);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 80);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // SexRadioButton2
            // 
            this.SexRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SexRadioButton2.AutoSize = true;
            this.SexRadioButton2.Location = new System.Drawing.Point(138, 23);
            this.SexRadioButton2.Name = "SexRadioButton2";
            this.SexRadioButton2.Size = new System.Drawing.Size(42, 34);
            this.SexRadioButton2.TabIndex = 15;
            this.SexRadioButton2.TabStop = true;
            this.SexRadioButton2.Text = "F";
            this.SexRadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SexRadioButton2.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 573);
            this.Controls.Add(this.AddEmployeeLayoutPanel);
            this.Controls.Add(this.AddEmployeeTitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "EmployeeForm";
            this.Text = "Add Employee";
            this.AddEmployeeLayoutPanel.ResumeLayout(false);
            this.AddEmployeeLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddEmployeeTitleLabel;
        private System.Windows.Forms.TableLayoutPanel AddEmployeeLayoutPanel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label MinitLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox SSNTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton SexRadioButton2;
        private System.Windows.Forms.RadioButton SexRadioButton;
    }
}