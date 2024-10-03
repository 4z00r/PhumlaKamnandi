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
    public partial class Form6 : Form
    {
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
        public Form6()
        {
            InitializeComponent();

            // Initialize the date pickers with default December values
            Date1.Value = new DateTime(DateTime.Now.Year, 12, 1);
            Date2.Value = new DateTime(DateTime.Now.Year, 12, 31);

            bookingDetails = new List<BookingDetail>
            {
                new BookingDetail(new DateTime(2024, 12, 24), 3),
                new BookingDetail(new DateTime(2024, 12, 25), 5),
                new BookingDetail(new DateTime(2024, 12, 26), 4),
                new BookingDetail(new DateTime(2024, 12, 27), 2)
            };

            SeasonBox.Items.Add("Low Season 1st - 7th");
            SeasonBox.Items.Add("Mid Season (8th - 15");
            SeasonBox.Items.Add("High Season (16th - 31st");

            // Set default value for ComboBox
            SeasonBox.SelectedIndex = 0;
        }
        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            // Only allow dates in December
            if (Date1.Value.Month != 12)
            {
                MessageBox.Show("Please select a date in December.");
                Date1.Value = new DateTime(DateTime.Now.Year, 12, 1); // Default to Dec 1
            }
            else if (Date1.Value > Date2.Value)
            {
                MessageBox.Show("Start date must be before or equal to the end date.");
                Date2.Value = Date1.Value; // Adjust end date to be equal to start date
            }
        }

        // Event handler for endDatePicker to restrict to December and after start date
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
                Date2.Value = Date1.Value; // Adjust end date to be equal to or after start date
            }
        }
        private void Date1_ValueChanged(object sender, EventArgs e)
        {

        }
        private int GetRoomsBookedForDate(DateTime date)
        {
            // Search the booking list for the given date
            var booking = bookingDetails.FirstOrDefault(b => b.Date.Date == date);

            // Return the number of rooms booked if found, otherwise return 0
            return booking != null ? booking.RoomsBooked : 0;
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            
                DateTime startDate = Date1.Value.Date;
                DateTime endDate = Date2.Value.Date;

                // Clear the previous report from the ListBox
                ReportTable.Items.Clear();

                // Add headers to the ListBox
                ReportTable.Items.Add("Date\t\tRooms Booked\tRooms Not Booked\tOccupancy Level (%)");

                // Loop through the date range
                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    // Find the number of rooms booked for that date (if available in the list)
                    int roomsBooked = GetRoomsBookedForDate(date);

                    // Calculate the number of rooms not booked (assuming there are 5 rooms)
                    int roomsNotBooked = 5 - roomsBooked;

                    // Calculate the occupancy level (number of rooms booked * 100%)
                    int occupancyLevel = roomsBooked * 100 / 5;

                    // Format the row and add it to the ListBox
                    string row = $"{date.ToShortDateString()}\t\t{roomsBooked}\t\t{roomsNotBooked}\t\t{occupancyLevel}%";
                    ReportTable.Items.Add(row);
                }
            
        }

        private void Generate1_Click(object sender, EventArgs e)
        {
            // Clear the list box for the new report
            ReportTable1.Items.Clear();

            // Add header row to ListBox
            ReportTable1.Items.Add("Date\t\tRooms Booked\tRooms Not Booked\tOccupancy Level (%)");

            // Determine the selected season and date range
            DateTime seasonStart, seasonEnd;

            switch (SeasonBox.SelectedIndex)
            {
                case 0: // Low Season
                    seasonStart = new DateTime(2024, 12, 1);
                    seasonEnd = new DateTime(2024, 12, 7);
                    break;
                case 1: // Mid Season
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

            // Generate the report based on the season date range
            for (DateTime date = seasonStart; date <= seasonEnd; date = date.AddDays(1))
            {
                int roomsBooked = GetRoomsBookedForDate(date);
                int roomsNotBooked = 5 - roomsBooked;
                int occupancyLevel = roomsBooked * 100 / 5;

                // Add each row to the ListBox
                string row = $"{date.ToShortDateString()}\t\t{roomsBooked}\t\t{roomsNotBooked}\t\t{occupancyLevel}%";
                ReportTable1.Items.Add(row);
            }
        }
    }
}
