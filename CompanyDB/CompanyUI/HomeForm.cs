﻿using CompanyLib;
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

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void importDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentOpenFileDialoge.ShowDialog();
            Connector.DepartmentFilePath = DepartmentOpenFileDialoge.FileName;
            // show department data in home page
        }

        private void newDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create new file
        }
    }
}
