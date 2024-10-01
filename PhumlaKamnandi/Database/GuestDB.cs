using PhumlaKamnandi.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Database
{
    public class GuestDB : DB
    {
        #region  Data members        
        private string table3 = "Guest";
        private string sqlLocal1 = "SELECT * FROM Guest";
        private Collection<Guest> guests;

        #endregion

        #region Property Method: Collection
        public Collection<Guest> AllBookings
        {
            get
            {
                return guests;
            }
        }
        #endregion

        #region Constructor
        public GuestDB() : base()
        {
            guests = new Collection<Guest>();
            FillDataSet(sqlLocal1, table3);
            Add2Collection(table3);

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
            Guest aGuest;

            foreach (DataRow myRow_loopVariable in dataSet.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aGuest = new Guest("", "");
                    aGuest.GuestID = Convert.ToInt32(myRow["GuestID"]);
                    aGuest.Name= Convert.ToString(myRow["Name"]);
                    aGuest.Address = Convert.ToString(myRow["Address"]);
                    aGuest.Telephone = Convert.ToString(myRow["Telephone"]);

                    guests.Add(aGuest);
                }
            }
        }
        private void FillRow(DataRow aRow, Guest aGuest, DB.DBOperation operation)
        {
            if (aRow == null)
            { // error catch
            }
            if (operation == DB.DBOperation.Add)
            {
                aRow["GuestID"] = aGuest.GuestID;

            }
            aRow["Name"] = aGuest.Name;
            aRow["Address"] = aGuest.Address;
            aRow["Telephone"] = aGuest.Telephone;

        }
        private int FindRow(Guest aGuest, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dataSet.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (aGuest.GuestID == Convert.ToInt32(dataSet.Tables[table].Rows[rowIndex]["GuestID"]))
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
        public void DataSetChange(Guest aGuest, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table3;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dataSet.Tables[dataTable].NewRow();
                    FillRow(aRow, aGuest, operation);
                    dataSet.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dataSet.Tables[dataTable].Rows[FindRow(aGuest, dataTable)];
                    FillRow(aRow, aGuest, operation);
                    break;
                case DB.DBOperation.Delete:
                    aRow = dataSet.Tables[dataTable].Rows[FindRow(aGuest, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Guest aGuest)
        {
            /*
             * for this method double check the sizing for each row  - i set each row to 15 but needs to be changed later
             */
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestID", SqlDbType.Int, 15, "GuestID");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.VarChar, 50, "Name");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.VarChar, 50, "Address");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Telephone", SqlDbType.VarChar, 50, "Telephone");
            dataAdapter.InsertCommand.Parameters.Add(param);

           

        }
        private void Build_UPDATE_Parameters(Guest aGuest)
        {
            /*
             * method to update check in/out dates - keeps Guest id the same
             */
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Address", SqlDbType.DateTime, 100, "Address");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapter.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Telephone", SqlDbType.DateTime, 15, "Telephone");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapter.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.Int, 15, "Name");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapter.UpdateCommand.Parameters.Add(param);


            param = new SqlParameter("@Original_GuestID", SqlDbType.Int, 15, "GuestID");
            param.SourceVersion = DataRowVersion.Original;
            dataAdapter.UpdateCommand.Parameters.Add(param);
        }
        private void Create_UPDATE_Command(Guest aGuest)
        {
            dataAdapter.UpdateCommand = new SqlCommand(
                "UPDATE Guest SET Name = @Name, Address = @Address, Telephone = @Telephone" +
                "WHERE GuestID = @Original_GuestID ", sqlConnection); // unsure if i add original_room id as well ?  

            Build_UPDATE_Parameters(aGuest);
        }

        private void Create_INSERT_Command(Guest aGuest)
        {
            dataAdapter.InsertCommand = new SqlCommand(
                "INSERT into Guest (GuestID, Name, Address, Telephone) " +
                "VALUES (@GuestID, @RoomEmpID, @Address, @Telephone)", sqlConnection);

            Build_INSERT_Parameters(aGuest);
        }
        private void Create_DELETE_Command(Guest aGuest)
        {
            dataAdapter.DeleteCommand = new SqlCommand(
                "DELETE FROM Guest WHERE GuestID = @Original_GuestID", sqlConnection);
        }

        public bool UpdateDataSource(Guest aGuest)
        {
            bool success = true;
            Create_INSERT_Command(aGuest);
            Create_UPDATE_Command(aGuest);

            success = UpdateDataSource(sqlLocal1, table3);
            return success;
        }

        #endregion
    }
}
