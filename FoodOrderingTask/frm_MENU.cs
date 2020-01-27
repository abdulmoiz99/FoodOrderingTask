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
    public partial class frm_MENU : Form
    {
        string Type;

        public frm_MENU()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Simly Doing UI enhancements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_MENU_Activated(object sender, EventArgs e)
        {
            // A simple code to re style the datagrid view and to provide better UI experience 
            dgv_FoodList.BorderStyle = BorderStyle.None;
            dgv_FoodList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(143, 196, 61);
            dgv_FoodList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_FoodList.RowsDefaultCellStyle.BackColor = Color.FromArgb(196, 223, 156);
            dgv_FoodList.DefaultCellStyle.SelectionBackColor = Color.FromArgb(202, 73, 95);
            dgv_FoodList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_FoodList.BackgroundColor = Color.White;
            dgv_FoodList.EnableHeadersVisualStyles = false;
            dgv_FoodList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_FoodList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(99, 99, 99);
            dgv_FoodList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            foreach (DataGridViewRow row in dgv_FoodList.Rows)
            {
                //row.Height = 40;
            }
            dgv_FoodList.RowTemplate.Height = 150;


            // End of Code 
        }
        /// <summary>
        /// This event occured when ever a user type or erase something in the search bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            if (rb_Asian.Checked == true)
            {
                Main.fillDgv(dgv_FoodList, "select M_Name,M_Price,M_Type,M_Image,M_ChefAddress,M_ChefName from Menu where M_Type= 'ASIAN' and CAST(M_Name as varchar) like '%" + txt_Find.Text + "%'");

            }
            else if (rb_Eastern.Checked == true)
            {
                Main.fillDgv(dgv_FoodList, "select M_Name,M_Price,M_Type,M_Image,M_ChefAddress,M_ChefName from Menu where M_Type= 'EASTERN' and CAST(M_Name as varchar) like '%" + txt_Find.Text + "%'");

            }
            else if (rb_Western.Checked == true)
            {
                Main.fillDgv(dgv_FoodList, "select M_Name,M_Price,M_Type,M_Image,M_ChefAddress,M_ChefName from Menu where M_Type= 'WESTERN' and CAST(M_Name as varchar) like '%" + txt_Find.Text + "%'");

            }
        }

        private void rb_Western_CheckedChanged(object sender, EventArgs e)
        {
            txt_Find_TextChanged(sender, e);
        }

        private void rb_Eastern_CheckedChanged(object sender, EventArgs e)
        {
            txt_Find_TextChanged(sender, e);

        }

        private void rb_Asian_CheckedChanged(object sender, EventArgs e)
        {
            txt_Find_TextChanged(sender, e);

        }


        private void frm_MENU_Load(object sender, EventArgs e)
        {
            txt_Find_TextChanged(sender, e);
            dgv_FoodList.RowTemplate.Height = 150;

        }

        private void dgv_FoodList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            if (Type == "")
            {
                MessageBox.Show("Please Select An Item First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    SQL.NonScalarQuery(@"Insert Into Cart(C_userID           ,C_Name                 ,C_Price,C_Type                ,C_Paid,C_Status,C_Seller)
                                               values(" + Main.UserID + ",'" + lab_Name.Text + "'," + float.Parse(lab_Price.Text) + ",'" + Type + "',0,'Placed','" + txt_ChefName.Text + "')");
                    MessageBox.Show("Item Successfully Added To Cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Please Select an Item");
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_ChefName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_FoodList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            lab_Name1.Visible = true;
            lab_Name.Visible = true;
            lab_Price.Visible = true;
            lab_Price1.Visible = true;

            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = dgv_FoodList.Rows[index];
                if (index > -1)
                {
                    lab_Name.Text = selectedrow.Cells["M_Name"].Value.ToString();
                    lab_Price.Text = selectedrow.Cells["M_Price"].Value.ToString();
                    Type = selectedrow.Cells["m_type"].Value.ToString();
                    txt_ChefName.Text = SQL.ScalarQuery("SELECT M_ChefName from Menu where M_Name = '" + lab_Name.Text + "'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Find Panel");
            }
        }
    }
}
