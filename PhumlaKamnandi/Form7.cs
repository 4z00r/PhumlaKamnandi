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
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookingID = Convert.ToInt32(bookingIDBox.Text);
            int roomID = Convert.ToInt32(RoomIDBox.Text);
            DateTime checkIn = CheckInDate.Value;
            DateTime checkOut = CheckOutDate.Value;
            int price = Convert.ToInt32(priceBox.Text);

            // Find the booking to update
            BookingController bookingController = new BookingController();
            Booking booking = bookingController.Find(bookingID);

            if (booking != null)
            {
                // Update the booking details
                booking.Room.RoomID = roomID;
                booking.Dates = new Period(checkIn, checkOut);
                booking.Pricing.Total = price;

                // Save changes to the database
                bookingController.DataMaintenance(booking, DB.DBOperation.Edit);
                bookingController.FinalizeChanges(booking);

                MessageBox.Show("Booking updated successfully.");
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
            RoomIDBox.Text = booking.Room.RoomID.ToString();
            CheckInDate.Value = booking.Dates.CheckIn;
            CheckOutDate.Value = booking.Dates.CheckOut;
            priceBox.Text = booking.Pricing.Total.ToString();

           
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
            RoomIDBox.Clear();
            CheckInDate.Value = DateTime.Today;
            CheckOutDate.Value = DateTime.Today;
            priceBox.Clear();
        }
    }

}
