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
        private Price newPrice;
        public Booking NewBooking
        {
            get { return newBooking; }
        }

        public Guest LoggedInGuest
        {
            get { return loggedInGuest; }
            set { loggedInGuest = value; }
        }

        public Price NewPrice
        {
            get { return newPrice; }
        }
        public BookingController BookingController
        {
            get { return bookingController; }
        } 


        public Hotel(int ID, int numRooms)
        {
            this.hotelID = ID;
            this.numRooms = numRooms;
            //rooms = new List<Room>(numRooms);
        
            bookingController = new BookingController();
            guestController = new GuestController();
            roomController = new RoomController();
        }

        public void ClearAll()
        {
            newBooking = null;
            loggedInGuest = null;
            newPrice = null;
        }

        #region Functional operations
        public bool CheckAvailability(DateTime checkInDate, DateTime checkOutDate)
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
                newPrice = new Price(period);
                newBooking = new Booking(
                    -1,
                    freeRoom,
                    period,
                    newPrice,
                    loggedInGuest);

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
                newBooking.Guest = guest;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Guest AddGuest(string name, string telephone, string address)
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

            return newGuest;
        }

        public void AddBooking()
        {

            NewBooking.Guest = loggedInGuest;

            bookingController.DataMaintenance(NewBooking, Database.DB.DBOperation.Add);
            bookingController.FinalizeChanges(bookingController.AllBookings[bookingController.AllBookings.Count-1]);

        }

        public void CancelBooking()
        {
            bookingController.DataMaintenance(NewBooking, Database.DB.DBOperation.Delete);
            bookingController.FinalizeChanges(NewBooking); 
        }
        public void EditBooking()
        {
            bookingController.DataMaintenance(NewBooking, Database.DB.DBOperation.Edit);
            bookingController.FinalizeChanges(NewBooking);
        }
        #endregion
    }
}