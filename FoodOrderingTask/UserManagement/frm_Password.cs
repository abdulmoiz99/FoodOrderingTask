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

namespace FoodOrderingTask.UserManagement
{
    public partial class frm_Password : Form
    {
        public frm_Password()
        {
            InitializeComponent();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM login  WHERE L_username = '" + txt_Username.Text + "' ) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) 
            {
                lab_Username_Status.Visible = false;
                panel3.Visible = true;
                string qID1 = SQL.ScalarQuery("Select L_Question1 from login where L_Username = '" + txt_Username.Text + "'");
                string qID2 = SQL.ScalarQuery("Select L_Question2 from login where L_Username = '" + txt_Username.Text + "'");
                lab_Question1.Text = SQL.ScalarQuery("Select Q_Questions from SecurityQuestions where Q_ID = " + qID1 + "");
                lab_Question2.Text = SQL.ScalarQuery("Select Q_Questions from SecurityQuestions where Q_ID = " + qID2 + "");

            }
            else
            {
                lab_Username_Status.Visible = true;
            }
        }

        private void btn_Enter2_Click(object sender, EventArgs e)
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM login  WHERE L_Answer1 = '" + txt_Answer1.Text + "'  AND L_Answer2 = '" + txt_Answer2.Text + "' ) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0)
            {
                lab_Answers.Visible = false;
                panel4.Visible = true;
            }
            else
            {
                lab_Answers.Visible = true;
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text.Equals(txt_Password2.Text))
            {
                ChangePassword();
            }
            else 
            {
                lab_Password_Status.Visible = true;
            }
        }

        private void ChangePassword()
        {
            try
            {
                if (SQL.Con.State == ConnectionState.Open)
                {
                    SQL.Con.Close();
                }
                SQL.Con.Open();
                lab_Password_Status.Visible = false;
                String Query = @"UPDATE        Login
                                 SET           L_Password = '" + txt_Password.Text + @"'
                                 WHERE		   L_Username = '" + txt_Username.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, SQL.Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Changed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
