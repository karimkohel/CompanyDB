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
                string msg = "Must Initialize Both Databases before creating any entries:\n- Home page > Edit > Connect Employee Database & Connect Department Database";
                MessageBox.Show(msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }

            afterEmpDBLoad();
        }
        private void newEmpDataseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeFolderBrowser.ShowDialog();
            GlobalConnector.EmployeeFilePath = HomeFolderBrowser.SelectedPath+"\\EmployeeDB.csv";

            afterEmpDBLoad();
        }
        #endregion

        #region Find Strip menu items
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
                string[] departmentsNames = GlobalConnector.Departments.Select(d => d.Name).ToArray();
                DepartmentListBox.DataSource = departmentsNames;
            }

            // show succes to user
            MessageBox.Show("Successfully added Department Database", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // hide db option after loading db
            LoadDepartmentDBButton.Hide();
            CreateDepartmentDbButton.Hide();
        }

        private void afterEmpDBLoad()
        {
            // show data in list boxes
            if(GlobalConnector.Employees != null)
            {
                string[] empNames = GlobalConnector.Employees.Select(e => e.LastName).ToArray();
                EmployeeListBox.DataSource = empNames;
            }

            // show success msg to user
            MessageBox.Show("Successfully added Employee Database", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //hide db options
            LoadEmployeeDBButton.Hide();
            CreateEmployeeDbButton.Hide();
        }

        private void dbErrorMsg()
        {
            string msg = "Must Initialize Both Databases before creating any entries:\n- Home page > Edit > Connect Employee Database & Connect Department Database";
            MessageBox.Show(msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

    }
}
