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
    public class BookingDB: DB
    {
        #region  Data members        
        private string table1 = "Booking";
    private string sqlLocal1 = "SELECT * FROM Booking";
    //private string table2 = "Waiter";
    //private string sqlLocal2 = "SELECT * FROM Waiter";
    //private string table3 = "Runner";
    //private string sqlLocal3 = "SELECT * FROM Runner";
    private Collection<Booking> bookings;

    #endregion

    #region Property Method: Collection
    public Collection<Booking> AllEmployees
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
        //FillDataSet(sqlLocal2, table2);
        //Add2Collection(table2);
        //FillDataSet(sqlLocal3, table3);
        //Add2Collection(table3);
    }
    #endregion

    #region Utility Methods
    public DataSet GetDataSet()
    {
        return dsMain;
    }
    private void Add2Collection(string table)
    {

        DataRow myRow = null;
        Booking aBooking; 
        //Booking aBooking;
        //HeadWaiter headw;
        //Waiter waiter;
        //Runner runner;
        //Role.RoleType roleValue = Role.RoleType.NoRole;
        //switch (table)
        //{
        //    case "HeadWaiter":
        //        roleValue = Role.RoleType.Headwaiter;
        //        break;
        //    case "Waiter":
        //        roleValue = Role.RoleType.Waiter;
        //        break;
        //    case "Runner":
        //        roleValue = Role.RoleType.Runner;
        //        break;
        //}

        foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
        {
            myRow = myRow_loopVariable;
            if (!(myRow.RowState == DataRowState.Deleted))
            {
                aBooking = new Booking(1, new Room(1, new Price(), true), new Period(new DateTime(1,12,2024), new DateTime(7,12,2024)));
                aBooking.BookingID = Convert.ToInt32(myRow["BookingID"]);
                //aBooking.BookingID = Convert.ToString(m)
                aBooking.Room.RoomID = Convert.ToInt32(myRow["RoomID"]);
                aBooking.Dates.CheckIn = Convert.ToDateTime(myRow["CheckIn"]);
                aBooking.Dates.CheckOut = Convert.ToDateTime(myRow["CheckOut"]);
                //    aBooking.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                //aBooking.Telephone = Convert.ToString(myRow["Phone"]).TrimEnd();
                //aBooking.role.getRoleValue = (Role.RoleType)Convert.ToByte(myRow["Role"]);

                //switch (aBooking.role.getRoleValue)
                //{
                //    case Role.RoleType.Headwaiter:
                //        headw = (HeadWaiter)aBooking.role;
                //        headw.SalaryAmount = Convert.ToDecimal(myRow["Salary"]);
                //        break;
                //    case Role.RoleType.Waiter:
                //        waiter = (Waiter)aBooking.role;
                //        waiter.getRate = Convert.ToDecimal(myRow["DayRate"]);
                //        waiter.getShifts = Convert.ToInt32(myRow["NoOfShifts"]);
                //        waiter.getTips = Convert.ToDecimal(myRow["Tips"]);
                //        break;
                //    case Role.RoleType.Runner:
                //        runner = (Runner)aBooking.role;
                //        runner.getRate = Convert.ToDecimal(myRow["DayRate"]);
                //        runner.getShifts = Convert.ToInt32(myRow["NoOfShifts"]);
                //        runner.getTips = Convert.ToDecimal(myRow["Tips"]);
                //        break;
                //}
                bookings.Add(aBooking);
            }
        }
    }
    private void FillRow(DataRow aRow, Booking aBooking, DB.DBOperation operation)
    {
        Booking booking; 
        if (operation == DB.DBOperation.Add)
        {
            aRow["BookingID"] = aBooking.BookingID;
            aRow["RoomID"] = aBooking.Room.RoomID;
        }
        aRow["CheckIn"] = aBooking.Dates.CheckIn;
        aRow["CheckOut"] = aBooking.Dates.CheckOut;
            //aRow["Role"] = (byte)aBooking.role.getRoleValue;

            //switch (aBooking.role.getRoleValue)
            //{
            //    case Role.RoleType.Headwaiter:
            //        headwaiter = (HeadWaiter)aBooking.role;
            //        aRow["Salary"] = headwaiter.SalaryAmount;
            //        break;
            //    case Role.RoleType.Waiter:
            //        waiter = (Waiter)aBooking.role;
            //        aRow["DayRate"] = waiter.getRate;
            //        aRow["NoOfShifts"] = waiter.getShifts;
            //        aRow["Tips"] = waiter.getTips;
            //        break;
            //    case Role.RoleType.Runner:
            //        runner = (Runner)aBooking.role;
            //        aRow["DayRate"] = runner.getRate;
            //        aRow["NoOfShifts"] = runner.getShifts;
            //        aRow["Tips"] = runner.getTips;
            //        break;
            //}
        }
    private int FindRow(Booking aBooking, string table)
    {
        int rowIndex = 0;
        DataRow myRow;
        int returnValue = -1;

        foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
        {
            myRow = myRow_loopVariable;
            if (myRow.RowState != DataRowState.Deleted)
            {
                if (aBooking.BookingID == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
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
        
        //switch (aBooking.role.getRoleValue)
        //{
        //    case Role.RoleType.Headwaiter:
        //        dataTable = table1;
        //        break;
        //    case Role.RoleType.Waiter:
        //        dataTable = table2;
        //        break;
        //    case Role.RoleType.Runner:
        //        dataTable = table3;
        //        break;
        //}
        switch (operation)
        {
            case DB.DBOperation.Add:
                aRow = dsMain.Tables[dataTable].NewRow();
                FillRow(aRow, aBooking, operation);
                dsMain.Tables[dataTable].Rows.Add(aRow);
                break;
            case DB.DBOperation.Edit:
                aRow = dsMain.Tables[dataTable].Rows[FindRow(aBooking, dataTable)];
                FillRow(aRow, aBooking, operation);
                break;
            case DB.DBOperation.Delete:
                aRow = dsMain.Tables[dataTable].Rows[FindRow(aBooking, dataTable)];
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
        daMain.InsertCommand.Parameters.Add(param);
        
        param = new SqlParameter("@RoomID", SqlDbType.Int, 15, "RoomID");
        daMain.InsertCommand.Parameters.Add(param);

        param = new SqlParameter("@CheckIn", SqlDbType.DateTime, 15, "CheckIn");
        daMain.InsertCommand.Parameters.Add(param);

        param = new SqlParameter("@CheckOut", SqlDbType.DateTime,15, "CheckOut");
        daMain.InsertCommand.Parameters.Add(param);

        //switch (aBooking.role.getRoleValue)
        //{
        //    case Role.RoleType.Headwaiter:
        //        param = new SqlParameter("@Salary", SqlDbType.Money, 8, "Salary");
        //        daMain.InsertCommand.Parameters.Add(param);
        //        break;
        //    case Role.RoleType.Waiter:
        //        param = new SqlParameter("@Tips", SqlDbType.Money, 8, "Tips");
        //        daMain.InsertCommand.Parameters.Add(param);

        //        param = new SqlParameter("@DayRate", SqlDbType.Money, 8, "DayRate");
        //        daMain.InsertCommand.Parameters.Add(param);

        //        param = new SqlParameter("@NoOfShifts", SqlDbType.SmallInt, 4, "NoOfShifts");
        //        daMain.InsertCommand.Parameters.Add(param);
        //        break;
        //    case Role.RoleType.Runner:
        //        param = new SqlParameter("@DayRate", SqlDbType.Money, 8, "DayRate");
        //        daMain.InsertCommand.Parameters.Add(param);

        //        param = new SqlParameter("@NoOfShifts", SqlDbType.SmallInt, 4, "NoOfShifts");
        //        daMain.InsertCommand.Parameters.Add(param);
        //        break;
        //}

    }
    private void Build_UPDATE_Parameters(Booking aBooking)
    {
            /*
             * method to update check in/out dates - keeps booking id and room the same
             */
        SqlParameter param = default(SqlParameter);
        param = new SqlParameter("@CheckIn", SqlDbType.DateTime, 100, "CheckIn");
        param.SourceVersion = DataRowVersion.Current;
        daMain.UpdateCommand.Parameters.Add(param);

        param = new SqlParameter("@CheckOut", SqlDbType.DateTime, 15, "CheckOut");
        param.SourceVersion = DataRowVersion.Current;
        daMain.UpdateCommand.Parameters.Add(param);

        //switch (aBooking.role.getRoleValue)
        //{
        //    case Role.RoleType.Headwaiter:
        //        param = new SqlParameter("@Salary", SqlDbType.Decimal, 2, "Salary");
        //        param.SourceVersion = DataRowVersion.Current;
        //        daMain.UpdateCommand.Parameters.Add(param);
        //        break;

        //    case Role.RoleType.Waiter:
        //        param = new SqlParameter("@Shifts", SqlDbType.SmallInt, 4, "Shifts");
        //        param.SourceVersion = DataRowVersion.Current;
        //        daMain.UpdateCommand.Parameters.Add(param);

        //        param = new SqlParameter("@Rate", SqlDbType.Decimal, 2, "Rate");
        //        param.SourceVersion = DataRowVersion.Current;
        //        daMain.UpdateCommand.Parameters.Add(param);

        //        param = new SqlParameter("@Tips", SqlDbType.Decimal, 2, "Tips");
        //        param.SourceVersion = DataRowVersion.Current;
        //        daMain.UpdateCommand.Parameters.Add(param);
        //        break;

        //    case Role.RoleType.Runner:
        //        param = new SqlParameter("@Shifts", SqlDbType.SmallInt, 4, "Shifts");
        //        param.SourceVersion = DataRowVersion.Current;
        //        daMain.UpdateCommand.Parameters.Add(param);

        //        param = new SqlParameter("@Rate", SqlDbType.Decimal, 2, "Rate");
        //        param.SourceVersion = DataRowVersion.Current;
        //        daMain.UpdateCommand.Parameters.Add(param);

        //        param = new SqlParameter("@Tips", SqlDbType.Decimal, 2, "Tips");
        //        param.SourceVersion = DataRowVersion.Current;
        //        daMain.UpdateCommand.Parameters.Add(param);
        //        break;
        //}
        param = new SqlParameter("@Original_BookingID", SqlDbType.Int, 15, "BookingID");
        param.SourceVersion = DataRowVersion.Original;
        daMain.UpdateCommand.Parameters.Add(param);

        param = new SqlParameter("@Original_RoomID", SqlDbType.Int, 15, "EmpID");
        param.SourceVersion = DataRowVersion.Original;
        daMain.UpdateCommand.Parameters.Add(param);
    }
    private void Create_UPDATE_Command(Booking aBooking)
    {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE Booking SET CheckIn = @CheckIn, CheckOut = @CheckOut " +
                "WHERE BookingID = @Original_BookingID ", cnMain); // unsure if i add original_room id as well ?  
        //switch (aBooking.role.getRoleValue)
        //{
        //    case Role.RoleType.Headwaiter:
        //        daMain.UpdateCommand = new SqlCommand(
        //            "UPDATE HeadWaiter SET Name = @Name, Phone = @Phone, Role = @Role, Salary = @Salary " +
        //            "WHERE ID = @Original_ID", cnMain);
        //        break;

        //    case Role.RoleType.Waiter:
        //        daMain.UpdateCommand = new SqlCommand(
        //            "UPDATE Waiter SET Name = @Name, Phone = @Phone, Role = @Role, Rate = @Rate , Shifts = @Shifts, Tips = @Tips" +
        //            "WHERE ID = @Original_ID", cnMain);
        //        break;

        //    case Role.RoleType.Runner:

        //        daMain.UpdateCommand = new SqlCommand(
        //            "UPDATE Runner SET Name = @Name, Phone = @Phone, Role = @Role, Rate = @Rate , Shifts = @Shifts, Tips = @Tips  " +
        //            "WHERE ID = @Original_ID", cnMain);
        //        break;
        //}
        Build_UPDATE_Parameters(aBooking);
    }

    private void Create_INSERT_Command(Booking aBooking)
    {
            daMain.InsertCommand = new SqlCommand(
                "INSERT into Booking (BookingID, RoomID, CheckIn, CheckOut) " +
                "VALUES (@BookingID, @RoomEmpID, @CheckIn, @CheckOut)", cnMain);
        //    switch (aBooking.role.getRoleValue)
        //{
        //    case Role.RoleType.Headwaiter:
        //        daMain.InsertCommand = new SqlCommand("INSERT into HeadWaiter (ID, EMPID, Name, Phone, Role, Salary) VALUES (@ID, @EmpID, @Name, @Phone, @Role, @Salary)", cnMain);
        //        break;
        //    case Role.RoleType.Waiter:
        //        daMain.InsertCommand = new SqlCommand("INSERT into Waiter (ID, EMPID, Name, Phone, Role, Tips, DayRate, NoOfShifts) VALUES (@ID, @EmpID, @Name, @Phone, @Role, @Tips, @DayRate, @NoOfShifts)", cnMain);
        //        break;
        //    case Role.RoleType.Runner:
        //        daMain.InsertCommand = new SqlCommand("INSERT into Runner (ID, EMPID, Name, Phone, Role, DayRate, NoOfShifts) VALUES (@ID, @EmpID, @Name, @Phone, @Role, @DayRate, @NoOfShifts)", cnMain);
        //        break;
        //}
        Build_INSERT_Parameters(aBooking);
    }
    private void Create_DELETE_Command(Booking aBooking)
    {
        daMain.DeleteCommand = new SqlCommand(
            "DELETE FROM Booking WHERE BookingID = @Original_BookingID", cnMain);
    }

    public bool UpdateDataSource(Booking aBooking)
    {
        bool success = true;
        Create_INSERT_Command(aBooking);
        Create_UPDATE_Command(aBooking);

            success = UpdateDataSource(sqlLocal1, table1); 
        //switch (aBooking.role.getRoleValue)
        //{
        //    case Role.RoleType.Headwaiter:
        //        success = UpdateDataSource(sqlLocal1, table1);
        //        break;
        //    case Role.RoleType.Waiter:
        //        success = UpdateDataSource(sqlLocal2, table2);
        //        break;
        //    case Role.RoleType.Runner:
        //        success = UpdateDataSource(sqlLocal3, table3);
        //        break;
        //}
        return success;
    }

    #endregion
}


}


