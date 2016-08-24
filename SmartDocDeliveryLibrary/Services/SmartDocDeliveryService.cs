using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SmartDocDeliveryLibrary.DTOs;
using DatabaseServiceLib;
using System.Data;
using System.Data.OleDb;
using NoodleExportLibrary.NoodleXLSExportLibrary;
using System.IO;

public class SmartDocDeliveryService
{
    SqlConnection m_SqlConnection;
    DatabaseService m_dataBaseService;

    public SmartDocDeliveryService(SqlConnection _pSqlConnection)
    {
        this.m_SqlConnection = _pSqlConnection;
        this.m_dataBaseService = new DatabaseService(_pSqlConnection);
    }

    public string GetStringValue(string _pValue)
    {
        List<SqlParameter> _params = new List<SqlParameter>();

        SqlParameter _param = new SqlParameter();
        _param.ParameterName = "@StringValue";
        _param.Value = _pValue;
        _param.SqlDbType = SqlDbType.VarChar;       
        _params.Add(_param); 

        DataTable _testDB =  this.m_dataBaseService.GetDataTable(System.Data.CommandType.StoredProcedure, "TestSP", _params);

        if (_testDB.Rows.Count > 0)
        {
            return _testDB.Rows[0]["StringValue"].ToString();
        }
        else
        {
            return "Nothing";
        }
    }

    private Boolean InsertTransaction(string _pDeliveryNo,
                                      string _pSequenceNo,
                                      string _pAccountNo,
                                      string _pFileName,
                                      string _pSubscriberName,
                                      string _pAddress,
                                      string _pMINSRN,
                                      string _pBrand,
                                      string _pZipCode,
                                      string _pCycleFilename
                                      )
    {
        bool _IsSuccessful = false;

        try
        {
            List<SqlParameter> _params = new List<SqlParameter>();

            SqlParameter _param;
            
            _param = new SqlParameter();
            _param.ParameterName = "@DeliveryNo";
            _param.SqlDbType = SqlDbType.VarChar;
            _param.Value = _pDeliveryNo.Trim();
            _params.Add(_param);

            _param = new SqlParameter();
            _param.ParameterName = "@SequenceNo";
            _param.SqlDbType = SqlDbType.VarChar;
            _param.Value = _pSequenceNo.Trim();
            _params.Add(_param);

            _param = new SqlParameter();
            _param.ParameterName = "@AccountNo";
            _param.SqlDbType = SqlDbType.VarChar;
            _param.Value = _pAccountNo.Trim();
            _params.Add(_param);

            _param = new SqlParameter();
            _param.ParameterName = "@FileName";
            _param.SqlDbType = SqlDbType.VarChar;
            _param.Value = _pFileName.Trim();
            _params.Add(_param);

            _param = new SqlParameter();
            _param.ParameterName = "@SubscriberName";
            _param.SqlDbType = SqlDbType.VarChar;
            _param.Value = _pSubscriberName.Trim();
            _params.Add(_param);

            _param = new SqlParameter();
            _param.ParameterName = "@Address";
            _param.SqlDbType = SqlDbType.VarChar;
            _param.Value = _pAddress.Trim();
            _params.Add(_param);

            _param = new SqlParameter();
            _param.ParameterName = "@MINSRN";
            _param.SqlDbType = SqlDbType.VarChar;
            _param.Value = _pMINSRN.Trim();
            _params.Add(_param);

            _param = new SqlParameter();
            _param.ParameterName = "@Brand";
            _param.SqlDbType = SqlDbType.VarChar;
            _param.Value = _pBrand.Trim();
            _params.Add(_param);

            _param = new SqlParameter();
            _param.ParameterName = "@ZipCode";
            _param.SqlDbType = SqlDbType.VarChar;
            _param.Value = _pZipCode.Trim();
            _params.Add(_param);

            _param = new SqlParameter();
            _param.ParameterName = "@CycleFilename";
            _param.SqlDbType = SqlDbType.VarChar;
            _param.Value = _pCycleFilename.Trim();
            _params.Add(_param);

            this.m_dataBaseService.ExecuteProcedure("usp_TransactionTable_Insert", _params);
             
        }
        catch (Exception _e)
        {
            throw _e;
        }

        return _IsSuccessful;
    }

