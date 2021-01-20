using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marriage_hall_DBMS_project.forms
{
    class Sql_server
    {
        private SqlConnection cnn;
        public SqlConnection Connect()
        {
            string connetionString = "Data Source=localhost;Initial Catalog=MarrageHall;Integrated Security=True;";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                _ = MessageBox.Show("Connection Open ! ");
                Console.WriteLine("Coneecttion opeen");
                return cnn;
            }
            catch
            { 
                MessageBox.Show("Can not open connection ! ");
            }
            return null;
        }
    }
}
