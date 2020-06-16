using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marriage_hall_DBMS_project
{


        class functions
        {
            public static SqlConnection SqlCon = new SqlConnection("Data Source = localhost; Initial Catalog = MarrageHall; Integrated Security = True;");
            public void OpenConnection()
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
                SqlCon.Open();
            }
            public void CloseConnection()
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        public bool validator(TextBox checkfield)
        {
            if(string.IsNullOrWhiteSpace(checkfield.Text))
            {
                checkfield.Focus();
                return false;
            }
            return true;
        }
        public bool validator(ComboBox checkfield)
        {
            if (string.IsNullOrWhiteSpace(checkfield.Text))
            {
                checkfield.Focus();
                return false;
            }
            return true;
        }
        public string LoginUser(string s_user_name, string s_password)
            {
                OpenConnection();
                var command = new SqlCommand("select type from Employee where id='" + s_user_name + "'" + " and password='" + s_password + "'", SqlCon);
                DataTable DT = new DataTable();
                SqlDataReader DR = command.ExecuteReader();
                DT.Load(DR);
                //DA.ToString();
                CloseConnection();
                if (DT.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid Credentials");
                    return null;
                
                }
       
                else if(DT.Rows.Count == 1)
                {
                    foreach (DataRow row in DT.Rows)
                    return row["type"].ToString();
                }
                return null;
                }
               
               public DataTable FreeHalls(DateTime date)
                {
                    OpenConnection();
                    DataTable DT = new DataTable();
                    var sqlcmd = new SqlCommand("SELECT H.HALL_NO,CHARGES,CAPACITY FROM HALLS H LEFT OUTER JOIN EVENT E ON H.hall_no=E.hall_no AND E.Event_date = @date where booking_id is NULL;",SqlCon);
                    sqlcmd.Parameters.Add("@date", SqlDbType.Date).Value = date.ToString("yyyy-MM-dd");
                    SqlDataReader DR = sqlcmd.ExecuteReader();
                    DT.Load(DR);
                    CloseConnection();
                    return DT;
               }
            public bool InsertRegistration(string username, string fullname, string password, string email, DateTime dateTime, string contactno, string address, string type, string cnic, string designation)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("INSERT INTO STAFF VALUES('" + username + "','" + fullname + "','" + password + "','" + email + "',@date,'" + contactno + "','" + address + "','" + type + "','" + cnic + "','" + designation + "')", SqlCon);
                sqlcmd.Parameters.Add(new SqlParameter("@date", dateTime.Date.ToShortDateString()));

                int response = sqlcmd.ExecuteNonQuery();

                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            public DataTable GetProfileData(string AgentName, string AgentType)
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM STAFF WHERE USERNAME='" + AgentName + "' AND [TYPE]='" + AgentType + "'", SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                return dt;
            }
            public bool UpdateProfile(string username, string fullname, string password, string email, DateTime dateTime, string contactno, string address, string AgentName, string AgentType, string cnic, string designation)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("UPDATE STAFF SET username='" + username + "', Fullname='" + fullname + "', password='" + password + "', email='" + email + "', DOB=@date, contact_no='" + contactno + "', address='" + address + "', CNIC='" + cnic + "', Designation='" + designation + "' where username='" + AgentName + "' and [TYPE]='" + AgentType + "'", SqlCon);
                sqlcmd.Parameters.Add(new SqlParameter("@date", dateTime.Date.ToShortDateString()));

                int response = sqlcmd.ExecuteNonQuery();

                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public DataTable getAllStaff()
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM STAFF WHERE [Type] = 'SalesAgent'", SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                return dt;
            }
            public bool UpdateEmployee(string username, string fullname, string password, string email, DateTime dateTime, string contactno, string address, int Staff_ID, string cnic, string designation)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("UPDATE STAFF SET username='" + username + "', Fullname='" + fullname + "', password='" + password + "', email='" + email + "', DOB=@date, contact_no='" + contactno + "', address='" + address + "', CNIC='" + cnic + "',Designation='" + designation + "' where Staff_ID=" + Staff_ID, SqlCon);
                sqlcmd.Parameters.Add(new SqlParameter("@date", dateTime.Date.ToShortDateString()));

                int response = sqlcmd.ExecuteNonQuery();

                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool DeleteEmployee(int Staff_ID)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("DELETE FROM STAFF where Staff_ID=" + Staff_ID, SqlCon);

                int response = sqlcmd.ExecuteNonQuery();

                if (response > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public int GetNewMenuItem()
            {
                int response = 0;

                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("SELECT COUNT(*) FROM MENU", SqlCon);
                SqlDataReader sqldr = sqlcmd.ExecuteReader();

                if (sqldr.HasRows)
                {
                    sqldr.Read();

                    response = int.Parse(sqldr[0].ToString());
                    sqldr.Close();

                    return response + 1;
                }
                else
                {
                    return response + 1;
                }
            }
            public int getNoOfGuests(int id)
            {
                int n;
                OpenConnection();
                SqlCommand sqlcmd = new SqlCommand("SELECT no_of_guests FROM event WHERE BOOKING_ID = "+id, SqlCon);
                SqlDataReader sqldr = sqlcmd.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Load(sqldr);
                n = int.Parse(DT.Rows[0]["no_of_guests"].ToString());
                return n;
            }
            public void InsertNewMenuNo(int menuNo)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("INSERT INTO MENU VALUES(" + menuNo + ")", SqlCon);
                sqlcmd.ExecuteNonQuery();
            }
            public void InsertNewMenuItem(string menuitem, int menuNo)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("INSERT INTO MENU_ITEMS VALUES('" + menuitem + "'," + menuNo + ")", SqlCon);
                sqlcmd.ExecuteNonQuery();
            }
            public DataTable GetAllMenuNo()
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("SELECT * FROM DISHES", SqlCon);
                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();

                sqlda.Fill(dt);
                return dt;
            }
            public DataTable getAllMenuItems(int menuNo)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Menu_Items WHERE Menu_ID=" + menuNo, SqlCon);
                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();

                sqlda.Fill(dt);
                return dt;
            }
            public void DelMenuItem(string menuitem, int menuNo)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("Delete from MENU_ITEMS where Item_Name='" + menuitem + "' and Menu_ID=" + menuNo, SqlCon);
                sqlcmd.ExecuteNonQuery();
            }
            public void DeleteEntireMenu(int menuNo)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("Delete from MENU_ITEMS where Menu_ID=" + menuNo, SqlCon);
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("DELETE FROM MENU WHERE MENU_NO=" + menuNo, SqlCon);
                sqlcmd.ExecuteNonQuery();
            }
            public bool FindCategory(string CategoryName)
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT Count(*) FROM CATEGORY WHERE Category_Name='" + CategoryName + "'", SqlCon);
                DataTable dt = new DataTable();

                sqlda.Fill(dt);

                if (int.Parse(dt.Rows[0][0].ToString()) > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void InsertNewCategory(string CategoryName)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("INSERT INTO CATEGORY VALUES('" + CategoryName + "')", SqlCon);
                sqlcmd.ExecuteNonQuery();
            }
            public List<String> getAllCategoryName()
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("SELECT Category_Name FROM CATEGORY ", SqlCon);
                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();

                sqlda.Fill(dt);

                List<String> categorynameLI = new List<String>();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        categorynameLI.Add(dt.Rows[i]["Category_Name"].ToString());
                    }
                }
                return categorynameLI;
            }
            public List<String> GetAllFacilityByCategoryName(string CategoryName)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("SELECT [Facility] FROM [dbo].[Facility] where Category_Name='" + CategoryName + "'", SqlCon);
                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();

                sqlda.Fill(dt);

                List<String> categorynameLI = new List<String>();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        categorynameLI.Add(dt.Rows[i]["Facility"].ToString());
                    }
                }
                return categorynameLI;
            }
            public bool FindFacility(string FacilityItem, string CategorySelected)
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT Count(*) FROM FACILITY WHERE Category_Name='" + CategorySelected + "' AND Facility='" + FacilityItem + "'", SqlCon);
                DataTable dt = new DataTable();

                sqlda.Fill(dt);

                if (int.Parse(dt.Rows[0][0].ToString()) > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void InsertNewFacility(string CategorySelected, string FacilityItem)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("INSERT INTO FACILITY VALUES('" + CategorySelected + "','" + FacilityItem + "')", SqlCon);
                sqlcmd.ExecuteNonQuery();
            }
            public void DeleteFacility(string FacilityRemove, string CategorySelected)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("Delete from FACILITY where Category_Name='" + CategorySelected + "' and Facility='" + FacilityRemove + "'", SqlCon);
                sqlcmd.ExecuteNonQuery();
            }
            public void DeleteEntireCategory(string categoryname)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("Delete from CATEGORY where Category_Name='" + categoryname + "'", SqlCon);
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("DELETE FROM FACILITY WHERE Category_Name='" + categoryname + "'", SqlCon);
                sqlcmd.ExecuteNonQuery();
            }

            public int InsertNewBooking(string guestname, string typeofevent, string venue, string noofpersons, DateTime stime, DateTime etime, DateTime eventdate, string contactno,float amount)
            {
                OpenConnection();

                string query = "";
                
                query = "INSERT INTO EVENT (name,Event_date,starting_time,end_time,hall_no,type,no_of_guests,amount) VALUES(@name,@Event_date,@starting_time,@end_time,@hall_no,@type,@no_of_guests,@amount);SELECT ident_Current('event') AS 'Booking_ID'";
                SqlCommand sqlcmd = new SqlCommand(query, SqlCon);
                sqlcmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = guestname;
            
                sqlcmd.Parameters.Add(new SqlParameter("@starting_time", stime.ToShortTimeString()));
                sqlcmd.Parameters.Add(new SqlParameter("@Event_date", eventdate.ToShortDateString()));
                sqlcmd.Parameters.Add(new SqlParameter("@end_time", etime.ToShortTimeString()));
                sqlcmd.Parameters.Add("@hall_no", SqlDbType.VarChar, 5).Value = venue;
                sqlcmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = typeofevent;
                sqlcmd.Parameters.Add("@no_of_guests", SqlDbType.VarChar, 50).Value = noofpersons;
                sqlcmd.Parameters.Add("@amount", SqlDbType.Money).Value = amount;
                int response = int.Parse(sqlcmd.ExecuteScalar().ToString());
                if (response > 0)
                {
                    return response;
                }
                else
                {
                    return 0;
                }
            }

            public void InsertSelectedMenus(string MenuItems, int BookingID,float amount)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("INSERT INTO MENU_FOR_EVENTS VALUES(" + BookingID + ",'" + MenuItems + "')", SqlCon);
                sqlcmd.ExecuteNonQuery();
                sqlcmd = new SqlCommand("update event set amount = amount + "+amount+" where booking_id ="+BookingID+";",SqlCon);
                sqlcmd.ExecuteNonQuery();

            CloseConnection();
            }

            public void InsertSelectedFacility(string Category, string Facility, int amount, int BookingID)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("INSERT INTO SELECTEDFACILITY VALUES('" + Category + "','" + Facility + "'," + amount + "," + BookingID + ")", SqlCon);
                sqlcmd.ExecuteNonQuery();
            }

            public void UpdateAmountInfo(int amount, string amountwords, int bookingID)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("UPDATE Client_Booking SET TotalAmount=" + amount + " , AmountInWords='" + amountwords + "' WHERE Booking_ID=" + bookingID, SqlCon);
                sqlcmd.ExecuteNonQuery();
            }

            public DataTable getAllBookingsNoFilter()
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT Booking_ID,name,type,hall_no,no_of_guests,starting_time,event_date,amount from event where status = 'confirmed' and event_date > GETDATE();", SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                return dt;
            }

            public DataSet getBookingById(String id)
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT Booking_ID,name,event_date,amount from event where Booking_id= "+id+" and status = 'confirmed' and event_date > GETDATE();", SqlCon);
                DataSet dt = new DataSet();
                sqlda.Fill(dt,"event");
                return dt;
            }
            public DataSet getEmployeeById(String id)
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT id,name,phone,status from employee where id= " + id + ";", SqlCon);
                DataSet dt = new DataSet();
                sqlda.Fill(dt, "event");
                return dt;
            }
        public DataTable getAllEmployeesNoFilter()
        {
            OpenConnection();

            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT id, name, type, phone, address, status from Employee ;", SqlCon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            return dt;
        }
        public DataTable GetAllBookingsByFilter(string SearchCriteria, string keyword)
            {
                OpenConnection();
                int Intkeyword = 0;
                SqlDataAdapter sqlda;
                if (SearchCriteria == "BookingID")
                {
                    Intkeyword = int.Parse(keyword);
                    sqlda = new SqlDataAdapter("SELECT Booking_ID,GuestName,TypeOfEvent,Venue,NoOfPersons,EventTime,EventDate,BookingDate,BookingBy,TotalAmount FROM Client_Booking WHERE " + SearchCriteria + " =" + Intkeyword, SqlCon);
                }
                else
                {
                    sqlda = new SqlDataAdapter("SELECT Booking_ID,GuestName,TypeOfEvent,Venue,NoOfPersons,EventTime,EventDate,BookingDate,BookingBy,TotalAmount FROM Client_Booking WHERE " + SearchCriteria + " Like '" + keyword + "'", SqlCon);
                }
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                return dt;
            }

            public DataTable getBookingById(int p)
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Client_Booking WHERE Booking_ID=" + p, SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                return dt;
            }

            public void cancelBooking(string id)
            {
                OpenConnection();
                string qurey = "UPDATE event set status = 'cancelled' where booking_id= " + id + ";";
                SqlCommand sqlcmd = new SqlCommand(qurey, SqlCon);
                sqlcmd.ExecuteNonQuery();    
            }

            public void removeEmployee(string id)
            {
                OpenConnection();
                string qurey = "UPDATE employee set status = 'inactive' where ID= " + id + ";";
                SqlCommand sqlcmd = new SqlCommand(qurey, SqlCon);
                sqlcmd.ExecuteNonQuery();
            }
        public DataTable getAllMenuItemsByID(int p)
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM SELECTEDMENU WHERE Booking_ID=" + p, SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                return dt;
            }

            public void UpdateSelectedMenus(string MenuNos, string MenuItems, int amount, int BookingID)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("UPDATE SELECTEDMENU SET MenuNos='" + MenuNos + "', MenuItems='" + MenuItems + "',Amount=" + amount + " Where Booking_ID=" + BookingID, SqlCon);
                sqlcmd.ExecuteNonQuery();
            }

            public DataTable getAllFacilityItemsByID(int p)
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM selectedfacility WHERE Booking_ID=" + p, SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                return dt;
            }

            public void UpdatedSelectedFacility(string Category, string Facility, int amount, int BookingID)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand("UPDATE SELECTEDFACILITY SET Category='" + Category + "', Facility='" + Facility + "', Amount=" + amount + " Where Booking_ID=" + BookingID + ")", SqlCon);
                sqlcmd.ExecuteNonQuery();
            }

            public DataTable getRecieptData(int BookingID)
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Client_Booking WHERE Booking_ID=" + BookingID, SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                return dt;
            }
            public DataTable getAllPayments(int BookingID)
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Payments WHERE Booking_ID=" + BookingID, SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                return dt;
            }

            public int InsertPayment(int BookingID, string AgentName, int paymentamount, string paymenttype, string chequeno)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand(" INSERT INTO PAYMENTS VALUES (" + paymentamount + ",GETDATE(),'" + AgentName + "'," + BookingID + ",'" + paymenttype + "','" + chequeno + "') ", SqlCon);
                int response = sqlcmd.ExecuteNonQuery();
                return response;
            }

            public int GetTotalAmount(int BookingID)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand(" select TotalAmount from Client_Booking where Booking_ID=" + BookingID, SqlCon);
                SqlDataReader rdr = sqlcmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    int amount = int.Parse(rdr["TotalAmount"].ToString());
                    rdr.Close();
                    return amount;
                }
                else
                {
                    return 0;
                }
            }

            public int InsertVisitorsInfo(string p1, string p2, int p3, DateTime dateTime, string p4, string AgentName, string purpose)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand(" INSERT INTO Visitors VALUES ('" + p1 + "','" + p2 + "'," + p3 + ",'" + purpose + "',@Bookingdate,GETDATE(),'" + p4 + "','" + AgentName + "');SELECT IDENT_CURRENT('Visitors') AS 'VisitorsID' ", SqlCon);
                sqlcmd.Parameters.Add(new SqlParameter("@Bookingdate", dateTime.Date));
                int response = int.Parse(sqlcmd.ExecuteScalar().ToString());
                return response;
            }

            public DataTable GetAllVisitors()
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT VisitorsID as [Visitors No],VisitorsName as [Name], contactno as [Contact No], noofpersons as [No Of Guests],purpose as [Lunch/Dinner],BookingDate as [Event Date],VisitingDate as [Visited Date],remarks as [Remarks], AttendedBy as [Attended By] FROM Visitors ", SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                return dt;
            }

            public int getFacilityAmount(int BookingID)
            {
                OpenConnection();
                SqlCommand sqlcmd = new SqlCommand("SELECT Amount from selectedfacility where Booking_ID=" + BookingID, SqlCon);
                SqlDataReader rdr = sqlcmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    int amount = int.Parse(rdr["Amount"].ToString());
                    rdr.Close();
                    return amount;
                }
                else
                {
                    return 0;
                }
            }

            public int getMenuAmount(int BookingID)
            {
                OpenConnection();
                SqlCommand sqlcmd = new SqlCommand("SELECT Amount from selectedmenu where Booking_ID=" + BookingID, SqlCon);
                SqlDataReader rdr = sqlcmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    int amount = int.Parse(rdr["Amount"].ToString());
                    rdr.Close();
                    return amount;
                }
                else
                {
                    return 0;
                }
            }


            public int getDiscountAmount(int BookingID)
            {
                OpenConnection();

                SqlCommand sqlcmd = new SqlCommand(" select AmountReceived from Payments where Booking_ID=" + BookingID + " and AmountType='Discount'", SqlCon);
                SqlDataReader rdr = sqlcmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    int amount = int.Parse(rdr["AmountReceived"].ToString());
                    rdr.Close();
                    return amount;
                }
                else
                {
                    return 0;
                }
            }

            public DataTable getAllBookings()
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT Booking_ID,GuestName,TypeOfEvent,Venue,NoOfPersons,EventTime,EventDate,BookingDate,BookingBy,TotalAmount FROM Client_Booking", SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                return dt;
            }

            public DataTable getBothVisitorsBooking()
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("select Distinct(cb.GuestName )as [GuestName],cb.Booking_ID as [GuestID],cb.NoOfPersons as [NoOfGuests], " +
                    " cb.TypeOfEvent as [Purpose],cb.EventDate as [EventDate],cb.BookingDate as [VisitedDate], " +
                    " cb.BookingBy as [AttendedBy]  from visitors v, client_booking cb " +
                    " where cb.visitorsid = v.visitorsid", SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                return dt;
            }

            public DataTable getJustBookers()
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("select Distinct(cb.GuestName )as [GuestName],cb.Booking_ID as [GuestID],cb.NoOfPersons as [NoOfGuests], " +
                    " cb.TypeOfEvent as [Purpose],cb.EventDate as [EventDate],cb.BookingDate as [VisitedDate], " +
                    " cb.BookingBy as [AttendedBy] ,cb.Visitorsid   from  client_booking cb ", SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                return dt;
            }

            public DataTable getJustVisitors()
            {
                OpenConnection();

                SqlDataAdapter sqlda = new SqlDataAdapter("select Distinct(v.VisitorsName )as [GuestName],v.VisitorsID as [GuestID],v.noofpersons as [NoOfGuests], " +
                    " v.purpose as [Purpose],v.VisitingDate as [EventDate],v.BookingDate as [VisitedDate], " +
                    " v.AttendedBy as [AttendedBy]  from visitors v ", SqlCon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                return dt;
            }
        }
    }



