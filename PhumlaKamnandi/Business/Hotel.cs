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

        private BookingController bookingController;
        private GuestController guestController;
        private RoomController roomController; 

        private int numRooms;
        private List<Room> rooms;


        public Hotel(int ID, int numRooms)
        {
            this.hotelID = ID;
            this.numRooms = numRooms;
            //rooms = new List<Room>(numRooms);
        
            bookingController = new BookingController();
            guestController = new GuestController();
            roomController = new RoomController();
        }

        #region Functional operations
        public Booking CheckAvailability(int numOccupants, DateTime checkInDate, DateTime checkOutDate)
        {
            //error (if wrong input, show msg and return null)
                //return null;
            //checking

            Period period = new Period(checkInDate, checkOutDate);
           

            Room freeRoom = roomController.FindRoomByFreePeriod(
                bookingController.AllBookings,
                roomController.AllRooms,
                period);

            Booking newBooking = new Booking(
             100,
             freeRoom,
             period,
             new Price(period));

            return newBooking;
        }
        #endregion
    }
}
