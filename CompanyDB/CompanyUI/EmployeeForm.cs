using CompanyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyUI
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        private void addEmployeeSubmitButton_Click(object sender, EventArgs e)
        {
            if (!ValidForm())
            {
                string msg = "- Employee first and last names should only contain Characters." + "\n" + "- Employee SSN should be 9 digits only";
                msg = msg + "\n" + "- Employee Salary should be digits only" + "\n" + "- Emlpoyee Birthday should not be in the future or ower than 18 year from now";
                msg = msg + "\n" + "- No value should be left empty.";
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(GlobalConnector.EmployeeFilePath == null || GlobalConnector.DepartmentFilePath == null)
            {
                string msg = "Must Initialize Both Databases before creating any entries:\n- Home page > Edit > Connect Employee Database & Connect Department Database";
                MessageBox.Show(msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Employee emp = new Employee(); // continue HERE
            }
        }

        /// <summary>
        /// Private helper method that checks validity of Add Employee Form
        /// </summary>
        /// <returns>bool value of true for valid form or false for invalid one</returns>
        private bool ValidForm()
        {
            if(FirstNameTextBox.Text.Length == 0 || LastNameTextBox.Text.Length == 0
                || AddressTextBox.Text.Length == 0 || SSNTextBox.Text.Length == 0
                || DepartmentComboBox.Text.Length == 0 || SalaryTextBox.Text.Length == 0
                || MinitComboBox.Text.Length == 0) // add date too
            {
                return false;
            }

            if (FirstNameTextBox.Text.Any(char.IsDigit))
            {
                return false;
            }

            if (LastNameTextBox.Text.Any(char.IsDigit))
            {
                return false;
            }

            if(SSNTextBox.Text.Any(char.IsLetter) || SSNTextBox.Text.Length != 9)
            {
                return false;
            }

            if (SalaryTextBox.Text.Any(char.IsLetter))
            {
                return false;
            }

            //check for future dates or dates closer than 18 year

            return true;
        }

    }
}
