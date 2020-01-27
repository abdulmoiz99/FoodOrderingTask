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
    public partial class frm_Payments : Form
    {
        public frm_Payments()
        {
            InitializeComponent();
        }

        private void frm_Payments_Load(object sender, EventArgs e)
        {
            // Some Code to Style the Data Grid View to provide a better User Interface 
            // Start Of Code 
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
            // End Of Code 
            // This function fills the datagridView wil the provided string query
            Main.fillDgv(dgv_FoodList, "Select C_Name,C_Price,C_Type from Cart where C_UserId =" + Main.UserID + "AND C_Paid = 0");
            // We have calculated the total amount of the Food Item that has been order and then I have displayed it in the label 
            lab_SubTotal.Text = SQL.ScalarQuery("Select SUM(C_Price) from Cart where C_userId = " + Main.UserID + " AND C_PAid = 0");
        }

        // Proceed To Payment Button 
        private void button2_Click(object sender, EventArgs e)
        {
            //If  I have intialize the payment mode with CASH if the payment mode is card it will be over write in next if block
            String PaymentMethod = "CASH";
            if (rb_CARD.Checked == true && txt_CardNo.Text == "")
            {
                // Here Payment Mode is over written
                PaymentMethod = "CARD";
                MessageBox.Show("Please Enter Card Details", "Warnings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Address.Text == "")
            {
                MessageBox.Show("Please Enter Address ", "Warnings", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (dgv_FoodList.RowCount <= 0)
            {
                MessageBox.Show("Please Add Item In Cart First", "Warnings", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                // Gets the User confirmation to make a payment
                DialogResult YorN = MessageBox.Show("Are You Sure To Confirm Payment", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // if it is A yes then the below function will be executed 
                if (YorN == DialogResult.Yes)
                {
                    //First The payment method is writen to every ordered Item
                    SQL.NonScalarQuery("Update Cart Set C_PaymentMethod = '" + PaymentMethod + "' Where C_Paid = 0 AND C_UserID =" + Main.UserID + "");
                    // I have created a feild in the cart table namely C_Paid it can save only two values 1 or 0
                    // If it is zero it means the order is places but the payment is pending 
                    // Here i have updated the C_paid to 1 as the payment is confirmed 
                    SQL.NonScalarQuery("Update Cart Set C_Paid = 1,C_Status = 'Confirmed' Where  C_UserID =" + Main.UserID + "");
                    // A message for success 
                    MessageBox.Show("You Order Will Be Delivered Shortly ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// A simple event is called here 
        /// when ever a user change the check in cash radio button this event will be fired 
        /// if the card is select a textbox to enter card details will appear else nothing will show 
        /// defaut value is cash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_Cash_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_CARD.Checked==true)
            {
                pnl_CardDetails.Visible = true;
                txt_CardNo.Visible = true;
            }
            else
            {
                pnl_CardDetails.Visible = false;
                txt_CardNo.Visible = false;
            }
        }
    }
}
