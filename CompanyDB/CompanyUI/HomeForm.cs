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
        private void importDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentOpenFileDialoge.ShowDialog();
            GlobalConnector.DepartmentFilePath = DepartmentOpenFileDialoge.FileName;

            // show department data in home page

            LoadDepartmentDBButton.Hide();
            CreateDepartmentDbButton.Hide();
        }

        private void newDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentFolderBrowser.ShowDialog();
            GlobalConnector.DepartmentFilePath = DepartmentFolderBrowser.SelectedPath+"\\DepartmentsDB.csv";

            // show success msg to user
            MessageBox.Show("Done", "Successfully added new Department Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadDepartmentDBButton.Hide();
            CreateDepartmentDbButton.Hide();
        }
        #endregion

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
    }
}
