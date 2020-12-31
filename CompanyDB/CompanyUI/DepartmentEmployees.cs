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
    public partial class DepartmentEmployees : Form
    {
        public DepartmentEmployees()
        {
            InitializeComponent();
        }

        private void DepartmentEmployees_Load(object sender, EventArgs e)
        {
            // clear list
            EmployeeListBox.DataSource = new List<string>();

            // load departments by name in combo box
            DepartmentComboBox.DataSource = GlobalConnector.Departments.Select(x => x.Name).ToArray();

            // load emps in deps
            GlobalConnector.LoadEmployeesInDepartments();
        }
        private void DepartmentComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // clear any past data from list
            EmployeeListBox.DataSource = new List<string>();

            // get dep from combo box by name from global list
            Department dep = GlobalConnector.Departments.Find(d => d.Name == DepartmentComboBox.Text);

            // get list of employees in said department &  place fullnames in listbox
            EmployeeListBox.DataSource = dep.Employees.Select(emp => emp.getFullName()).ToArray();
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
