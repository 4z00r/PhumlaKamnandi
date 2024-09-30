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
                    int index = FindIndex(aBook);
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

        public int FindIndex(Room book)
        {
            int counter = 0;
            bool found = false;
            found = (book.RoomID == Rooms[counter].RoomID);
            while (!found && counter < Rooms.Count - 1)
            {
                counter++;
                found = (book.RoomID == Rooms[counter].RoomID);
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

