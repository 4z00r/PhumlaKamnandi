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

        public Room(int ID)
        {
            this.roomID = ID;
            

        }

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        

    }
}
