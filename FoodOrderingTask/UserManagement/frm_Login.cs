using FoodOrderingTask.DashBoard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingTask
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Role Id Reffers either a user is a customer or Chef
            if (cmb_RoleID.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Role", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Main.RoleID = int.Parse(cmb_RoleID.SelectedValue.ToString());
                if (txt_Username.Text != "")
                {

                    if (txt_Password.Text != "")
                    {
                        if (Main.CheckUserName(txt_Username.Text) == true)
                        {
                            if (Main.checkPassword(txt_Username.Text, txt_Password.Text) == true)
                            {
                                Main.UserName = txt_Username.Text;
                                // I will get the UserID coresponding to the user name from the database 
                                String sUserId=SQL.ScalarQuery("Select L_ID from login where L_Username = '"+Main.UserName+"'");
                                int id;
                                //Since the id is an int a simple test is performed to convert the string to int 
                                if (int.TryParse(sUserId,out id))
                                {
                                    Main.UserID = id;
                                }
                                // The login form will disappear
                                this.Hide();
                                // Main form (Home) will appear
                                var NEW = new frm_Main();
                                NEW.ShowDialog();

                            }
                            else MessageBox.Show("Invalid Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                        else MessageBox.Show("Invalid Username", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else MessageBox.Show("Please Enter Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else MessageBox.Show("Please Enter UserName", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        /// <summary>
        /// When a user click on the close button the application is terminated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// When the user click a create account a form for user registration will appear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lab_CreateAccount_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            var frm_Register = new frm_Register();
            frm_Register.Show();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            try
            {
                String CustomerCount = SQL.ScalarQuery("SELECT COUNT(RoleID) FROM  RoleSetup WHERE RoleActive =1");
                if (CustomerCount == "0")
                {
                    MessageBox.Show("No Role Found", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    Main.fillCombo(cmb_RoleID, "RoleSetup", "RoleName", "RoleID", "RoleActive=1");

                }
            }
            catch (Exception)
            {
            }
        }
    }
    }