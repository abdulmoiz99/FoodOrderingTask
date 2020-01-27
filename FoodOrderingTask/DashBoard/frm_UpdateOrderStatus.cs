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
    public partial class frm_UpdateOrderStatus : Form
    {
        public frm_UpdateOrderStatus()
        {
            InitializeComponent();
        }

        private void frm_UpdateOrderStatus_Load(object sender, EventArgs e)
        {

        }

        private void frm_UpdateOrderStatus_Activated(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_ChefRequest, "select distinct L_Username ,C_UserId , C_Status from TvufrmDeliveryStatus where C_Status != 'DELIVER' AND C_Status != 'CANCELLED' ");
        }
        public void GetOrderDetails()
        {
            Main.fillDgv(dgv_OrderDetails, "select C_Name from Cart where C_Paid=1 and C_userID = '" + int.Parse(txt_UserID.Text) + "'");
        }
        private void dgv_ChefRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // AllClear();
                int index = e.RowIndex;
                if (index > -1)
                {
                    txt_DataGridViewIndex.Text = index.ToString();
                    DataGridViewRow selectedrow = dgv_ChefRequest.Rows[index];
                    txt_DataGridViewIndex.Text = selectedrow.Cells["C_userID"].Value.ToString();
                    txt_Username.Text = selectedrow.Cells["L_Username"].Value.ToString();
                    txt_OrderStatus.Text = selectedrow.Cells["C_Status"].Value.ToString().ToUpper();
                    txt_UserID.Text = selectedrow.Cells["C_UserId"].Value.ToString();
                    GetOrderDetails();
                }
                index = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_UpdateRequest_Click(object sender, EventArgs e)
        {
            if (txt_UserID.Text == "")
            {
                MessageBox.Show("Please Select A Record First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb_Status.SelectedIndex<0)
            {
                MessageBox.Show("Please Select Delivery Status", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SQL.NonScalarQuery("Update Cart Set C_Status = '" + cmb_Status.Text + "' where C_UserID = " + int.Parse(txt_UserID.Text) + " And C_Status = '" + txt_OrderStatus.Text + "'");
                MessageBox.Show("Status Updated Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_UserID.Text = "";
                txt_Username.Text = "";
                txt_OrderStatus.Text = "";
            }
        }
    }
 }
