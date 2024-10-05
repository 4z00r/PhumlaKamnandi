using PhumlaKamnandi.Business;
using PhumlaKamnandi.Database;
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
    public partial class Form7 : Form
    {
        // form to change a booking
        Hotel hotel;
        Form1 form1;

        public Form7(Hotel hotel, Form1 form1)
        {
            InitializeComponent();

            this.hotel = hotel;
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookingID = Convert.ToInt32(bookingIDBox.Text);

            DateTime checkIn = CheckInDate.Value;
            DateTime checkOut = CheckOutDate.Value;

            // Find the booking to update
            BookingController bookingController = new BookingController();
            Booking booking = bookingController.Find(bookingID);
            Guest guest = booking.Guest;

            if (booking != null)
            {

                // Update the booking details
                hotel.LoggedInGuest = guest;
                bool available = hotel.CheckAvailability(checkIn, checkOut);
                hotel.NewBooking.BookingID = bookingID;

                if (available)
                {
                    //bookingController.DataMaintenance(hotel.NewBooking, DB.DBOperation.Edit);
                    //bookingController.FinalizeChanges(booking);
                    hotel.EditBooking();
                    MessageBox.Show("Booking updated successfully.");
                }
                else
                {
                    MessageBox.Show("Booking not found.");
                }
                
            }
            else
            {
                MessageBox.Show("Booking not found.");
            }
        }

        private void bookingIDBox_TextChanged(object sender, EventArgs e)
        {

        }
    
        private void LoadBookingData(Booking booking)
        {
            //bookingIDBox.Text;
            bookingIDBox.Text = booking.BookingID.ToString();
            CheckInDate.Value = booking.Dates.CheckIn;
            CheckOutDate.Value = booking.Dates.CheckOut;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bookingID = Convert.ToInt32(bookingIDBox.Text);

            BookingController bookingController = new BookingController();
            Booking booking = bookingController.Find(bookingID);

            if (booking != null)
            {
               
                var confirmResult = MessageBox.Show("Are you sure you want to cancel this booking?",
                                                     "Confirm Cancel",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bookingController.DataMaintenance(booking, DB.DBOperation.Delete);
                    bookingController.FinalizeChanges(booking);

                    MessageBox.Show("Booking has been successfully cancelled.");
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Booking not found.");
            }
        }

        private void ClearForm()
        {
            // Clear all form fields after cancellation
            bookingIDBox.Clear();
            CheckInDate.Value = DateTime.Today;
            CheckOutDate.Value = DateTime.Today;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }

}
