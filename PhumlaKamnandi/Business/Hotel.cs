using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class Hotel
    {
        private int hotelID;
        private int numRooms;
        private List<Room> rooms;


        public Hotel(int ID, int numRooms)
        {
            this.hotelID = ID;
            this.numRooms = numRooms;
            rooms = new List<Room>(numRooms);
        }
    }
}
