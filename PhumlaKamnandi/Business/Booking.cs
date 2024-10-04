using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        private Guest guest; 

        public Booking(Room r, Guest g) 
        {
            this.room = r;
            this.guest = g;
        }
        public Booking(int id, Room r, Period dates, Price pricing, Guest guest)
        {
            this.bookingID = id;
            this.room = r;
            this.dates = dates;
            this.price = pricing;
            this.guest = guest; 
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
        public Guest Guest
        {
            get { return guest; }
            set { guest = value; }
        }

        public override string ToString()
        {
            return $"Booking: {Room.RoomID} {this.BookingID} ";
        }

    }
}