    public DTODocDeliveryTransactionList TransactionListByCycle(string _pCycleFilename)
    {
        DTODocDeliveryTransactionList _DocDeliveryTransactionList = new DTODocDeliveryTransactionList();
        DTODocDeliveryTransaction _DocDeliveryTransaction;
        DataTable _TransactionDataTable = new DataTable("DataTable");

        List<SqlParameter> _params = new List<SqlParameter>();
        SqlParameter _param = new SqlParameter();
        _param.ParameterName = "@CycleFilename";
        _param.Value = _pCycleFilename;
        _param.SqlDbType = SqlDbType.VarChar;
        _params.Add(_param); 

        _TransactionDataTable = this.m_dataBaseService.GetDataTable(CommandType.StoredProcedure, "usp_TransactionTable_SelectByCycleFilname", _params);

        foreach (DataRow _row in _TransactionDataTable.Rows)
        {
            _DocDeliveryTransaction = new DTODocDeliveryTransaction();
            _DocDeliveryTransaction.DeliveryNo = _row["DeliveryNo"].ToString();
            _DocDeliveryTransaction.SequenceNo = _row["SequenceNo"].ToString();
            _DocDeliveryTransaction.AccountNo = _row["AccountNo"].ToString();
            _DocDeliveryTransaction.FileName = _row["FileName"].ToString();
            _DocDeliveryTransaction.SubscriberName = _row["SubscriberName"].ToString();
            _DocDeliveryTransaction.Address = _row["Address"].ToString();
            _DocDeliveryTransaction.MINSRN = _row["MINSRN"].ToString();
            _DocDeliveryTransaction.Brand = _row["Brand"].ToString();
            _DocDeliveryTransaction.ZipCode = _row["ZipCode"].ToString();
            _DocDeliveryTransaction.Remarks = _row["Remarks"].ToString();
            _DocDeliveryTransaction.DeliveryStatus = _row["DeliveryStatus"].ToString();

            if (_row["DeliveryStatusDate"] != DBNull.Value)
            {
                _DocDeliveryTransaction.DeliveryStatusDate = DateTime.Parse(_row["DeliveryStatusDate"].ToString());
            }
            
            _DocDeliveryTransaction.ReceivedBy = _row["ReceivedBy"].ToString();
            _DocDeliveryTransaction.Relationship = _row["Relationship"].ToString();
            _DocDeliveryTransaction.RTSNewAddress = _row["RTSNewAddress"].ToString();
            _DocDeliveryTransaction.RTSReason = _row["RTSReason"].ToString();
            _DocDeliveryTransaction.DCCode = _row["DCCode"].ToString();
            _DocDeliveryTransaction.DCName = _row["DCName"].ToString();
            _DocDeliveryTransaction.Messenger = _row["Messenger"].ToString();
            _DocDeliveryTransaction.CycleFilename = _row["CycleFilename"].ToString();
            _DocDeliveryTransaction.IsMerged = Boolean.Parse(_row["IsMerged"].ToString());

            _DocDeliveryTransactionList.Add(_DocDeliveryTransaction);
        }

        return _DocDeliveryTransactionList;
    }

    public void ImportDataFromFile(string _pFilename)
    {
        var fileName = _pFilename;

        if (!this.HasDuplicateCycleFilename(_pFilename))
        {

            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fileName);

            string _firstSheet;
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                _firstSheet = dtSchema.Rows[0].Field<string>("TABLE_NAME");
            }

            var adapter = new OleDbDataAdapter("SELECT * FROM [" + _firstSheet + "]", connectionString);

            var ds = new DataSet();

