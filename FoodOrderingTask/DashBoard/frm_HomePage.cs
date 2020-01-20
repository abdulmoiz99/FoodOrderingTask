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
    public partial class frm_HomePage : Form
    {
        public frm_HomePage()
        {
            InitializeComponent();
          
        }

        private void frm_HomePage_Load(object sender, EventArgs e)
        {
            String Username = SQL.ScalarQuery("Select L_Username from login where L_Id = " + Main.UserID + "");
            lab_Username.Text =  Username.ToUpper();
            String Role = SQL.ScalarQuery("Select L_Role from Login Where L_Id =" + Main.UserID + "");
            if (Role == "1")
            {
                lab_Role.Text = "Customer";
            }
            else lab_Role.Text = "Chef";
        }
    }
}
