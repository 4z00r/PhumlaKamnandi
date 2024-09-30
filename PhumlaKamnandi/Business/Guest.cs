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

        public int GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }

        public Guest(int ID, string pName, string address, Collection<Booking> bookings) : base(pName, address)
        {
            this.guestID = ID;
            this.bookings = bookings;
        }


    }
}
