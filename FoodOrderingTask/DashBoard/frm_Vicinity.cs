using GMap.NET;
using GMap.NET.MapProviders;
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
    public partial class frm_Vicinity : Form
    {
        public frm_Vicinity()
        {
            InitializeComponent();
            string street = txt_street.Text;
            string city = txt_city.Text;
            string state = txt_state.Text;
            string zip = txt_zip.Text;
        //    try
        //    {
        //        StringBuilder queryaddress = new StringBuilder();
        //        queryaddress.Append("https://www.google.com/maps");

        //        if (street != string.Empty)
        //        {
        //            queryaddress.Append("Clementi, Singapore");
        //        }

        //        webBrowser1.Navigate(queryaddress.ToString());


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString(), "Error");
        //    }

        }

        private void frm_Vicinity_Load(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.MinZoom = 0;
            map.MaxZoom = 18;
            map.Zoom = 5;
          
        }

        private void Search_Data_Click(object sender, EventArgs e)
        {
            //{

        //        string zip = txt_zip.Text;
        //        try
        //        {
        //            StringBuilder queryaddress = new StringBuilder();
        //            queryaddress.Append("https://www.google.com/maps");

        //            if (zip != string.Empty)
        //            {
        //                queryaddress.Append(zip);
        //            }

        //            webBrowser1.Navigate(queryaddress.ToString());
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message.ToString(), "Error");
        //        }
        //    }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void gMapControl_Load(object sender, EventArgs e)
        {

        }
    }
}
