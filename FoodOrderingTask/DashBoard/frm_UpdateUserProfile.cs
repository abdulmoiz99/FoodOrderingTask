using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingTask.DashBoard
{
    public partial class frm_UpdateUserProfile : Form
    {
        public frm_UpdateUserProfile()
        {
            InitializeComponent();
        }
        public bool CheckInList(string name)
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM login  WHERE L_username = '" + name + "' ) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) return true;
            else return false;
        }
        private void frm_UpdateUserProfile_Load(object sender, EventArgs e)
        {
            txt_Username.Text = Main.UserName;
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
            else if(String.Compare(txt_Username.Text,Main.UserName)==0)
            {
                pb_X.Visible = false;
                pb_Correct.Visible = true;
                lab_usernameStatus.Text = "";
                lab_usernameStatus.Text = "This is You Current Username ";
                lab_usernameStatus.ForeColor = Color.FromArgb(30, 115, 76);
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
             if (txt_Username.Text == "")
            {
                MessageBox.Show("Please Enter Username", "", MessageBoxButtons.OK);
            }
            else if (txt_Email.Text == "")
            {
                MessageBox.Show("Please Enter EMail", "", MessageBoxButtons.OK);
            }
            else if (txt_Phone.Text == "")
            {
                MessageBox.Show("Please Enter Phone No", "", MessageBoxButtons.OK);
            }
            else if (txt_Address.Text == "")
            {
                MessageBox.Show("Please Enter Address", "", MessageBoxButtons.OK);
            }
            else if (txt_OldPassword.Text == "")
            {
                MessageBox.Show("Please Enter Old Password", "", MessageBoxButtons.OK);
            }
            else if (txt_NewPassword.Text == "")
            {
                MessageBox.Show("Please Enter New Password", "", MessageBoxButtons.OK);
            }
            else if (Main.checkPassword(Main.UserName, txt_OldPassword.Text) == false)
            {
                MessageBox.Show("Invalid Old Password ", "", MessageBoxButtons.OK);
            }
            
            else if (string.Compare(txt_NewPassword.Text, txt_OldPassword.Text) == 0)
            {
                MessageBox.Show("Password is same as old password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
            else
            {
                DialogResult YorN = MessageBox.Show("Are you sure to update user settings", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YorN == DialogResult.Yes)
                {
                    SQL.NonScalarQuery("Update login set L_Password ='" + txt_NewPassword.Text + "' ,L_username='" + txt_Username.Text + "',L_PhoneNo = '"+txt_Phone.Text+ "' , L_Email='"+txt_Email.Text+"' , L_Address ='"+txt_Address.Text+"' where l_ID = " + Main.UserID+"");
                    MessageBox.Show("Password Updated Successfull", "Success", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
