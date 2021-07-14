using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace DalPrint
{
    public class DalBase
    {
        string serverName;
        string dbName;
        #region dataMembers
        OleDbConnection dbConnection = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source =" + @"D:\Mishna Chabura\Mishna.mdb");
        OleDbDataAdapter dbDataAdapter;
        OleDbCommand dbCommand;
        #endregion
        public DalBase(string server, string db)
        {
            server = "Microsoft Access Database File (OLE DB)";
            db = "Mishna.mdb";
            serverName = server;
            dbName = db;
        }
        public void OpenDb()
        {
            OpenDb(serverName, dbName);
        }
        void OpenDb(string servername, string databasename)
        {
            dbName = databasename;
            serverName = servername;
            dbConnection = new OleDbConnection();
            dbConnection.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source =" + @"D:\Mishna Chabura\Mishna.mdb";
            dbConnection.Open();
        }
        public DataTable fillDataTable(string kod)
        {
         //   OpenDb();
            DataTable  table = new DataTable();
            string query = "SELECT masechet_name,date ,peruk,number,kod,mishna FROM process WHERE kod=" + int.Parse(kod)+" ORDER BY num";
            dbConnection.Open();
            dbCommand = new OleDbCommand(query);
            dbCommand.CommandTimeout = 300;
            dbDataAdapter = new OleDbDataAdapter(dbCommand);
            dbCommand.Connection = dbConnection;
            dbDataAdapter.Fill(table);
            dbConnection.Close();
            return table;
        }
        public DataTable fillCmb(/*string selectValue*/)
        {
            DataTable table = new DataTable();
            string query = "SELECT User_Name ,Kodz FROM Name";
            dbConnection.Open();
            dbCommand = new OleDbCommand(query);
            dbCommand.CommandTimeout = 300;
            dbDataAdapter = new OleDbDataAdapter(dbCommand);
            dbCommand.Connection = dbConnection;
            dbDataAdapter.Fill(table);
            dbConnection.Close();
            return table;
        }
        public DataTable ContinuUntilNumber(string kod)
        {
            DataTable table = new DataTable();
            string query = "SELECT number,kod FROM process WHERE kod=" + int.Parse(kod);
            dbConnection.Open();
            dbCommand = new OleDbCommand(query);
            dbCommand.CommandTimeout = 300;
            dbDataAdapter = new OleDbDataAdapter(dbCommand);
            dbCommand.Connection = dbConnection;
            dbDataAdapter.Fill(table);
            dbConnection.Close();
            return table;         
        }
        public int CountFiles(string kod)
        {
            string query = "SELECT max(num) FROM process WHERE kod=" + int.Parse(kod);
            dbConnection.Open();
            dbCommand = new OleDbCommand(query,dbConnection);
            object maxFile = dbCommand.ExecuteScalar();
            dbConnection.Close();
            return (int)maxFile;
        }
    }
}
