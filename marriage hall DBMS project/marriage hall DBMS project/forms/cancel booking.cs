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
    public partial class cancel_booking : Form
    {
        functions MH = new functions();
        DataSet table = new DataSet();
        BindingSource bind = new BindingSource();
        public cancel_booking()
        {
            InitializeComponent();
            //dataGridView1.AutoGenerateColumns = true;
            //bind.DataSource = table;
            //dataGridView1.DataSource = bind;
        }

        private void searchid_Click(object sender, EventArgs e)
        {
            table = MH.getBookingById(textBox1.Text.ToString());
            if (table.Tables[0].Rows.Count > 0)
            {
                bid.Text = table.Tables[0].Rows[0]["Booking_ID"].ToString();
                bname.Text = table.Tables[0].Rows[0]["name"].ToString();
                bdate.Text = table.Tables[0].Rows[0]["event_date"].ToString();
                bamount.Text = table.Tables[0].Rows[0]["amount"].ToString();
            }
            else
                MessageBox.Show("Cannot fine the particular booking");
            //dataGridView1.DataSource = table.Tables["event"].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MH.cancelBooking(textBox1.Text.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
