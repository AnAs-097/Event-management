using marriage_hall_DBMS_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbms_new_project
{
    public partial class viewBookings : Form
    {
        functions MH = new functions();
        public viewBookings()
        {
            InitializeComponent();
            dataGridView1.DataSource = MH.getAllBookingsNoFilter();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
