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
        private string table1 = "Room";
        private string sqlLocal1 = "SELECT * FROM Room";
        //private string table2 = "Waiter";
        //private string sqlLocal2 = "SELECT * FROM Waiter";
        //private string table3 = "Runner";
        //private string sqlLocal3 = "SELECT * FROM Runner";
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
            return dataSet;
        }
        private void Add2Collection(string table)
        {

            DataRow myRow = null;
            Room aRoom;
            //Room aRoom;
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

            foreach (DataRow myRow_loopVariable in dataSet.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aRoom = new Room( Convert.ToInt32(myRow["RoomID"]), Convert.ToInt32(myRow["numOccupants"]) );
                
                    //    aRoom.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    //aRoom.Telephone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    //aRoom.role.getRoleValue = (Role.RoleType)Convert.ToByte(myRow["Role"]);

                    //switch (aRoom.role.getRoleValue)
                    //{
                    //    case Role.RoleType.Headwaiter:
                    //        headw = (HeadWaiter)aRoom.role;
                    //        headw.SalaryAmount = Convert.ToDecimal(myRow["Salary"]);
                    //        break;
                    //    case Role.RoleType.Waiter:
                    //        waiter = (Waiter)aRoom.role;
                    //        waiter.getRate = Convert.ToDecimal(myRow["DayRate"]);
                    //        waiter.getShifts = Convert.ToInt32(myRow["NoOfShifts"]);
                    //        waiter.getTips = Convert.ToDecimal(myRow["Tips"]);
                    //        break;
                    //    case Role.RoleType.Runner:
                    //        runner = (Runner)aRoom.role;
                    //        runner.getRate = Convert.ToDecimal(myRow["DayRate"]);
                    //        runner.getShifts = Convert.ToInt32(myRow["NoOfShifts"]);
                    //        runner.getTips = Convert.ToDecimal(myRow["Tips"]);
                    //        break;
                    //}
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
            aRow["numOccupants"] = aRoom.NumOfOccupants;
          
            //aRow["Role"] = (byte)aRoom.role.getRoleValue;

            //switch (aRoom.role.getRoleValue)
            //{
            //    case Role.RoleType.Headwaiter:
            //        headwaiter = (HeadWaiter)aRoom.role;
            //        aRow["Salary"] = headwaiter.SalaryAmount;
            //        break;
            //    case Role.RoleType.Waiter:
            //        waiter = (Waiter)aRoom.role;
            //        aRow["DayRate"] = waiter.getRate;
            //        aRow["NoOfShifts"] = waiter.getShifts;
            //        aRow["Tips"] = waiter.getTips;
            //        break;
            //    case Role.RoleType.Runner:
            //        runner = (Runner)aRoom.role;
            //        aRow["DayRate"] = runner.getRate;
            //        aRow["NoOfShifts"] = runner.getShifts;
            //        aRow["Tips"] = runner.getTips;
            //        break;
            //}
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
            string dataTable = table1;

            //switch (aRoom.role.getRoleValue)
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

            param = new SqlParameter("@numOccupants", SqlDbType.Int, 15, "numOccupants");
            dataAdapter.InsertCommand.Parameters.Add(param);

            //switch (aRoom.role.getRoleValue)
            //{
            //    case Role.RoleType.Headwaiter:
            //        param = new SqlParameter("@Salary", SqlDbType.Money, 8, "Salary");
            //        dataAdapter.InsertCommand.Parameters.Add(param);
            //        break;
            //    case Role.RoleType.Waiter:
            //        param = new SqlParameter("@Tips", SqlDbType.Money, 8, "Tips");
            //        dataAdapter.InsertCommand.Parameters.Add(param);

            //        param = new SqlParameter("@DayRate", SqlDbType.Money, 8, "DayRate");
            //        dataAdapter.InsertCommand.Parameters.Add(param);

            //        param = new SqlParameter("@NoOfShifts", SqlDbType.SmallInt, 4, "NoOfShifts");
            //        dataAdapter.InsertCommand.Parameters.Add(param);
            //        break;
            //    case Role.RoleType.Runner:
            //        param = new SqlParameter("@DayRate", SqlDbType.Money, 8, "DayRate");
            //        dataAdapter.InsertCommand.Parameters.Add(param);

            //        param = new SqlParameter("@NoOfShifts", SqlDbType.SmallInt, 4, "NoOfShifts");
            //        dataAdapter.InsertCommand.Parameters.Add(param);
            //        break;
            //}

        }
        private void Build_UPDATE_Parameters(Room aRoom)
        {
            /*
             * method to update check in/out dates - keeps Room id the same
             */
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@numOccupants", SqlDbType.Int, 15, "numOccupants");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapter.UpdateCommand.Parameters.Add(param);

            //switch (aRoom.role.getRoleValue)
            //{
            //    case Role.RoleType.Headwaiter:
            //        param = new SqlParameter("@Salary", SqlDbType.Decimal, 2, "Salary");
            //        param.SourceVersion = DataRowVersion.Current;
            //        dataAdapter.UpdateCommand.Parameters.Add(param);
            //        break;

            //    case Role.RoleType.Waiter:
            //        param = new SqlParameter("@Shifts", SqlDbType.SmallInt, 4, "Shifts");
            //        param.SourceVersion = DataRowVersion.Current;
            //        dataAdapter.UpdateCommand.Parameters.Add(param);

            //        param = new SqlParameter("@Rate", SqlDbType.Decimal, 2, "Rate");
            //        param.SourceVersion = DataRowVersion.Current;
            //        dataAdapter.UpdateCommand.Parameters.Add(param);

            //        param = new SqlParameter("@Tips", SqlDbType.Decimal, 2, "Tips");
            //        param.SourceVersion = DataRowVersion.Current;
            //        dataAdapter.UpdateCommand.Parameters.Add(param);
            //        break;

            //    case Role.RoleType.Runner:
            //        param = new SqlParameter("@Shifts", SqlDbType.SmallInt, 4, "Shifts");
            //        param.SourceVersion = DataRowVersion.Current;
            //        dataAdapter.UpdateCommand.Parameters.Add(param);

            //        param = new SqlParameter("@Rate", SqlDbType.Decimal, 2, "Rate");
            //        param.SourceVersion = DataRowVersion.Current;
            //        dataAdapter.UpdateCommand.Parameters.Add(param);

            //        param = new SqlParameter("@Tips", SqlDbType.Decimal, 2, "Tips");
            //        param.SourceVersion = DataRowVersion.Current;
            //        dataAdapter.UpdateCommand.Parameters.Add(param);
            //        break;
            //}
            param = new SqlParameter("@Original_RoomID", SqlDbType.Int, 15, "RoomID");
            param.SourceVersion = DataRowVersion.Original;
            dataAdapter.UpdateCommand.Parameters.Add(param);
        }
        private void Create_UPDATE_Command(Room aRoom)
        {
            dataAdapter.UpdateCommand = new SqlCommand(
                "UPDATE Room SET numOccupants = @numOccupants" +
                "WHERE RoomID = @Original_RoomID ", sqlConnection); // unsure if i add original_room id as well ?  
                                                                          //switch (aRoom.role.getRoleValue)
                                                                          //{
                                                                          //    case Role.RoleType.Headwaiter:
                                                                          //        dataAdapter.UpdateCommand = new SqlCommand(
                                                                          //            "UPDATE HeadWaiter SET Name = @Name, Phone = @Phone, Role = @Role, Salary = @Salary " +
                                                                          //            "WHERE ID = @Original_ID", sqlConnection);
                                                                          //        break;

            //    case Role.RoleType.Waiter:
            //        dataAdapter.UpdateCommand = new SqlCommand(
            //            "UPDATE Waiter SET Name = @Name, Phone = @Phone, Role = @Role, Rate = @Rate , Shifts = @Shifts, Tips = @Tips" +
            //            "WHERE ID = @Original_ID", sqlConnection);
            //        break;

            //    case Role.RoleType.Runner:

            //        dataAdapter.UpdateCommand = new SqlCommand(
            //            "UPDATE Runner SET Name = @Name, Phone = @Phone, Role = @Role, Rate = @Rate , Shifts = @Shifts, Tips = @Tips  " +
            //            "WHERE ID = @Original_ID", sqlConnection);
            //        break;
            //}
            Build_UPDATE_Parameters(aRoom);
        }

        private void Create_INSERT_Command(Room aRoom)
        {
            dataAdapter.InsertCommand = new SqlCommand(
                "INSERT into Room (RoomID, numOccupants) " +
                "VALUES (@RoomID, @numOccupants)", sqlConnection);
            //    switch (aRoom.role.getRoleValue)
            //{
            //    case Role.RoleType.Headwaiter:
            //        dataAdapter.InsertCommand = new SqlCommand("INSERT into HeadWaiter (ID, EMPID, Name, Phone, Role, Salary) VALUES (@ID, @EmpID, @Name, @Phone, @Role, @Salary)", sqlConnection);
            //        break;
            //    case Role.RoleType.Waiter:
            //        dataAdapter.InsertCommand = new SqlCommand("INSERT into Waiter (ID, EMPID, Name, Phone, Role, Tips, DayRate, NoOfShifts) VALUES (@ID, @EmpID, @Name, @Phone, @Role, @Tips, @DayRate, @NoOfShifts)", sqlConnection);
            //        break;
            //    case Role.RoleType.Runner:
            //        dataAdapter.InsertCommand = new SqlCommand("INSERT into Runner (ID, EMPID, Name, Phone, Role, DayRate, NoOfShifts) VALUES (@ID, @EmpID, @Name, @Phone, @Role, @DayRate, @NoOfShifts)", sqlConnection);
            //        break;
            //}
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

            success = UpdateDataSource(sqlLocal1, table1);
            //switch (aRoom.role.getRoleValue)
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


