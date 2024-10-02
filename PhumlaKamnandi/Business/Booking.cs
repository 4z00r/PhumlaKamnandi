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
        private Price price;

        public Booking(Room r) 
        {
            this.room = r;
        }
        public Booking(int id, Room r, Period dates, Price pricing)
        {
            this.bookingID = id;
            this.room = r;
            this.dates = dates;
            this.price = pricing;

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
        public Price Pricing
        {
            get { return price; }
            set { price = value; }
        }

    }
}
