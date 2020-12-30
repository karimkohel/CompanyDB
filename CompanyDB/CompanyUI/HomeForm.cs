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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        #region Search
        /// <summary>
        /// opens a new search form with given text as argument of search
        /// after checking if database is initialized
        /// </summary>
        private void searchToolStripMenuItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if (!checkDBLoaded() || GlobalConnector.Employees == null)
                {
                    string msg = "Must Initialize Both Databases and create Employees before searching them";
                    MessageBox.Show(msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(searchToolStripMenuItem.Text.Any(char.IsDigit) && searchToolStripMenuItem.Text.Any(char.IsLetter))
                {
                    string msg = "Search by either Employee SSN, Employee Name or Employee Address";
                    MessageBox.Show(msg, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SearchEmployee searchEmp = new SearchEmployee();
                    searchEmp.SearchTerm = searchToolStripMenuItem.Text;
                    searchEmp.Show();
                }
            }
        }
        #endregion

        #region File Strip menu
        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkDBLoaded())
            {
                dbErrorMsg();
            }
            else if(GlobalConnector.Departments == null)
            {
                string msg = "Must create Departments first then create Employees";
                MessageBox.Show(msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Form addEmployee = new EmployeeForm();
                addEmployee.Show();
            }
        }

        private void newDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkDBLoaded())
            {
                Form addDepartment = new DepartmentForm();
                addDepartment.Show();
            }
            else
            {
                dbErrorMsg();
            }
        }

        private void refreshDatabasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkDBLoaded())
            {
                loadDepList();
                loadEmpList();
            }
            else
            {
                dbErrorMsg();
            }
        }

        #endregion

        #region Edit strip menu items
        private void importDepDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeOpenFileDialoge.ShowDialog();

            if(HomeOpenFileDialoge.FileName.Length != 0) 
            {
                GlobalConnector.DepartmentFilePath = HomeOpenFileDialoge.FileName;
                GlobalConnector.LoadDepartments(GlobalConnector.DepartmentFilePath);

                afterDepDBLoad();
            }

        }
        private void newDepDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeFolderBrowser.ShowDialog();
            GlobalConnector.DepartmentFilePath = HomeFolderBrowser.SelectedPath+"\\DepartmentsDB.csv";

            afterDepDBLoad();
        }

        private void importEmpDatabaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomeOpenFileDialoge.ShowDialog();
            if (HomeOpenFileDialoge.FileName.Length != 0)
            {
                GlobalConnector.EmployeeFilePath = HomeOpenFileDialoge.FileName;
                GlobalConnector.LoadEmployees(GlobalConnector.EmployeeFilePath);
                
                afterEmpDBLoad();
            }

        }
        private void newEmpDataseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeFolderBrowser.ShowDialog();
            GlobalConnector.EmployeeFilePath = HomeFolderBrowser.SelectedPath+"\\EmployeeDB.csv";

            afterEmpDBLoad();
        }
        #endregion

        #region Find Strip menu items

        /// <summary>
        /// Launches all departments stats and salaries form while db is loaded only
        /// </summary>
        private void findDepartmentSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkDBLoaded())
            {
                dbErrorMsg();
            }
            else if(GlobalConnector.Employees == null || GlobalConnector.Departments == null)
            {
                string msg = "Must Create Employees and Departments first";
                MessageBox.Show(msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form departmentSalaries = new DepartmentsStats();
                departmentSalaries.Show();
            }
        }

        private void findEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkDBLoaded() || GlobalConnector.Employees == null || GlobalConnector.Departments == null)
            {
                dbErrorMsg();
            }
            else
            {
                Form singleEmpForm = new SingleEmployeeForm();
                singleEmpForm.Show();
            }
        }
        private void findDepartmentEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkDBLoaded())
            {
                dbErrorMsg();
            }
            else if(GlobalConnector.Departments == null || GlobalConnector.Employees == null)
            {
                string msg = "Must Create Departments and Employees first";
                MessageBox.Show(msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form depEmps = new DepartmentEmployees();
                depEmps.Show();
            }
        }

        #endregion

        #region Refresh Buttons
        private void EmpReloadButton_Click(object sender, EventArgs e)
        {
            loadEmpList();
        }
        private void depReloadButton_Click(object sender, EventArgs e)
        {
            loadDepList();
        }
        #endregion

        #region Helpers
        private bool checkDBLoaded()
        {
            if(GlobalConnector.DepartmentFilePath == null)
            {
                return false;
            }
            if(GlobalConnector.EmployeeFilePath == null)
            {
                return false;
            }
            return true;
        }

        private void afterDepDBLoad()
        {
            // show data in list boxes
            if(GlobalConnector.Departments != null)
            {
                loadDepList();
            }

            // show succes to user
            MessageBox.Show("Successfully added Department Database", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // hide db option after loading db
            LoadDepartmentDBButton.Hide();
            CreateDepartmentDbButton.Hide();
            depReloadButton.Visible = true;
        }

        private void afterEmpDBLoad()
        {
            // show data in list boxes
            if(GlobalConnector.Employees != null)
            {
                loadEmpList();
            }

            // show success msg to user
            MessageBox.Show("Successfully added Employee Database", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //hide db options
            LoadEmployeeDBButton.Hide();
            CreateEmployeeDbButton.Hide();
            EmpReloadButton.Visible = true;
        }

        private void dbErrorMsg()
        {
            string msg = "Must Initialize Both Databases before creating any entries:\n- Home page > Edit > Connect Employee Database & Connect Department Database";
            MessageBox.Show(msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void loadDepList()
        {
            string[] departmentsNames = GlobalConnector.Departments.Select(d => d.Name).ToArray();
            DepartmentListBox.DataSource = departmentsNames;
        }
        private void loadEmpList()
        {
            string[] empNames = GlobalConnector.Employees.Select(e => e.LastName).ToArray();
            EmployeeListBox.DataSource = empNames;
        }
        #endregion

    }
}
