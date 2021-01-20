using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marriage_hall_DBMS_project.forms
{
    class SqlServer
    {
        private SqlConnection cnn;
        public void Connect()
        {
            string connetionString = "Data Source=localhost;Initial Catalog=MarrageHall;Integrated Security=True;";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                Console.WriteLine("Coneecttion opeen");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