            adapter.Fill(ds, "TransactionTable");

            DataTable _data = ds.Tables["TransactionTable"];

            fileName = System.IO.Path.GetFileName(fileName);

            foreach (DataRow _row in _data.Rows)
            {
                if (_row[0] == DBNull.Value) continue;
                // insert here
                this.InsertTransaction(_row[0].ToString(),
                                       _row[1].ToString(),
                                       _row[2].ToString(),
                                       _row[3].ToString(),
                                       _row[4].ToString(),
                                       _row[5].ToString(),
                                       _row[6].ToString(),
                                       _row[7].ToString(),
                                       _row[8].ToString(),
                                       fileName);
            }
        }

    }

    public bool UpdateDocDeliveryDetails(string _pDeliveryNo, string _pRemarks, string _pDeliveryStatus, string _pReceivedBy, string _pRelationship, string _pMesssenger)
    {
        List<SqlParameter> _params = new List<SqlParameter>();
        SqlParameter _param;

        _param = new SqlParameter();
        _param.ParameterName = "@DeliveryNo";
        _param.SqlDbType = SqlDbType.VarChar;
        _param.Value = _pDeliveryNo;
        _params.Add(_param);

        _param = new SqlParameter();
        _param.ParameterName = "@Remarks";
        _param.SqlDbType = SqlDbType.VarChar;
        _param.Value = _pRemarks;
        _params.Add(_param);

        _param = new SqlParameter();
        _param.ParameterName = "@DeliveryStatus";
        _param.SqlDbType = SqlDbType.VarChar;
        _param.Value = _pDeliveryStatus;
        _params.Add(_param);

        _param = new SqlParameter();
        _param.ParameterName = "@ReceivedBy";
        _param.SqlDbType = SqlDbType.VarChar;
        _param.Value = _pReceivedBy;
        _params.Add(_param);

        _param = new SqlParameter();
        _param.ParameterName = "@Relationship";
        _param.SqlDbType = SqlDbType.VarChar;
        _param.Value = _pRelationship;
        _params.Add(_param);

        _param = new SqlParameter();
        _param.ParameterName = "@Messenger";
        _param.SqlDbType = SqlDbType.VarChar;
        _param.Value = _pMesssenger;
        _params.Add(_param);

        this.m_dataBaseService.ExecuteProcedure("usp_TransactionTable_Update", _params);
  
        return true;

    }

    public void ExportToExcel(string _pCycleFilename)
    {
        ExcelExport _excelExport = new ExcelExport();
        DataTable _TransactionDataTable = new DataTable("TransactionTable");
        List<SqlParameter> _params = new List<SqlParameter>();
        SqlParameter _param = new SqlParameter();
        string _errorMessage = "";

        _param.ParameterName = "@CycleFilename";
        _param.Value = _pCycleFilename;
        _param.SqlDbType = SqlDbType.VarChar;
        _params.Add(_param);

        _TransactionDataTable = this.m_dataBaseService.GetDataTable(CommandType.StoredProcedure, "usp_TransactionTable_SelectByCycleFilname", _params);

        _excelExport.ExportToExcel(this.GetConfigurationValue("EXPORTPATH") + "Exported_" + _pCycleFilename, _TransactionDataTable, _pCycleFilename, ref _errorMessage);
    }

    public string GetConfigurationValue(string _pConfigurationCode)
    {
        string _ConfigurationValue = "";
        List<SqlParameter> _params = new List<SqlParameter>();
        SqlParameter _param = new SqlParameter();
        DataTable _ResultDataTable = new DataTable("DataTable");
        _param.ParameterName = "@ConfigurationCode";
        _param.SqlDbType = SqlDbType.VarChar;
        _param.Value = _pConfigurationCode;

        _params.Add(_param);
        _ResultDataTable = this.m_dataBaseService.GetDataTable(CommandType.StoredProcedure, "usp_ConfigurationTable_GetConfigValue", _params);

        if (_ResultDataTable.Rows.Count > 0)
        {
            _ConfigurationValue = _ResultDataTable.Rows[0]["ConfigurationValue"].ToString();

            if (!Directory.Exists(_ConfigurationValue))
            {
                Directory.CreateDirectory(_ConfigurationValue);
            }

            
        }
        else
        {
            _ConfigurationValue = "";
        }

        return @_ConfigurationValue;

    }

    public DTODocDeliveryTransactionList GetDocDeliveryDetailsByDeliveryNo(string _pDeliveryNo)
    {
        DTODocDeliveryTransaction _result = new DTODocDeliveryTransaction();
        DTODocDeliveryTransactionList _resultList = new DTODocDeliveryTransactionList();
        List<SqlParameter> _params = new List<SqlParameter>();
        SqlParameter _param = new SqlParameter();
        DataTable _ResultDataTable = new DataTable("DataTable");
        _param.ParameterName = "@DeliveryNo";
        _param.SqlDbType = SqlDbType.VarChar;
        _param.Value = _pDeliveryNo;

        _params.Add(_param);
        _ResultDataTable = this.m_dataBaseService.GetDataTable(CommandType.StoredProcedure, "usp_TransactionTable_SelectByDeliveryNo", _params);

        if (_ResultDataTable.Rows.Count > 0)
        {
            _result.DeliveryNo = _ResultDataTable.Rows[0]["DeliveryNo"].ToString();
            _result.SequenceNo = _ResultDataTable.Rows[0]["SequenceNo"].ToString();
            _result.AccountNo = _ResultDataTable.Rows[0]["AccountNo"].ToString();
            _result.FileName = _ResultDataTable.Rows[0]["FileName"].ToString();
            _result.SubscriberName = _ResultDataTable.Rows[0]["SubscriberName"].ToString();
            _result.Address = _ResultDataTable.Rows[0]["Address"].ToString();
            _result.MINSRN = _ResultDataTable.Rows[0]["MINSRN"].ToString();
            _result.Brand = _ResultDataTable.Rows[0]["Brand"].ToString();
            _result.ZipCode = _ResultDataTable.Rows[0]["ZipCode"].ToString();
            _result.Remarks = _ResultDataTable.Rows[0]["Remarks"].ToString();
            _result.DeliveryStatus = _ResultDataTable.Rows[0]["DeliveryStatus"].ToString();

            if (_ResultDataTable.Rows[0]["DeliveryStatusDate"] != DBNull.Value)
            {
                _result.DeliveryStatusDate = (DateTime)_ResultDataTable.Rows[0]["DeliveryStatusDate"];
            }
            
            _result.ReceivedBy = _ResultDataTable.Rows[0]["ReceivedBy"].ToString();
            _result.Relationship = _ResultDataTable.Rows[0]["Relationship"].ToString();
            _result.RTSNewAddress = _ResultDataTable.Rows[0]["RTSNewAddress"].ToString();
            _result.RTSReason = _ResultDataTable.Rows[0]["RTSReason"].ToString();
            _result.DCCode = _ResultDataTable.Rows[0]["DCCode"].ToString();
            _result.DCName = _ResultDataTable.Rows[0]["DCName"].ToString();
            _result.Messenger = _ResultDataTable.Rows[0]["Messenger"].ToString();
            _result.CycleFilename = _ResultDataTable.Rows[0]["CycleFileName"].ToString();
            _resultList.Add(_result);
        }

        return _resultList;
    }

    public bool InsertCycleFilename(string _pCycleFilename)
    {
        List<SqlParameter> _params = new List<SqlParameter>();
        SqlParameter _param = new SqlParameter();
        _param.ParameterName = "@CycleFilename";
        _param.SqlDbType = SqlDbType.VarChar;
        _param.Value = System.IO.Path.GetFileName(_pCycleFilename);

        _params.Add(_param);

        if (!this.HasDuplicateCycleFilename(_param.Value.ToString()))
        {
            this.m_dataBaseService.ExecuteProcedure("usp_CycleFilenameTable_Insert", _params);
        }
        else
        {
           
        }


        return true;

    }

    private bool HasDuplicateCycleFilename(string _pCycleFilename)
    {
        List<SqlParameter> _params = new List<SqlParameter>();
        SqlParameter _param = new SqlParameter();
        DataTable _resultDataTable = new DataTable("DataTable");
        _param.ParameterName = "@CycleFilename";
        _param.SqlDbType = SqlDbType.VarChar;
        _param.Value = System.IO.Path.GetFileName(_pCycleFilename);
        _params.Add(_param);

        _resultDataTable = this.m_dataBaseService.GetDataTable(CommandType.StoredProcedure, "usp_CycleFilenameTable_SelectByCycleName", _params);

        if (_resultDataTable.Rows.Count > 0) return true;
        else return false;
    }

    public DTOCycleFilenameList GetCycleFilenameList()
    {
        DataTable _resultDataTable = new DataTable("DataTable");
        DTOCycleFilename _resultCycleFilename;
        DTOCycleFilenameList _resultCycleFilenameList = new DTOCycleFilenameList();

        _resultDataTable = this.m_dataBaseService.GetDataTable(CommandType.StoredProcedure, "usp_CycleFilenameTable_Select", null);

        foreach (DataRow _row in _resultDataTable.Rows)
        {
            _resultCycleFilename  = new DTOCycleFilename();
            _resultCycleFilename.Filename = _row["CycleFilename"].ToString();
            _resultCycleFilenameList.Add(_resultCycleFilename);
        }

        return _resultCycleFilenameList;        
    }

    public DTOCycleFilenameList GetExportedCycleFilenameList()
    {
        DataTable _resultDataTable = new DataTable("DataTable");
        DTOCycleFilename _resultCycleFilename;
        DTOCycleFilenameList _resultCycleFilenameList = new DTOCycleFilenameList();

        _resultDataTable = this.m_dataBaseService.GetDataTable(CommandType.StoredProcedure, "usp_CycleFilenameTable_SelectExported", null);

        foreach (DataRow _row in _resultDataTable.Rows)
        {
            _resultCycleFilename = new DTOCycleFilename();
            _resultCycleFilename.Filename = _row["CycleFilename"].ToString();
            _resultCycleFilenameList.Add(_resultCycleFilename);
        }

        return _resultCycleFilenameList;
    }


    public double GetPercentageCompleted(string _pCycleFilename)
    {
        double _tmpResult = 0.00;

        List<SqlParameter> _params = new List<SqlParameter>();
        SqlParameter _param = new SqlParameter();
        DataTable _resultDataTable = new DataTable("DataTable");
        _param.ParameterName = "@CycleFilename";
        _param.SqlDbType = SqlDbType.VarChar;
        _param.Value = System.IO.Path.GetFileName(_pCycleFilename);
        _params.Add(_param);

        _resultDataTable = this.m_dataBaseService.GetDataTable(CommandType.StoredProcedure, "usp_TransactionTable_GetPercentageCompletedByCycleFilename", _params);

        if (_resultDataTable.Rows.Count > 0)
        {
            _tmpResult = Convert.ToDouble(_resultDataTable.Rows[0]["PercentageCompleted"]);
        }

        return _tmpResult;
    }

    public bool UpdateCycleFilenameStatus(string _pCycleFilename)
    {
        List<SqlParameter> _params = new List<SqlParameter>();
        SqlParameter _param = new SqlParameter();
        DataTable _resultDataTable = new DataTable("DataTable");

        _param.ParameterName = "@CycleFilename";
        _param.SqlDbType = SqlDbType.VarChar;
        _param.Value = System.IO.Path.GetFileName(_pCycleFilename);
        _params.Add(_param);

        this.m_dataBaseService.ExecuteProcedure("usp_CycleFilenameTable_Update", _params); 
        return true;
    }
}
