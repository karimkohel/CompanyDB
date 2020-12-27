using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyLib;

namespace CompanyUI
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void AddNewDepartmentSubmitButton_Click(object sender, EventArgs e)
        {
            if(ValidForm())
            {
                // create department object with valid form data
                Department department = new Department(int.Parse(DepartmentNumberTextBox.Text), DepartmentNameTextBox.Text, DepartmentAddressComboBox.Text);

                // load department database or create new one and load them in list
                List<Department> departments = Connector.LoadDepartments(Connector.DepartmentFilePath);

                // ID and serialize all departments with new one amongst them
                Connector.SerializeDepartment(department, departments, Connector.DepartmentFilePath);

                DepartmentNameTextBox.Text = "";
                DepartmentNumberTextBox.Text = "";
                MessageBox.Show("Department Saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string msg = "-Department Name should only contain Characters." + "\n" + "-Department number should only contain digits." + "\n" + "-No value should be left empty.";
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// The method responsible for validating user input to the new Department Form
        /// </summary>
        /// <returns>Bool with true for valid and false for invalid form data</returns>
        private bool ValidForm()
        {

            if(DepartmentNameTextBox.Text.Length == 0 || DepartmentNumberTextBox.Text.Length == 0 || DepartmentAddressComboBox.Text.Length == 0)
            {
                return false;
            }

            #region Department Number Validation
            int departmentNumber;
            bool departmentNumberValid = int.TryParse(DepartmentNumberTextBox.Text, out departmentNumber);
            if(!departmentNumberValid)
            {
                return false;
            }
            else if(departmentNumber < 1)
            {
                return false;
            }
            #endregion

            #region Department Name Validation
            bool departmentNameValid = !(DepartmentNameTextBox.Text.Any(char.IsDigit));
            if(!departmentNameValid){
                return false;
            }
            #endregion

            return true;
        }

    }
}
