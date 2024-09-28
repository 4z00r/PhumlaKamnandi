using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class Guest : Person
    {
        private int customerID;
        private Booking booking;

        public Guest(int ID, Booking booking)
        {
            this.customerID = ID;
            //this.booking = booking; 
        }

        public Booking makeBooking(int id, Room r, Period dates)
        {
            booking = new Booking(id, r, dates);
            return booking;
        }


    }
}
