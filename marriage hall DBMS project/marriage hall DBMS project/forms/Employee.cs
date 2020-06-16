using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marriage_hall_DBMS_project.forms
{
    public partial class Employee : Form
    {
        Sql_server con = new Sql_server();
        SqlConnection conn;
        public Employee()
        {
            InitializeComponent();
            conn = con.Connect();
        }

        private void labe_Registration(object sender, EventArgs e)
        {

        }

        private void TextBox_Full_Name(object sender, EventArgs e)
        {

        }

        private void TextBox_Address(object sender, EventArgs e)
        {

        }

        private void TextBox_User_Name(object sender, EventArgs e)
        {

        }

        private void TextBox_Password(object sender, EventArgs e)
        {

        }

        private void TextBox_CNIC(object sender, EventArgs e)
        {

        }

        private void TextBox_Location(object sender, EventArgs e)
        {

        }

        private void TextBox_Email(object sender, EventArgs e)
        {

        }

        private void DATE(object sender, EventArgs e)
        {

        }

        private void button_Register(object sender, EventArgs e)
        {
            string query = "insert into employee (id,name,phone,password,type,address)" + " values (@id, @name, @phone, @password, @type, @address)";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                    cmd.Parameters.Add("@id", SqlDbType.VarChar, 50).Value = usrnamtxtbx.Text;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = fulnamtxtbx.Text;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = contctxtbx.Text;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = psstxtbx.Text;
                    cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = "staff";
                    cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = adrestxtbx.Text;
                    cmd.ExecuteNonQuery();
                    this.Close();
                    MessageBox.Show("Successfully Added");
                
            }
            catch
            {
                MessageBox.Show("please check if all the entries have correct format");
            }
        }

        private void button_Reset(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void label_Full_name(object sender, EventArgs e)
        {

        }

        private void label_User_name(object sender, EventArgs e)
        {

        }

        private void label_Pasword(object sender, EventArgs e)
        {

        }

        private void label_Contact(object sender, EventArgs e)
        {

        }

        private void label_Location(object sender, EventArgs e)
        {

        }

        private void label_CNIC(object sender, EventArgs e)
        {

        }

        private void label_Address(object sender, EventArgs e)
        {

        }

        private void TextBox_Contact_number(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
        
    }
}
