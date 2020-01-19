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
    public partial class frm_ChefRequest : Form
    {
        public frm_ChefRequest()
        {
            InitializeComponent();
            Main.UserID = 1;
        }
        public bool CheckUserID()
        {
            string Compare = "";
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS(SELECT TOP 1 * FROM ChefRequest  WHERE CR_UserID= " + Main.UserID + ") THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) return true;
            else return false;
        }
        private void btn_SubmitRequest_Click(object sender, EventArgs e)
        {
            if (txt_Why.Text == "")
            {
                MessageBox.Show("Please Write an Application To Apply for this job", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (CheckUserID() == true)
                {
                    SQL.NonScalarQuery("Update ChefRequest Set CR_Application='" + txt_Why.Text + "' , CR_Status='PENDING' where CR_UserID =" + Main.UserID + "");
                }
                else
                {
                    SQL.NonScalarQuery(@"Insert Into ChefRequest(CR_UserID          ,CR_Username            ,CR_Application        ,CR_Status,CR_Active)
                                                          values(" + Main.UserID + ",'" + Main.UserName + "','" + txt_Why.Text + "','PENDING' ,1)");
                    MessageBox.Show("Your Request Is Submitted Successfull.You Will Be Notify Shortly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
