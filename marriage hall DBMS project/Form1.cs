using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using marriage_hall_DBMS_project.forms;

namespace marriage_hall_DBMS_project
{
    public partial class Form1 : Form
    {
        string s_user_name, s_password;
        functions mg =new functions();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel_Login(object sender, PaintEventArgs e)
        {

        }

        private void button_login(object sender, EventArgs e)
        {
            s_user_name = textBox1.Text;
            s_password = textBox2.Text;
            string type;
            type = mg.LoginUser(s_user_name, s_password);
            if (type == "admin")
            {
                main adminmain = new main();
                adminmain.ShowDialog();
            }
            else if (type == "staff")
            {
                mainEmp empmain = new mainEmp();
                empmain.ShowDialog();
            }

        }


        private void textBox_Username(object sender, EventArgs e)
        {
          
        }

        private void textBox_Password(object sender, EventArgs e)
        {

        }

        private void User_Name_label(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Password_label(object sender, EventArgs e)
        {

        }
    }
}
