using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace FoodOrderingTask
{
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When the user clicks the close button the application will be terminated 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new frm_Login();
            login.Show();
            //this.Close();
        }

        private void frm_Register_Load(object sender, EventArgs e)
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
            try
            {
                String QuestionsCount = SQL.ScalarQuery("SELECT COUNT(Q_ID) FROM  SecurityQuestions");
                if (QuestionsCount == "0")
                {
                    MessageBox.Show("No Questions Found", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    Main.fillCombo(cmb_QuestionsID1, "SecurityQuestions", "Q_Questions", "Q_ID", "Q_ID>0 AND Q_ID<6");
                    Main.fillCombo(cmb_QuestionsID2, "SecurityQuestions", "Q_Questions", "Q_ID", "Q_ID>5 AND Q_ID<11");
                }
            }
            catch (Exception)
            {
            }

        }
        /// <summary>
        /// This function check the user name is the existing database 
        /// If a user name is there it will return false and does not allow the user to create an account with that username 
        /// If the username is not there a user can simply create an account by providing his/her details 
        /// no Same username is allowed in the database 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckInList(string name)
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM login  WHERE L_username = '" + name + "' ) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) return true;
            else return false;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Some of the checks before saving the data into database
            if (cmb_QuestionsID1.SelectedIndex < 0 || cmb_QuestionsID2.SelectedIndex < 0) 
            {
                MessageBox.Show("Please Select Your Questions", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Question1.Text == "" || txt_Question2.Text == "")
            {
                MessageBox.Show("Please Enter Your Answers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                /// Login table holds the record of every user if the provide information is correct a new record is added 
                SQL.NonScalarQuery(@"Insert Into Login(L_Username                 ,L_Password                 ,L_PhoneNo                 ,L_Email                 ,L_Address                 ,L_Role,L_Question1                ,L_Answer1                 ,L_Question2                 ,L_Answer2)
                                                values('" + txt_Username.Text + "','" + txt_Password.Text + "','" + txt_PhoneNo.Text + "','" + txt_Emial.Text + "','" + txt_Address.Text + "','" + cmb_RoleID.SelectedValue + "'," + (cmb_QuestionsID1.SelectedIndex + 1) + ",'" + txt_Question1.Text + "'," + (cmb_QuestionsID2.SelectedIndex + 6) + ",'" + txt_Question2.Text + "')");
                // A confirmation message for the user about the registration 
                MessageBox.Show("User Created Successfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                frm_Login form = new frm_Login();
                form.Show();
            }

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            lab_usernameStatus.Visible = true;
            if (txt_Username.TextLength < 4)
            {
                pb_X.Visible = true;
                lab_usernameStatus.Text = "Username must be in 4 characters";
                pb_Correct.Visible = false;
                lab_usernameStatus.ForeColor = Color.FromArgb(217, 77, 65);
            }
            else if (CheckInList(txt_Username.Text) == true)
            {
                lab_usernameStatus.Text = "Username not available ";
                pb_X.Visible = true;
                pb_Correct.Visible = false;
                lab_usernameStatus.ForeColor = Color.FromArgb(217, 77, 65);

            }
            else
            {
                pb_X.Visible = false;
                pb_Correct.Visible = true;
                lab_usernameStatus.Text = "";
                lab_usernameStatus.Text = "Username available ";
                lab_usernameStatus.ForeColor = Color.FromArgb(30, 115, 76);

            }
        }

        private void txt_Emial_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(txt_Emial.Text);
                lab_emailStatus.Visible = false;

            }
            catch (FormatException ex)
            {
                lab_emailStatus.Visible = true;
                lab_emailStatus.Text = "Invalid Email Address";
                // wrong e-mail address
            }
        }

        private void txt_PhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (txt_PhoneNo.TextLength < 8)
            {
                lab_PhoneStatus.Visible = true;
                lab_PhoneStatus.Text = "Invalid Phone No";
            }
            else
            {
                lab_PhoneStatus.Visible = false;

            }

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            if(txt_Password.TextLength<7)
            {
                lab_PasswordStatus.Text = "Password length too short";
                lab_PasswordStatus.Visible = true;
            }
            else
            {
                lab_PasswordStatus.Visible = false;
            }
        }

        private void txt_PhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            //Some of the checks before saving the data into database 
            if (txt_Username.Text == "")
            {
                MessageBox.Show("Please Enter Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CheckInList(txt_Username.Text) == true)
            {
                MessageBox.Show("Username already Taken", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_PhoneNo.Text == "")
            {
                MessageBox.Show("Please Enter Phone No", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Emial.Text == "")
            {
                MessageBox.Show("Please Enter E-Mail", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Address.Text == "")
            {
                MessageBox.Show("Please Enter Address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb_RoleID.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Role ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                btn_Next.Visible = false;
                txt_Username.Visible = false;
                txt_Password.Visible = false;
                txt_Emial.Visible = false;
                txt_PhoneNo.Visible = false;
                txt_Address.Visible = false;
                cmb_RoleID.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                lab_usernameStatus.Visible = false;
                lab_PhoneStatus.Visible = false;
                lab_emailStatus.Visible = false;
                lab_PasswordStatus.Visible = false;
                pb_Correct.Visible = false;
                pb_X.Visible = false;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                label7.Visible = true;
                label9.Visible = true;
                cmb_QuestionsID1.Visible = true;
                cmb_QuestionsID2.Visible = true;
                txt_Question1.Visible = true;
                txt_Question2.Visible = true;
                panel6.Visible = true;
                panel7.Visible = true;
                btn_Login.Visible = true;
            }
        }

        private void txt_Question1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

