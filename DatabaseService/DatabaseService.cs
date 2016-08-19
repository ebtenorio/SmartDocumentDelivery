using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseServiceLib
{
    public class DatabaseService
    {
        SqlConnection m_SqlConnection;

        public DatabaseService(SqlConnection _sqlConnection)
        {
            this.m_SqlConnection = _sqlConnection;            
        }

        public DataTable GetDataTable(CommandType _pCommandType, string _pCommandString, List<SqlParameter> _pSqlParams)
        {
            DataTable _dataTable = new DataTable("DataTable");

            SqlCommand _sqlCommand = new SqlCommand(_pCommandString, this.m_SqlConnection);

            _sqlCommand.CommandType = _pCommandType;

            if (_pSqlParams != null)
            {
                foreach (SqlParameter _param in _pSqlParams)
                {
                    _sqlCommand.Parameters.Add(_param);
                }
            }
            this.m_SqlConnection.Open();

            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);

            _sqlCommand.ExecuteNonQuery();

            _sqlDataAdapter.Fill(_dataTable);

            this.m_SqlConnection.Close();

            return _dataTable; 
        }

        public bool ExecuteProcedure(string _pProcedureName, List<SqlParameter> _pSqlParams)
        {
            SqlCommand _sqlCommand = new SqlCommand(_pProcedureName, this.m_SqlConnection);

            _sqlCommand.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter _param in _pSqlParams)
            {
                _sqlCommand.Parameters.Add(_param);
            }

            this.m_SqlConnection.Open();

            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);

            _sqlCommand.ExecuteNonQuery();

            this.m_SqlConnection.Close();

            return true;
        }

    }
}
