using PhumlaKamnandi.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{

    public class BookingController
    {
        #region Data Members
        BookingDB bookingDB;
        Collection<Booking> bookings;
        #endregion

        #region Properties
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        #region Constructor
        public BookingController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Booking aBook, DB.DBOperation op)
        {
            //perform a given database operation to the dataset in meory; 
            switch (op)
            {
                case DB.DBOperation.Add:
                    bookingDB.DataSetChange(aBook, op);
                    bookings.Add(aBook);
                    break;
                case DB.DBOperation.Edit:
                    bookingDB.DataSetChange(aBook, op);
                    int index = FindIndex(aBook);
                    bookings[index] = aBook;
                    break;
                case DB.DBOperation.Delete:
                    bookingDB.DataSetChange(aBook, op);
                    bookings.Remove(aBook);
                    break;
            }

        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Booking booking)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return bookingDB.UpdateDataSource(booking);
        }
        #endregion


        #region Search Methods
        public Collection<Booking> FindByRoom(Collection<Booking> bookings, Room room)
        {
            Collection<Booking> found = new Collection<Booking>();
            foreach (Booking booking in bookings)
            {
                if (booking.Room.RoomID == room.RoomID)
                {
                    found.Add(booking);
                }
            }
            return found;
        }

        public Booking Find(int ID)
        {
            int index = 0;
            bool found = (bookings[index].BookingID == ID);
            int count = bookings.Count;

            while (!found && index < bookings.Count - 1)
            {
                found = bookings[index].BookingID == ID;
                index++;

            }
            return bookings[index];
        }

        public int FindIndex(Booking book)
        {
            int counter = 0;
            bool found = false;
            found = (book.BookingID == bookings[counter].ID);
            while (!found && counter < bookings.Count - 1)
            {
                counter++;
                found = (book.BookingID == bookings[counter].BookingID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion



    }
}

