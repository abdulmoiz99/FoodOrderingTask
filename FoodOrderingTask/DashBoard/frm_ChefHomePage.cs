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
    public partial class frm_ChefHomePage : Form
    {
        public frm_ChefHomePage()
        {
            InitializeComponent();
        }

        private void frm_ChefHomePage_Load(object sender, EventArgs e)
        {
            String Username = SQL.ScalarQuery("Select L_Username from login where L_Id = " + Main.UserID + "");
            lab_Username.Text = Username.ToUpper();
            lab_Role.Text = "Chef";
        }

        private void lab_Username_Click(object sender, EventArgs e)
        {

        }

        private void frm_ChefHomePage_Activated(object sender, EventArgs e)
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
            Main.fillDgv(dgv_FoodList, "Select C_Name,C_Price,C_Type,C_Paid,C_PaymentMethod,C_Status,C_Buyer from cart where c_Seller ='" + Main.UserName + "'");
            if (dgv_FoodList.RowCount > 0)
            {
                pnl_RecentSales.Visible = false;
            }
            label3.Text = dgv_FoodList.RowCount.ToString() + " RECENT SALES";
        }

        private void dgv_FoodList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
