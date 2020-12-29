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
    public partial class SingleEmployeeForm : Form
    {
        public SingleEmployeeForm()
        {
            InitializeComponent();
        }

        private void SingleEmployeeForm_Load(object sender, EventArgs e)
        {
            Employee emp = getEmployee(1);
            loadEmpToUi(emp);
        }

        #region Private helpers
        private bool ValidForm()
        {
            if (FirstNameTextBox.Text.Length == 0 || LastNameTextBox.Text.Length == 0
                || AddressTextBox.Text.Length == 0 || SSNTextBox.Text.Length == 0
                || DepartmentComboBox.Text.Length == 0 || SalaryTextBox.Text.Length == 0
                || MinitComboBox.Text.Length == 0)
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

            if (SSNTextBox.Text.Any(char.IsLetter) || SSNTextBox.Text.Length != 9)
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
        private void invalideError()
        {
            string msg = "- Employee first and last names should only contain Characters." + "\n" + "- Employee SSN should be 9 digits only";
            msg = msg + "\n" + "- Employee Salary should be digits only" + "\n" + "- Emlpoyee Birthday should not be in the future or ower than 18 year from now";
            msg = msg + "\n" + "- No value should be left empty.";
            MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private Employee getEmployee(int id)
        {
            return GlobalConnector.Employees.Find(e => e.Id == id);
        }
        private void loadEmpToUi(Employee emp)
        {
            FirstNameTextBox.Text = emp.FisrtName;
            LastNameTextBox.Text = emp.LastName;
            if(emp.Sex == 'M')
            {
                SexRadioButtonM.Checked = true;
            }
            else
            {
                SexRadioButtonF.Checked = true;
            }
            EmployeeBirthdaydateTimePicker.Value = emp.Birthday;
            AddressTextBox.Text = emp.Address;
            SSNTextBox.Text = emp.SSN.ToString();
            DepartmentComboBox.Text = emp.DepartmentNumber.ToString();
            SalaryTextBox.Text = emp.Salary.ToString();
            MinitComboBox.Text = emp.Minit.ToString();
        }
        #endregion

    }
}
