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
            // throw new NotImplementedException();
            bool FormIsvalid = ValidateForm();

            if(FormIsvalid){
                int number = int.Parse(DepartmentNumberTextBox.Text);
                Department department = new Department(number, DepartmentNameTextBox.Text, DepartmentAddressTextBox.Text);
                // save department in memory 
            }

        }


        /// <summary>
        /// The method responsible for validating user input to the new Department Form
        /// </summary>
        /// <returns>Bool with true for valid and false for invalid form data</returns>
        private bool ValidateForm()
        {
            bool valid = true;

            if(DepartmentNameTextBox.Text.Length == 0 || DepartmentNumberTextBox.Text.Length == 0)
            {
                valid = false;
                //implement feedback
            }


            // region of department number
            int departmentNumber;
            bool departmentNumberValid = int.TryParse(DepartmentNumberTextBox.Text, out departmentNumber);
            if(!departmentNumberValid)
            {
                valid = false; // imp feedback
            }
            else if(departmentNumber < 1)
            {
                valid = false; // imp feedback
            }


            // region of department name
            bool departmentNameValid = !(DepartmentNameTextBox.Text.Any(char.IsDigit));
            if(!departmentNameValid){
                valid = false; // imp feedback
            }



            // region of department address            
            // should be a combo box (no use of validation)

            return valid;
        }

    }
}
