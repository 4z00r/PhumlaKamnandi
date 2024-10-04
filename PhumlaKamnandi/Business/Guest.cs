using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class Guest : Person
    {
        private int guestID;
        public int credit;
        private Collection<Booking> bookings;

        public int GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }

        public Guest(int ID)
        {
            this.guestID = ID;
        }
        public Guest(int ID, string pName, string telephone, string address, Collection<Booking> bookings) : base(pName, telephone ,address)
        {
            this.guestID = ID;
            this.bookings = bookings;
        }

        public Guest(string pName, string telephone, string address) : base(pName, telephone, address) // double check if this constructor is correct
        {
            guestID = -1;
            credit = 0;
        }

    }
}
