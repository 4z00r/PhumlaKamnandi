using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private Booking newBooking;
        private Guest loggedInGuest;


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
        public bool CheckAvailability(int numOccupants, DateTime checkInDate, DateTime checkOutDate)
        {
            //error (if wrong input, show msg and return null) !!!
                //return null;
            //checking

            Period period = new Period(checkInDate, checkOutDate);
           

            Room freeRoom = roomController.FindRoomByFreePeriod(
                bookingController.AllBookings,
                roomController.AllRooms,
                period);

            if (freeRoom == null)
            {
                return false;
            }else
            {
                newBooking = new Booking(
                    -1,
                    freeRoom,
                    period,
                    new Price(period));

                return true;
            }

            
        }

        public bool CheckGuest(int ID , string Name)
        {
            Guest guest = guestController.Find(ID);

            if (guest == null)
            {
                return false;
            }

            if (guest.Name == Name)
            {
                loggedInGuest = guest;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddGuest(string name, string telephone, string address)
        {



            Guest newGuest = new Guest(name, telephone, address);
            guestController.DataMaintenance(newGuest, Database.DB.DBOperation.Add);
            if (guestController.FinalizeChanges(guestController.AllGuests[guestController.AllGuests.Count-1]))
            {
                MessageBox.Show("Registered Successfully");
            }
            else
            {
                MessageBox.Show("Failed registering new guest");
            }
        }
        #endregion
    }
}