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
    public partial class SearchEmployee : Form
    {
        public string SearchTerm { set; get; }
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {
/*            if( Contains only digits )
            {
                // load by ssn
            }
            else if ( Contains only chars){

            }
            else
            {
                what the hell?
            }*/ 
            // CONTINUE HERE

            EmployeeListBox.DataSource = "";
        }
    }
}
