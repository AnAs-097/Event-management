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
    public partial class AddBookings : Form
    {
        functions MH= new functions();
        DataTable DT = new DataTable();
        DataTable mtable = new DataTable();
        List<string> list = new List<string>();
        float totalamount=0;
        public AddBookings()
        {
            InitializeComponent();
            mtable = MH.GetAllMenuNo();
            foreach(DataRow r in mtable.Rows)
            {
                comboBox1.Items.Add(r["name"].ToString() + " " + r["price"].ToString());
            }
        }

        private void guestnamtxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void typeofeventtxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void noofpersontxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cntctnotxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void venuetxtbx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            DT = MH.FreeHalls(date);
            venueList.DataSource = DT;
            venueList.DisplayMember = ("HALL_NO");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, type, noOfGuests, contact, venue;
            DateTime stime, etime, date;
            int id;
            float price;
            if(MH.validator(guestnamtxtbx) && MH.validator(typeofeventtxtbx) && MH.validator(noofpersontxtbx) && MH.validator(cntctnotxtbx) && MH.validator(venueList))
            {
                name = guestnamtxtbx.Text;
                type = typeofeventtxtbx.Text;
                noOfGuests = noofpersontxtbx.Text;
                stime = dateTimePicker2.Value;
                etime = dateTimePicker3.Value;
                date = dateTimePicker1.Value;
                venue = this.venueList.GetItemText(this.venueList.SelectedItem);
                contact = cntctnotxtbx.Text;
                price = float.Parse(price_lable.Text.ToString());
                id = MH.InsertNewBooking(name, type, venue, noOfGuests, stime, etime, date, contact,price);
                MessageBox.Show("Your Event has been sceduled! \n Booking ID: " + id.ToString());
                textBox4.Text = id.ToString();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item;
            
            int noGuest = MH.getNoOfGuests(int.Parse(textBox4.Text.ToString()));
            item = comboBox1.GetItemText(this.comboBox1.SelectedItem);
            item = item.Substring(0, item.IndexOf(" "));
            listBox1.Items.Add(item);
            
            DataRow[] r = mtable.Select("name="+"'"+item+"'");
            totalamount = totalamount + float.Parse(r[0]["price"].ToString())*noGuest;
            list.Add(item);
            textBox2.Text = totalamount.ToString();
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach(string name in list)
            {
                MH.InsertSelectedMenus(name, int.Parse(textBox4.Text.ToString()),float.Parse(textBox2.Text.ToString()));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void venueList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indx = venueList.SelectedIndex;
            string charges="0", capacity="0";
            foreach(DataRow DR in DT.Rows)
            {
                if (indx == DT.Rows.IndexOf(DR))
                {
                    charges=DR["CHARGES"].ToString();
                    capacity=DR["CAPACITY"].ToString();
                }
            }
            Capacity_lable.Text = capacity;
            price_lable.Text = charges;

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cntctnotxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void noofpersontxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guestnamtxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
