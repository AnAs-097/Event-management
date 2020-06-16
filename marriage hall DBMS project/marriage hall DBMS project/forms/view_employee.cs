using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marriage_hall_DBMS_project.forms
{
    public partial class view_employee : Form
    {
        functions MH = new functions();
        public view_employee()
        {
            InitializeComponent();
            dataGridView1.DataSource = MH.getAllEmployeesNoFilter();
        }

        private void Remove_emp_Click(object sender, EventArgs e)
        {
            remove_emp rm = new remove_emp();
            rm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
