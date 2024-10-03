using PhumlaKamnandi.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandi
{
    public partial class Form6 : Form
    {

        private Hotel hotel;

        public class BookingDetail
        {
            public DateTime Date { get; set; }
            public int RoomsBooked { get; set; }

            public BookingDetail(DateTime date, int roomsBooked)
            {
                Date = date;
                RoomsBooked = roomsBooked;
            }


        }
        private List<BookingDetail> bookingDetails;


        public Form6(Business.Hotel hotel)
        {
            InitializeComponent();

            this.hotel = hotel;

            Date1.Value = new DateTime(DateTime.Now.Year, 12, 1);
            Date2.Value = new DateTime(DateTime.Now.Year, 12, 31);

            bookingDetails = new List<BookingDetail>();

            
            for (DateTime date = Date1.Value; date <= Date2.Value; date = date.AddDays(1))
            {
                bookingDetails.Add(new BookingDetail(date, 0));
            }


            LoadValues();

            SeasonBox.Items.Add("Low Season 1st - 7th");
            SeasonBox.Items.Add("Mid Season (8th - 15");
            SeasonBox.Items.Add("High Season (16th - 31st");
            SeasonBox.SelectedIndex = 0;
        }

        private void LoadValues()
        {
            Business.BookingController controller = hotel.BookingController;
            foreach (Business.Booking book in controller.AllBookings)
            {

                List<DateTime> bDates = book.Dates.Dates;

                foreach (DateTime date in bDates)
                {
                    BookingDetail result = bookingDetails.FirstOrDefault(b => b.Date.Date == date.Date);
                    result.RoomsBooked = result.RoomsBooked + 1;
                }

            }
        }
        
        
        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (Date1.Value.Month != 12)
            {
                MessageBox.Show("Please select a date in December.");
                Date1.Value = new DateTime(DateTime.Now.Year, 12, 1); // Default to Dec 1
            }
            else if (Date1.Value > Date2.Value)
            {
                MessageBox.Show("Start date must be before or equal to the end date.");
                Date2.Value = Date1.Value; 
            }
        }
        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            // Only allow dates in December
            if (Date2.Value.Month != 12)
            {
                MessageBox.Show("Please select a date in December.");
                Date2.Value = new DateTime(DateTime.Now.Year, 12, 31); // Default to Dec 31
            }
            else if (Date2.Value < Date1.Value)
            {
                MessageBox.Show("End date must be after the start date.");
                Date2.Value = Date1.Value; 
            }
        }
        private void Date1_ValueChanged(object sender, EventArgs e)
        {

        }
        private int GetRoomsBookedForDate(DateTime date)
        {
            var booking = bookingDetails.FirstOrDefault(b => b.Date.Date == date);

            return booking != null ? booking.RoomsBooked : 0;
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            
                DateTime startDate = Date1.Value.Date;
                DateTime endDate = Date2.Value.Date;

                ReportTable.Items.Clear();

                ReportTable.Items.Add("Date\t\tRooms Booked\tRooms Not Booked\tOccupancy Level (%)");

                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    int roomsBooked = GetRoomsBookedForDate(date);

                    int roomsNotBooked = 5 - roomsBooked;

                    int occupancyLevel = roomsBooked * 100 / 5;

                    string row = $"{date.ToShortDateString()}\t\t{roomsBooked}\t\t{roomsNotBooked}\t\t{occupancyLevel}%";
                    ReportTable.Items.Add(row);
                }
            
        }

        private void Generate1_Click(object sender, EventArgs e)
        {


            ReportTable1.Items.Clear();

            ReportTable1.Items.Add("Date\t\tRooms Booked\tRooms Not Booked\tOccupancy Level (%)");

            DateTime seasonStart, seasonEnd;

            switch (SeasonBox.SelectedIndex)
            {
                case 0: //Low Season
                    seasonStart = new DateTime(2024, 12, 1);
                    seasonEnd = new DateTime(2024, 12, 7);
                    break;
                case 1: //Mid Season
                    seasonStart = new DateTime(2024, 12, 8);
                    seasonEnd = new DateTime(2024, 12, 15);
                    break;
                case 2: // High Season
                    seasonStart = new DateTime(2024, 12, 16);
                    seasonEnd = new DateTime(2024, 12, 31);
                    break;
                default:
                    return;
            }

            for (DateTime date = seasonStart; date <= seasonEnd; date = date.AddDays(1))
            {
                int roomsBooked = GetRoomsBookedForDate(date);
                int roomsNotBooked = 5 - roomsBooked;
                int occupancyLevel = roomsBooked * 100 / 5;

                string row = $"{date.ToShortDateString()}\t\t{roomsBooked}\t\t{roomsNotBooked}\t\t{occupancyLevel}%";
                ReportTable1.Items.Add(row);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
