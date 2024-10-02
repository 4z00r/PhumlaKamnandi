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

    public class RoomController
    {
        #region Data Members
        RoomDB roomDB;
        Collection<Room> Rooms;
        #endregion

        #region Properties
        public Collection<Room> AllRooms
        {
            get
            {
                return Rooms;
            }
        }
        #endregion

        #region Constructor
        public RoomController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            roomDB = new RoomDB();
            Rooms = roomDB.AllRooms;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Room aBook, DB.DBOperation op)
        {
            //perform a given database operation to the dataset in meory; 
            switch (op)
            {
                case DB.DBOperation.Add:
                    roomDB.DataSetChange(aBook, op);
                    Rooms.Add(aBook);
                    break;
                case DB.DBOperation.Edit:
                    roomDB.DataSetChange(aBook, op);
                    int index = FindIndex(AllRooms, aBook);
                    Rooms[index] = aBook;
                    break;
                case DB.DBOperation.Delete:
                    roomDB.DataSetChange(aBook, op);
                    Rooms.Remove(aBook);
                    break;
            }

        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Room Room)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return roomDB.UpdateDataSource(Room);
        }
        #endregion


        #region Search Methods
        public Room FindRoomByFreePeriod(Collection<Booking> bookings, Collection<Room> rooms, Period period)
        {
            Collection<Room> copyRooms = new Collection<Room>(rooms); // copy of list

            foreach (Booking booking in bookings)
            {
                Period otherPeriod = booking.Dates;

                if (period.Overlap(otherPeriod) == true)
                {
                    int rRoom = FindIndex(copyRooms, booking.Room);
                    copyRooms.RemoveAt(rRoom);
                    //copyRooms.Remove(booking.Room);
                }

            }

            if (copyRooms.Count < 1)
            {
                return null;
            }
            else
            {
                return copyRooms.First();
            }
        }

        public Room Find(int ID)
        {
            int index = 0;
            bool found = (Rooms[index].RoomID == ID);
            int count = Rooms.Count;

            while (!found && index < Rooms.Count - 1)
            {
                found = Rooms[index].RoomID == ID;
                index++;

            }
            return Rooms[index];
        }

        public int FindIndex(Collection<Room> fRooms, Room room)
        {
            int counter = 0;
            bool found = (room.RoomID == fRooms[counter].RoomID);
            while (!found && counter < fRooms.Count - 1)
            {
                counter++;
                found = (room.RoomID == fRooms[counter].RoomID);
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

