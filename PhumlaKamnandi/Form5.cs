using PhumlaKamnandi.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandi
{
    // need to still work on summary - form to show summary of booking
    public partial class Form5 : Form
    {
        public Hotel hotel;
        public BookingController bookingController;
        private Guest guest; 
        
        public Form5(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
        }
        private void setUpListView()
        {
            ListViewItem bookingDetails;
            Booking b; 
            bookingListView.Clear();

            bookingListView.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(1, "RoomID", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(2, "CheckIn", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(3, "CheckOut", 120, HorizontalAlignment.Left);

            
            //foreach(Booking)
            bookingListView.Refresh();
            bookingListView.GridLines = true;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
        }
    }
}
