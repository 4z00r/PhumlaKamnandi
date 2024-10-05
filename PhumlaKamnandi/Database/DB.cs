using PhumlaKamnandi.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
//Name Spaces
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandi.Database
{
    public class DB
    {
        #region Variable declaration
        //***Once the database is created you can find the correct connection string by using the Settings.Default object to select the correct connection string
        private string connection = Settings.Default.BookingDBConnectionString;
        protected SqlConnection sqlConnection;
        protected DataSet dataSet;
        protected SqlDataAdapter dataAdapter;
        #endregion
        public enum DBOperation
        {
            Add,
            Edit,
            Delete
        }
        //DBOperation dbOperation; 
        #region Constructor
        public DB()
        {
            try
            {
                //Open a connection & create a new dataset object
                sqlConnection = new SqlConnection(connection);
                dataSet = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        #endregion

        #region Update the DateSet
        public void FillDataSet(string aSQLstring, string aTable)
        {
            //fills dataset fresh from the db for a specific table and with a specific Query
            try
            {
                dataAdapter = new SqlDataAdapter(aSQLstring, sqlConnection);
                sqlConnection.Open();
                //dataSet.Clear();
                dataAdapter.Fill(dataSet, aTable);
                sqlConnection.Close();

            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }

        #endregion

        #region Update the data source 
        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                //open the connection
                sqlConnection.Open();
                //***update the database table via the data adapter
                dataAdapter.Update(dataSet, table);
                //---close the connection
                sqlConnection.Close();
                //refresh the dataset
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;
        }
        #endregion
    }
}
