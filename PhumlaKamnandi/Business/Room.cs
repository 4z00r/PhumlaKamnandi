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
        private int numOfOccupants;
        private bool availability;

        public Room(int ID, int numOfOccupants)
        {
            this.roomID = ID;
            this.numOfOccupants = numOfOccupants;
            if (numOfOccupants > 0)
            {
                availability = false;
            }
            else
            {
                availability = true;
            }

        }

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        public int NumOfOccupants
        {
            get { return numOfOccupants; }
            set {  numOfOccupants = value; }
        }
        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }

    }
}
