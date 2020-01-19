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
    public partial class ChefRequestUpdater : Form
    {
        public ChefRequestUpdater()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChefRequestUpdater_Load(object sender, EventArgs e)
        {

        }

        private void btn_UpdateRequest_Click(object sender, EventArgs e)
        {
            if (txt_DataGridViewIndex.Text == "")
            {
                MessageBox.Show("Please Select A User First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String Status = "APPROVED";
                if (rb_Reject.Checked == true)
                {
                    Status = "REJECTED";
                }
                else SQL.NonScalarQuery("Update Login Set L_Role =2 where L_Id = " + int.Parse(txt_UserID.Text) + "");
                SQL.NonScalarQuery("Update ChefRequest set CR_Status = '" + Status + "' where CR_ID =" + int.Parse(txt_DataGridViewIndex.Text) + " ");
                MessageBox.Show("Role Has Been Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ChefRequestUpdater_Activated(object sender, EventArgs e)
        {
            Main.fillDgv(dgv_ChefRequest, "select CR_Id,CR_UserID,CR_Username,CR_Application from ChefRequest Where CR_Status='PENDING'");
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
                    txt_DataGridViewIndex.Text = selectedrow.Cells["CR_ID"].Value.ToString();
                    txt_Username.Text = selectedrow.Cells["CR_Username"].Value.ToString();
                    txt_Application.Text = selectedrow.Cells["CR_Application"].Value.ToString();
                    txt_UserID.Text = selectedrow.Cells["CR_UserId"].Value.ToString();
                }
                index = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
