using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    /*
    * Class to represent rooms in a hotel
    */
    public class Room
    {
        private int roomID;
        private Price pricing;
        private bool availability;

        public Room(int ID, Price p, bool availability)
        {
            this.roomID = ID;
            this.pricing = p;
            this.availability = availability;
        }

        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }

        public Price Pricing
        {
            get { return pricing; }
            set { pricing = value; }
        }

    }
}
