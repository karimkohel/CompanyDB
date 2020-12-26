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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void AddNewDepartmentSubmitButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private bool ValidForm()
        {
            bool valid = true;

            if(DepartmentAddressTextBox.Text.Length == 0 || DepartmentNameTextBox.Text.Length == 0 || DepartmentNumberTextBox.Text.Length == 0)
            {
                valid = false;
                //implement feedback
            }


            int departmentNumber;
            bool departmentNumberValid = int.TryParse(DepartmentNumberTextBox.Text, out departmentNumber);
            if (!departmentNumberValid)
            {
                valid = false;
            }
            else if(departmentNumber < 1)
            {
                valid = false;
            }
            


            return valid;
        }
    }
}
