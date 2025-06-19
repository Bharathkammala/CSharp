using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlDBOperations
{
    public class Helper
    {
        private MySqlConnection _mySqlConnection = null;
        private string _connectionString = string.Empty;
        public Helper(string connectionString)
        {
            //"Server=localhost;Database=college;User ID=jayk;Password=password;";
            _connectionString = connectionString;
            this.OpenConnection();
        }

        public void OpenConnection()
        {
            if (_mySqlConnection == null)
            {
                _mySqlConnection = new MySqlConnection(_connectionString);
            }
            _mySqlConnection.Open();
        }

        public void CloseConnection()
        {
            if (_mySqlConnection != null)
            {
                _mySqlConnection.Close();
                _mySqlConnection = null;
                _connectionString = string.Empty;
            }
        }

        public int ExecuteCRUDCommand(string command)
        {
            int iReturnVal = -1;
            if (_mySqlConnection == null || _mySqlConnection.State != ConnectionState.Open)
            {
                OpenConnection();
            }
            MySqlCommand mscQuery = new MySqlCommand(command, _mySqlConnection);
            iReturnVal = mscQuery.ExecuteNonQuery();
            return iReturnVal;
        }

        public DataTable ExecuteSelectQuery(string query)
        {
            if (_mySqlConnection == null || _mySqlConnection.State != ConnectionState.Open)
            {
                OpenConnection();
            }
            MySqlCommand mscQuery = new MySqlCommand(query, _mySqlConnection);
            MySqlDataReader msdResult = mscQuery.ExecuteReader();
            DataTable dtResult = new DataTable();
            dtResult.Load(msdResult);
            return dtResult;
        }
    }
}