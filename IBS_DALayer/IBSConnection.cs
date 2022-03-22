using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace IBS_DALayer
{
    public class IBSConnection
    {
        public SqlConnection IbsConnection;
        public SqlCommand IbsCommand;
        public DataSet IbsDataset;
        public SqlDataAdapter IbsDataAdapter;
        public SqlCommandBuilder IbsCommandBuilder;


        public IBSConnection()
        {
            IbsConnection = new SqlConnection();
            IbsConnection.ConnectionString="server=LAPTOP-9R1V2B3f;database=InternetBankingSystem;trusted_connection=true";
            IbsCommand = new SqlCommand();
            IbsCommandBuilder = new SqlCommandBuilder();
            IbsDataset = new DataSet();
            IbsDataAdapter = new SqlDataAdapter(IbsCommand);

        }
    }

}
