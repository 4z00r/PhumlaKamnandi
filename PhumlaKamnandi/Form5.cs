using PhumlaKamnandi.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public GuestController guestController;
        private Guest guest; 
        
        public Form5(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
            bookingController = new BookingController();
            //hotel.
             
        }
        private void setUpListView()
        {
            //ListViewItem bookingDetails;
            //Booking b; 
            //bookingListView.Clear();

            //bookingListView.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(1, "RoomID", 120, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(2, "CheckIn", 120, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(3, "CheckOut", 120, HorizontalAlignment.Left);

            
            ////foreach(Booking)
            //bookingListView.Refresh();



            bookingListView.GridLines = true;
            bookingListView.View = View.Details;
            bookingListView.FullRowSelect = true;
            bookingListView.GridLines = true;

            bookingListView.Columns.Add("Booking ID", 100, HorizontalAlignment.Left);
            bookingListView.Columns.Add("Room ID", 100, HorizontalAlignment.Left);
            bookingListView.Columns.Add("Check-In", 150, HorizontalAlignment.Left);
            bookingListView.Columns.Add("Check-Out", 150, HorizontalAlignment.Left);
            bookingListView.Columns.Add("Price", 100, HorizontalAlignment.Left);
        }

        private void loadData()
        {
            // i don't know how to display just a singular guest's bookings - as a guest isn't associated with a booking?
            // did it for all bookings *for now* 
            Collection<Booking> allBookings = bookingController.AllBookings;
            int guestID = Convert.ToInt32(textBox7.Text);
            guest = guestController.Find(guestID);
            if (guest != null)
            {
                Collection<Booking> guestBookings = bookingController.FindByGuest(allBookings, guest);
                foreach (Booking booking in guestBookings)
                {
                    ListViewItem item = new ListViewItem(booking.BookingID.ToString());
                    item.SubItems.Add(booking.Room.RoomID.ToString());
                    item.SubItems.Add(booking.Dates.CheckIn.ToShortDateString());
                    item.SubItems.Add(booking.Dates.CheckOut.ToShortDateString());
                    item.SubItems.Add(booking.Pricing.Total.ToString("C"));

                    bookingListView.Items.Add(item);
                }
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            setUpListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData(); 
        }
    }
}
