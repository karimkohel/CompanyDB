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
    public partial class DepartmentsStats : Form
    {
        public DepartmentsStats()
        {
            InitializeComponent();
        }

        private void DepartmentsStats_Load(object sender, EventArgs e)
        {
            // load employees into departments list freom static method in globalConnector
            GlobalConnector.LoadEmployeesInDepartments();

            // get departments copy in local list
            List<Department> deps = new List<Department>(GlobalConnector.Departments);


            // get count of departments and other stat and put in ui
            loadStatsWith(deps);
            
            // get summation of salary for each elemenet (department)
            // CONTINUE HERE
        }


        #region Helpers
        private void loadStatsWith(List<Department> deps)
        {
            // get departments count and place in ui
            TotalDepVarLabel.Text = deps.Count.ToString();

            // get departments summation of salaries and place in ui
            double allSalaries = 0;
            foreach(Department dep in deps)
            {
                foreach(Employee emp in dep.Employees)
                {
                    allSalaries += emp.Salary;
                }
            }

            TotalSalariesVarLabel.Text = allSalaries.ToString();
        }
        #endregion
    }
}
