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

        #region Edit strip menu items
        private void importDepDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeOpenFileDialoge.ShowDialog();
            GlobalConnector.DepartmentFilePath = HomeOpenFileDialoge.FileName;

            //show success msg to user

            // show department data in home page

            LoadDepartmentDBButton.Hide();
            CreateDepartmentDbButton.Hide();
        }
        private void newDepDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeFolderBrowser.ShowDialog();
            GlobalConnector.DepartmentFilePath = HomeFolderBrowser.SelectedPath+"\\DepartmentsDB.csv";

            // show success msg to user
            MessageBox.Show("Done", "Successfully added new Department Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadDepartmentDBButton.Hide();
            CreateDepartmentDbButton.Hide();
        }

        private void newEmpDataseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeFolderBrowser.ShowDialog();
            GlobalConnector.EmployeeFilePath = HomeFolderBrowser.SelectedPath+"\\EmployeeDB.csv";

            //show success msg to user
            MessageBox.Show("Done", "Successfully added new Employee Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEmployeeDBButton.Hide();
            CreateEmployeeDbButton.Hide();
        }
        private void importEmpDatabaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomeOpenFileDialoge.ShowDialog();
            GlobalConnector.EmployeeFilePath = HomeOpenFileDialoge.FileName;

            //show success msg

            // show employee data in homepage

            LoadEmployeeDBButton.Hide();
            CreateEmployeeDbButton.Hide();
        }
        #endregion

        #region File Strip menu
        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check db first

            Form addEmployee = new EmployeeForm();
            addEmployee.Show();
        }

        private void newDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check db first

            Form addDepartment = new DepartmentForm();
            addDepartment.Show();
        }
        #endregion

    }
}
