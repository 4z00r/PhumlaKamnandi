using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandi.Business;

namespace PhumlaKamnandi.Database
{
    public class RoomDB : DB
    {
        #region  Data members        
        private string table2 = "Room";
        private string sqlLocal1 = "SELECT * FROM Room";
        
        private Collection<Room> Rooms;

        #endregion

        #region Property Method: Collection
        public Collection<Room> AllRooms
        {
            get
            {
                return Rooms;
            }
        }
        #endregion

        #region Constructor
        public RoomDB() : base()
        {
            Rooms = new Collection<Room>();
            FillDataSet(sqlLocal1, table2);
            Add2Collection(table2);
            
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dataSet;
        }
        private void Add2Collection(string table)
        {

            DataRow myRow = null;
            Room aRoom;
            

            foreach (DataRow myRow_loopVariable in dataSet.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aRoom = new Room( Convert.ToInt32(myRow["RoomID"]) );
                
                    Rooms.Add(aRoom);
                }
            }
        }
        private void FillRow(DataRow aRow, Room aRoom, DB.DBOperation operation)
        {
            if (aRow == null)
            { // error catch
            }
            if (operation == DB.DBOperation.Add)
            {
                aRow["RoomID"] = aRoom.RoomID;

            }
          
        }
        private int FindRow(Room aRoom, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dataSet.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (aRoom.RoomID == Convert.ToInt32(dataSet.Tables[table].Rows[rowIndex]["RoomID"]))
                    {
                        returnValue = rowIndex;
                        break;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Room aRoom, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table2;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dataSet.Tables[dataTable].NewRow();
                    FillRow(aRow, aRoom, operation);
                    dataSet.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dataSet.Tables[dataTable].Rows[FindRow(aRoom, dataTable)];
                    FillRow(aRow, aRoom, operation);
                    break;
                case DB.DBOperation.Delete:
                    aRow = dataSet.Tables[dataTable].Rows[FindRow(aRoom, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Room aRoom)
        {
            /*
             * for this method double check the sizing for each row  - i set each row to 15 but needs to be changed later
             */
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomID", SqlDbType.Int, 15, "RoomID");
            dataAdapter.InsertCommand.Parameters.Add(param);

            //param = new SqlParameter("@numOccupants", SqlDbType.Int, 15, "numOccupants");
            //dataAdapter.InsertCommand.Parameters.Add(param);

        }
        private void Build_UPDATE_Parameters(Room aRoom)
        {
            /*
             * method to update check in/out dates - keeps Room id the same
             */
            SqlParameter param = default(SqlParameter);
            //param = new SqlParameter("@numOccupants", SqlDbType.Int, 15, "numOccupants");
            //param.SourceVersion = DataRowVersion.Current;
            //dataAdapter.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_RoomID", SqlDbType.Int, 15, "RoomID");
            param.SourceVersion = DataRowVersion.Original;
            dataAdapter.UpdateCommand.Parameters.Add(param);
        }
        private void Create_UPDATE_Command(Room aRoom)
        {
            //dataAdapter.UpdateCommand = new SqlCommand(
            //    "UPDATE Room SET numOccupants = @numOccupants" +
            //    "WHERE RoomID = @Original_RoomID ", sqlConnection); // unsure if i add original_room id as well ?  

            dataAdapter.UpdateCommand = new SqlCommand("", sqlConnection);
            Build_UPDATE_Parameters(aRoom);
        }

        private void Create_INSERT_Command(Room aRoom)
        {
            dataAdapter.InsertCommand = new SqlCommand(
                "INSERT into Room (RoomID) " +
                "VALUES (@RoomID)", sqlConnection);
          
            Build_INSERT_Parameters(aRoom);
        }
        private void Create_DELETE_Command(Room aRoom)
        {
            dataAdapter.DeleteCommand = new SqlCommand(
                "DELETE FROM Room WHERE RoomID = @Original_RoomID", sqlConnection);
        }

        public bool UpdateDataSource(Room aRoom)
        {
            bool success = true;
            Create_INSERT_Command(aRoom);
            Create_UPDATE_Command(aRoom);

            success = UpdateDataSource(sqlLocal1, table2);
            
            return success;
        }

        #endregion
    }


}


