using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FoodOrderingTask.DashBoard
{
    public partial class frm_UpdateMenu : Form
    {
        int mode;
        public frm_UpdateMenu()
        {
            InitializeComponent();
        }
        private void AllClear()
        {
            txt_ItemName.Text = String.Empty;
            txt_Price.Text = String.Empty;
        }
        private void btn_ADD_Click(object sender, EventArgs e)
        {
            var OFD = new OpenFileDialog();
            OFD.Filter = "Bitmaps|*.bmp|jpeps|*.jpg";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                //    pb_FoodImage.Image = Image.FromFile(OFD.FileName);
                pb_FoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            mode = 1;
            AllClear();
            btn_edit.Enabled = false;
            btn_New.Enabled = false;
            btn_cancel.Enabled = true;
            btn_Save.Enabled = true;
            txt_ItemName.Enabled = true;
            txt_Price.Enabled = true;
            dgv_FoodList.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            mode = 2;
            btn_edit.Enabled = false;
            btn_New.Enabled = false;
            btn_Save.Enabled = true;
            btn_cancel.Enabled = true;
            txt_ItemName.Enabled = true;
            txt_Price.Enabled = true;
            dgv_FoodList.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            float Price;
            String Type = "ASIAN";
            if (rb_Eastern.Checked == true)
            {
                Type = "EASTERN";
            }
            else if (rb_Western.Checked == true)
            {
                Type = "WESTERN";
            }
            if (txt_ItemName.Text == "")
            {
                MessageBox.Show("Please Enter Item Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Price.Text == "")
            {
                MessageBox.Show("Please Enter Price ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_Price.Text, out Price))
            {
                MessageBox.Show("Price Is Invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mode == 1)
            {
                
                DialogResult YesOrNo = MessageBox.Show("Are you sure To INSERT the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (YesOrNo == DialogResult.Yes)
                {
                    if (SQL.Con.State == ConnectionState.Open)
                    {
                        SQL.Con.Close();
                    }
                    SQL.Con.Open();
                    String Query = @"Insert Into Menu  (            M_Name         ,M_Price                ,M_Type         ,M_Image,M_Active,M_ChefName) values 
                                                           ('" + txt_ItemName.Text + "','" + txt_Price.Text + "','" + Type + "',@pic    ,1,'" + Main.UserName + "' )";

                    SqlCommand cmd = new SqlCommand(Query, SQL.Con);
                    //   SQL.Con.cmd.Connection = cc.con;
                    var ms2 = new MemoryStream();
                    pb_FoodImage.Image.Save(ms2, pb_FoodImage.Image.RawFormat);
                    byte[] data2 = ms2.GetBuffer();
                    SqlParameter p2 = new SqlParameter("@pic", SqlDbType.Image);
                    p2.Value = data2;
                    cmd.Parameters.Add(p2);
                    cmd.ExecuteNonQuery();
                    AllClear();
                    frm_UpdateMenu_Load(sender, e);
                    btn_cancel_Click(sender, e);
                    MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Main.fillDgv(dgv_FoodList, "select M_ID,M_Name,M_Price,M_Type,M_Image,M_ChefName from MEnu");
                }
            }


            else if (mode == 2)
            {
                //DialogResult YesOrNo = MessageBox.Show("Are you sure To UPDATE the current Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (YesOrNo == DialogResult.Yes)
                //{
                //    SQL.NonScalarQuery("update CustomerMaster set CustomerName='" + txt_CustomerName.Text + "',CustomerFatherName='" + txt_CustomerFName.Text + "',CustomerCNIC='" + txt_CustomerCNIC.Text + "',CustomerContactNo='" + txt_CustomerContactNo.Text + "',CustomerAddress='" + txt_CustomerContactNo.Text + "',CustomerCityid=" + cmb_City.SelectedValue + ",CustomerActive=" + active + " where CustomerId=" + int.Parse(txt_DataGridViewIndex.Text) + "");
                //    AllClear();
                //    frm_AddCustomer_Load(sender, e);
                //    btn_cancel_Click(sender, e);
                //    MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //}
                //else MessageBox.Show("You Donot Have The Rights To Update Data", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mode = 0;
            btn_edit.Enabled = true;
            btn_New.Enabled = true;
            btn_cancel.Enabled = false;
            btn_Save.Enabled = false;
            txt_ItemName.Enabled = false;
            txt_Price.Enabled = false;
            dgv_FoodList.Enabled = true;
        }

        private void frm_UpdateMenu_Load(object sender, EventArgs e)
        {
            dgv_FoodList.RowTemplate.Height = 150;
            //try
            //{
            //    String ExpenseSetup = SQL.ScalarQuery("SELECT COUNT(CName) FROM  CityMaster WHERE CActive =1 and CompanyID=" + Main.CompanyID + "");
            //    if (ExpenseSetup == "0")
            //    {
            //        MessageBox.Show("No City Is Found Please Enter City Details ", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        var frm = new frm_CitySetup();
            //        frm.ShowDialog();
            //        this.Close();
            //    }
            //    else
            //    {
            //        Main.fillCombo(cmb_City, "CityMaster", "CName", "CID", "CActive=1");
            //    }
            //}
            //catch (Exception)
            //{
            //}
        }

        private void frm_UpdateMenu_Activated(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_FoodList, "select M_ID,M_Name,M_Price,M_Type,M_Image,M_ChefName from MEnu");

        }

        private void dgv_FoodList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{

            int index = e.RowIndex;
            if (index > -1)
            {
                txt_DataGridViewIndex.Text = index.ToString();
                DataGridViewRow selectedrow = dgv_FoodList.Rows[index];
                txt_DataGridViewIndex.Text = selectedrow.Cells["M_ID"].Value.ToString();
                txt_ItemName.Text = selectedrow.Cells["M_Name"].Value.ToString();
                txt_Price.Text = selectedrow.Cells["M_Price"].Value.ToString();
                //  pb_FoodImage.Image =Convert.Tma selectedrow.Cells["M_Image"].Value.ToString();

            }
            index = 0;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pb_FoodImage.Image = new Bitmap(open.FileName);
                // image file path  
                //   textBox1.Text = open.FileName;
                pb_FoodImage.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
    }
}
