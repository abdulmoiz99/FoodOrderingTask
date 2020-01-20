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
    public partial class frm_Main : Form
    {
        /// <summary>
        /// This is the main form and it is launch soon after the login is successfull
        /// </summary>
        public frm_Main()
        {
            InitializeComponent();
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Home.Height;
            SidePanel.Top = btn_Home.Top;
            var frm = new frm_HomePage();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Menu.Height;
            SidePanel.Top = btn_Menu.Top;
            // WE have use a Mdi Parent Method to load the form 
            // if you go and look at the form you will see a gray area this area is called Mdi Container 
            //When Ever a new form is loaded it will be launched in that gray area 
            var frm = new frm_MENU();
            frm.MdiParent = this; 
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }
       
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Payment.Height;
            SidePanel.Top = btn_Payment.Top;
        }

      
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            btn_Home_Click( sender,  e);
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Payment_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Payment.Height;
            SidePanel.Top = btn_Payment.Top;
            // WE have use a Mdi Parent Method to load the form 
            // if you go and look at the form you will see a gray area this area is called Mdi Container 
            //When Ever a new form is loaded it will be launched in that gray area 
            var frm = new frm_Payments();
            frm.MdiParent = this; 
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_Vicitniry_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Vicitniry.Height;
            SidePanel.Top = btn_Vicitniry.Top;
            // WE have use a Mdi Parent Method to load the form 
            // if you go and look at the form you will see a gray area this area is called Mdi Container 
            //When Ever a new form is loaded it will be launched in that gray area 
            var frm = new frm_Vicinity();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn_UserSettings_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_UserSettings.Height;
            SidePanel.Top = btn_UserSettings.Top;
            // WE have use a Mdi Parent Method to load the form 
            // if you go and look at the form you will see a gray area this area is called Mdi Container 
            //When Ever a new form is loaded it will be launched in that gray area 
            var frm = new frm_UpdateUserProfile();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btn__Click(object sender, EventArgs e)
        {

        }

        private void btn_Chef_Click(object sender, EventArgs e)
        {
           // Main.UserID = 2;
            if(Main.CheckCheffApplication(Main.UserID)==true)
            {
                MessageBox.Show("You Have Already Apply For Cheff Role", "Application Submitted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(Main.IsChef(Main.UserID)==true)
            {
                var frm = new frm_UpdateMenu();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                SidePanel.Height = btn_Chef.Height;
                SidePanel.Top = btn_Chef.Top;
                // WE have use a Mdi Parent Method to load the form 
                // if you go and look at the form you will see a gray area this area is called Mdi Container 
                //When Ever a new form is loaded it will be launched in that gray area 
                var frm = new frm_ChefRequest ();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void btn_ChefRequest_Click(object sender, EventArgs e)
        {
            if(Main.UserName=="admin")
            {
                var frm = new frm_ChefRequestUpdater();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            var frm = new frm_UpdateUserProfile();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
