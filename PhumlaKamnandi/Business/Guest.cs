using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class Guest : Person
    {
        private int guestID;
        private Collection<Booking> bookings;

        public Guest(int ID, Collection<Booking> bookings)
        {
            this.guestID = ID;
            this.bookings = bookings;
        }


    }
}
