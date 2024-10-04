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
    public class BookingDB: DB      // might need .TrimEnd() after ToString !!
    {
        #region  Data members        
        private string table1 = "Booking";
        private string sqlLocal1 = "SELECT * FROM Booking";
        private Collection<Booking> bookings;

    #endregion

    #region Property Method: Collection
    public Collection<Booking> AllBookings
    {
        get
        {
            return bookings;
        }
    }
    #endregion

    #region Constructor
    public BookingDB() : base()
    {
        bookings = new Collection<Booking>();
        FillDataSet(sqlLocal1, table1);
        Add2Collection(table1);
        
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
        Booking aBooking; 
        
        foreach (DataRow myRow_loopVariable in dataSet.Tables[table].Rows)
        {
            myRow = myRow_loopVariable;
            if (!(myRow.RowState == DataRowState.Deleted))
            {
                aBooking = new Booking(new Room(-1));
                aBooking.BookingID = Convert.ToInt32(myRow["BookingID"]);
                aBooking.Room.RoomID = Convert.ToInt32(myRow["RoomID"]);
                aBooking.BookingID = Convert.ToInt32(myRow["GuestID"]); 
                aBooking.Dates = new Period( Convert.ToDateTime(myRow["CheckIn"]), Convert.ToDateTime(myRow["CheckOut"]) );
                aBooking.Pricing = new Price(Convert.ToInt32(myRow["Price"]), aBooking.Dates);
                
                bookings.Add(aBooking);
            }
        }
    }
    private void FillRow(DataRow aRow, Booking aBooking, DB.DBOperation operation)
    {
        if (aRow == null) { // error catch
        }
        if (operation == DB.DBOperation.Add)
        {
            //aRow["BookingID"] = aBooking.BookingID;
            
        }
        aRow["RoomID"] = aBooking.Room.RoomID;
        aRow["GuestID"] = aBooking.Guest.GuestID; 
        aRow["CheckIn"] = aBooking.Dates.CheckIn;
        aRow["CheckOut"] = aBooking.Dates.CheckOut;
        aRow["Price"] = aBooking.Pricing.Total;
            
        }
    private int FindRow(Booking aBooking, string table)
    {
        int rowIndex = 0;
        DataRow myRow;
        int returnValue = -1;

        foreach (DataRow myRow_loopVariable in dataSet.Tables[table].Rows)
        {
            myRow = myRow_loopVariable;
            if (myRow.RowState != DataRowState.Deleted)
            {
                if (aBooking.BookingID == Convert.ToInt32(dataSet.Tables[table].Rows[rowIndex]["BookingID"]))
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
    public void DataSetChange(Booking aBooking, DB.DBOperation operation)
    {
        DataRow aRow = null;
        string dataTable = table1;
        
        switch (operation)
        {
            case DB.DBOperation.Add:
                aRow = dataSet.Tables[dataTable].NewRow();
                FillRow(aRow, aBooking, operation);
                dataSet.Tables[dataTable].Rows.Add(aRow);
                break;
            case DB.DBOperation.Edit:
                aRow = dataSet.Tables[dataTable].Rows[FindRow(aBooking, dataTable)];
                FillRow(aRow, aBooking, operation);
                break;
            case DB.DBOperation.Delete:
                aRow = dataSet.Tables[dataTable].Rows[FindRow(aBooking, dataTable)];
                aRow.Delete();
                break;
        }
    }
    #endregion

    #region Build Parameters, Create Commands & Update database
    private void Build_INSERT_Parameters(Booking aBooking)
    {
            /*
             * for this method double check the sizing for each row  - i set each row to 15 but needs to be changed later
             */
        SqlParameter param = default(SqlParameter);
        param = new SqlParameter("@BookingID", SqlDbType.Int, 15, "BookingID");
        dataAdapter.InsertCommand.Parameters.Add(param);
        
        param = new SqlParameter("@RoomID", SqlDbType.Int, 15, "RoomID");
        dataAdapter.InsertCommand.Parameters.Add(param);

        param = new SqlParameter("@GuestID", SqlDbType.Int, 15, "GuestID");
        dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckIn", SqlDbType.DateTime, 15, "CheckIn");
        dataAdapter.InsertCommand.Parameters.Add(param);

        param = new SqlParameter("@CheckOut", SqlDbType.DateTime,15, "CheckOut");
        dataAdapter.InsertCommand.Parameters.Add(param);

        param = new SqlParameter("@Price", SqlDbType.Int, 15, "Price");
        dataAdapter.InsertCommand.Parameters.Add(param);

        }
    private void Build_UPDATE_Parameters(Booking aBooking)
    {
            /*
             * method to update check in/out dates - keeps booking id the same
             */
        SqlParameter param = default(SqlParameter);
        param = new SqlParameter("@CheckIn", SqlDbType.DateTime, 100, "CheckIn");
        param.SourceVersion = DataRowVersion.Current;
        dataAdapter.UpdateCommand.Parameters.Add(param);

        param = new SqlParameter("@CheckOut", SqlDbType.DateTime, 15, "CheckOut");
        param.SourceVersion = DataRowVersion.Current;
        dataAdapter.UpdateCommand.Parameters.Add(param);
            
        param = new SqlParameter("@RoomID", SqlDbType.Int, 15, "RoomID");
        param.SourceVersion = DataRowVersion.Current;
        dataAdapter.UpdateCommand.Parameters.Add(param);

        param = new SqlParameter("@Price", SqlDbType.Int, 15, "Price");
        param.SourceVersion = DataRowVersion.Current;
        dataAdapter.UpdateCommand.Parameters.Add(param);
            


        param = new SqlParameter("@Original_BookingID", SqlDbType.Int, 15, "BookingID");
        param.SourceVersion = DataRowVersion.Original;
        dataAdapter.UpdateCommand.Parameters.Add(param);

        param = new SqlParameter("@Original_GuestID", SqlDbType.Int, 15, "GuestID");
        param.SourceVersion = DataRowVersion.Original;
        dataAdapter.UpdateCommand.Parameters.Add(param);
        }
    private void Create_UPDATE_Command(Booking aBooking)
    {
            dataAdapter.UpdateCommand = new SqlCommand(
                "UPDATE Booking SET RoomID = @RoomID, CheckIn = @CheckIn, CheckOut = @CheckOut, Price = @Price" +
                "WHERE BookingID = @Original_BookingID, GuestID = @Original_GuestID", sqlConnection); // unsure if i add original_room id as well ?  
        
        Build_UPDATE_Parameters(aBooking);
    }

    private void Create_INSERT_Command(Booking aBooking)
    {
        dataAdapter.InsertCommand = new SqlCommand(
            "INSERT into Booking (RoomID, CheckIn, CheckOut, Price, GuestID) " +
            "VALUES (@RoomID, @CheckIn, @CheckOut, @Price, @GuestID)", sqlConnection);
        
        Build_INSERT_Parameters(aBooking);
    }
    private void Create_DELETE_Command(Booking aBooking)
    {
        dataAdapter.DeleteCommand = new SqlCommand(
            "DELETE FROM Booking WHERE BookingID = @Original_BookingID", sqlConnection);
    }

    public bool UpdateDataSource(Booking aBooking)
    {
        bool success = true;
        Create_INSERT_Command(aBooking);
        Create_UPDATE_Command(aBooking);

        success = UpdateDataSource(sqlLocal1, table1);        
        return success;
    }

    #endregion
}


}


