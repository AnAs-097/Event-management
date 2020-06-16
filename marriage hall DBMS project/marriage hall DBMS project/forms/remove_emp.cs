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
    public partial class remove_emp : Form
    {
        functions MH = new functions();
        DataSet table = new DataSet();
        public remove_emp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchid_Click(object sender, EventArgs e)
        {
            table = MH.getEmployeeById(textBox1.Text.ToString());
            if (table.Tables[0].Rows.Count > 0)
            {
                bid.Text = table.Tables[0].Rows[0]["id"].ToString();
                bname.Text = table.Tables[0].Rows[0]["name"].ToString();
                bdate.Text = table.Tables[0].Rows[0]["phone"].ToString();
                bamount.Text = table.Tables[0].Rows[0]["status"].ToString();
            }
            else
                MessageBox.Show("Cannot fine the particular Employee");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MH.removeEmployee(textBox1.Text.ToString());
        }
    }
}
