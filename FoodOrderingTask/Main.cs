using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingTask
{
    /// <summary>
    /// We have name this class as Main just because it contains all the necessary functions , datatype that are widely used in the software 
    /// This provide ease to the programmer and save tone of lines 
    /// </summary>
    class Main
    {
        //Role Id Reffers to the user type either the user is a customer or chef
        private static int roleID;
        //It save the username as long as the application is running
        private static string userName;
        //It save the userid as long as the application is running
        // We have assign autogenerted Id to ever User 
        private static int userID;

        // getters and Setter for the above datatypes
        // Using getter and setter is one of the best practices of Object Oriented Programming
        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public static int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public static int RoleID
        { get
            { return roleID;}

            set { roleID = value; }
        }
        // end of getters and setter 

        /// <summary>
        /// this Function check the user name form the database 
        /// if a user name avaiable it return true else it retuen false 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool CheckUserName(string name)
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM login  WHERE L_username = '" + name + "') THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) return true;
            else return false;
        }
        /// <summary>
        /// it has two parameter this function validate the password with correspondence to username 
        /// if the password match it will return true else false 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool checkPassword(string name, string password)
        {
            string oPassword = "";
            oPassword = SQL.ScalarQuery("Select L_password from login where L_username='" + name + "'");
            if (string.Compare(password, oPassword) == 0) return true;
            else return false;
        }
        /// <summary>
        /// Combo Box is a widely used tool so we decided to create a function for it just because it requires alot of lines to run 
        /// the main logic here is DisplayMember and ValueMember 
        /// It is quite simple for the user the combobox will show the feild names (Display Member)
        /// For the programmer it will return an id with that feild (Value Member)
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="TableName"></param>
        /// <param name="DisplayMember"></param>
        /// <param name="ValueMember"></param>
        /// <param name="Condition"></param>
        public static void fillCombo(ComboBox combo, String TableName, String DisplayMember, String ValueMember, String Condition)//, List<T> Models, string Name, string Value)
        {
            try
            {
                if (SQL.Con.State == ConnectionState.Open)
                {
                    SQL.Con.Close();
                }
                SQL.Con.Open();
                var tb1 = new DataTable();
                var cmd1 = new SqlCommand("select " + ValueMember + " , " + DisplayMember + " from " + TableName + " where " + Condition + "", SQL.Con);
                SqlDataReader d1;
                d1 = cmd1.ExecuteReader();
                tb1.Load(d1);
                combo.DisplayMember = DisplayMember;
                combo.ValueMember = ValueMember;
                combo.DataSource = tb1;
                SQL.Con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function is used to fill the content of DataGridView 
        /// it requires two parameter the name of the data grid view and the query which you want to implement on that datagrid 
        /// </summary>
        /// <param name="DataGridView"></param>
        /// <param name="Query"></param>
        public static void fillDgv(DataGridView DataGridView, String Query)
        {
            try
            {
                if (SQL.Con.State == ConnectionState.Open)
                {
                    SQL.Con.Close();
                }
                SQL.Con.Open();
                var cmd2 = new SqlCommand(Query, SQL.Con);
                var da = new SqlDataAdapter(cmd2);
                var ds = new DataTable();
                da.Fill(ds);
                DataGridView.DataSource = ds;
                SQL.Con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Data Grid View");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Data Grid View");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Grid View");
            }
        }
        public static bool CheckCheffApplication(int ID)
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM ChefRequest  WHERE CR_UserID = " + ID + " and CR_Status = 'PENDING') THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) return true;
            else return false;
        }

        public static bool IsChef(int ID)
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM Login  WHERE L_ID = " + ID + " and L_Role = 2) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) return true;
            else return false;
        }

    }
}
