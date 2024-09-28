using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    /*
     * Class to store booking info
     */
    public class Booking
    {
        private int bookingID;
        private Room room;
        private Period dates;

        public Booking(int id, Room r, Period dates)
        {
            this.bookingID = id;
            this.room = r;
            this.dates = dates;

            //System.DateTime.Compare()
        }

        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        public Room Room
        {
            get { return room; }
            set { room = value; }
        }
        public Period Dates
        {
            get { return dates; }
            set {  dates = value; }
        }
        public int getTotalPrice()
        {
            int days = dates.numDays();
            int total = room.Pricing.Cost * days;
            return total;
        }


    }
}
