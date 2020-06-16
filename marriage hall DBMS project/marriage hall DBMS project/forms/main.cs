using Dbms_new_project;
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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button_logout(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button_Add_Employee(object sender, EventArgs e)
        {
            this.Hide();
            Employee emp = new Employee();
            emp.ShowDialog();
        }

        private void button_Menue(object sender, EventArgs e)
        {

        }

        private void button_View_Employe(object sender, EventArgs e)
        {
            view_employee ve = new view_employee();
            ve.ShowDialog();
        }

        private void button_Profile(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button_View_Booking(object sender, EventArgs e)
        {
            viewBookings view = new viewBookings();
            view.ShowDialog();
        }

        private void button_cancel_event(object sender, EventArgs e)
        {
            cancel_booking cb = new cancel_booking();
            cb.ShowDialog();
        }

        private void button_Add_Event(object sender, EventArgs e)
        {
            AddBookings add = new AddBookings();
            add.ShowDialog();
        }
    }
}
