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
    public partial class lab_DeliveryStatus : Form
    {
        public lab_DeliveryStatus()
        {
            InitializeComponent();
          
        }

        private void frm_HomePage_Load(object sender, EventArgs e)
        {
            String Username = SQL.ScalarQuery("Select L_Username from login where L_Id = " + Main.UserID + "");
            lab_Username.Text =  Username.ToUpper();
            lab_Role.Text = "Customer";
        }

        private void frm_HomePage_Activated(object sender, EventArgs e)
        {
            dgv_FoodList.BorderStyle = BorderStyle.None;
            dgv_FoodList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_FoodList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_FoodList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv_FoodList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_FoodList.BackgroundColor = Color.White;
            dgv_FoodList.EnableHeadersVisualStyles = false;
            dgv_FoodList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_FoodList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(99, 99, 99);
            dgv_FoodList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dgv_FoodList.Rows)
            {
                row.Height = 40;
            }
            Main.fillDgv(dgv_FoodList, "Select C_Name,C_Price,C_Type from cart where c_UserId =" + Main.UserID + " AND C_Paid = 1");
            if(dgv_FoodList.RowCount>0)
            {
                pnl_RecentPurchase.Visible = false;
            }
<<<<<<< HEAD
            label3.Text = dgv_FoodList.RowCount.ToString() + " RECENT PURCHASES";
=======


            String Status;
            Status = SQL.ScalarQuery("select C_Status,C_Id from Cart where C_userID = " + Main.UserID + " ORDER BY C_Id DESC");
            lab_Status.Text ="Current Delivery Status : "+ Status;
>>>>>>> feefd190f6863864c1b496ed201a658a38d30e66
        }

        private void lab_Username_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_RecentPurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
