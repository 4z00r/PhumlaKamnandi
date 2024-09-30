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

    public class GuestController
    {
        #region Data Members
        GuestDB guestDB;
        Collection<Guest> guests;
        #endregion

        #region Properties
        public Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }
        #endregion

        #region Constructor
        public GuestController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            guestDB = new GuestDB();
            guests = guestDB.AllGuests;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Guest aBook, DB.DBOperation op)
        {
            //perform a given database operation to the dataset in meory; 
            switch (op)
            {
                case DB.DBOperation.Add:
                    guestDB.DataSetChange(aBook, op);
                    guests.Add(aBook);
                    break;
                case DB.DBOperation.Edit:
                    guestDB.DataSetChange(aBook, op);
                    int index = FindIndex(aBook);
                    guests[index] = aBook;
                    break;
                case DB.DBOperation.Delete:
                    guestDB.DataSetChange(aBook, op);
                    guests.Remove(aBook);
                    break;
            }

        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Guest Guest)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return guestDB.UpdateDataSource(Guest);
        }
        #endregion


        #region Search Methods
        public Collection<Guest> FindByRoom(Collection<Guest> Guests, Room room)
        {
            Collection<Guest> found = new Collection<Guest>();
            foreach (Guest Guest in Guests)
            {
                //if (Guest.Room.RoomID == room.RoomID)
                //{
                  //  found.Add(Guest);
                //}

                // use booking list; nested for loop to go through bookings
            }
            return found;
        }

        public Guest Find(int ID)
        {
            int index = 0;
            bool found = (guests[index].GuestID == ID);
            int count = guests.Count;

            while (!found && index < guests.Count - 1)
            {
                found = guests[index].GuestID == ID;
                index++;

            }
            return guests[index];
        }

        public int FindIndex(Guest book)
        {
            int counter = 0;
            bool found = false;
            found = (book.GuestID == guests[counter].GuestID);
            while (!found && counter < guests.Count - 1)
            {
                counter++;
                found = (book.GuestID == guests[counter].GuestID);
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

