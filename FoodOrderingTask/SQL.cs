using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingTask
{
    /// <summary>
    /// This Class maily deals will all kind of operations related to SQL queries 
    /// Every Function in this class is static so it can be access all over the Solution by just calling the class name with function e.g SQL.<Here Function Name will Come >
    /// </summary>
    ///
    class SQL
    {
        // Datasource Reffers to the connection string of SQL server 
        public static String DataSource = ReadCS();
        // Here the SQL connection is intialize
        private static readonly SqlConnection con = new SqlConnection(DataSource);// ReadCS().ToString()); 
        //Only the getter method for SQL connection As we dont allow it to change by anyone through out the application 
        public static SqlConnection Con
        {
            get { return con; }
        }
        /// <summary>
        /// ReadCS() is a simple but intersting funtion we have store a connection string in text format in Debug folder as it is the starting path when ever the application is launched
        /// When this function is call a First it tries to locate the File is not present it will throw an error otherwise gets the connection string
        /// </summary>
        /// <returns></returns>
        public static string ReadCS()
        {
            var lines = "";
            // The file extenstion isn set to be dat becasuse we not want anyone to recognized it as a text file 
            //Just a smart move 
            string Path = Application.StartupPath + @"\SQL.dat";
            if (!File.Exists(Path))
            {
                MessageBox.Show("Unable To Find Connection File ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (var streamReader = new StreamReader(Path))
                {
                    try
                    {
                        lines = streamReader.ReadLine();
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "SQL");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SQl");
                    }
                }
            }

            return lines;
        }
        /// <summary>
        /// Scalar Query refferes to those queries of SQL which gets an result back from the database 
        /// For example this Query can be use to get user information that is already stored 
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
        public static string ScalarQuery(string Query)
        {
            String Result = string.Empty;
            try
            {

                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                Con.Open();
                SqlCommand cmd = new SqlCommand(Query, Con);
                Result = cmd.ExecuteScalar().ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("SQL Scalar Query" + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return Result;
        }
        /// <summary>
        ///  Non Scalar Query refferes to those queries of SQL which doesnot send a result back
        /// For example this Query can be use to insert , Updata , Delete purpose but it can not be use to reterive any type of data 
        /// </summary>
        /// <param name="Query"></param>
        public static void NonScalarQuery(String Query)
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                Con.Open();
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("SQL" + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}

