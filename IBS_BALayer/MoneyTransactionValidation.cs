using System;
using System.Collections.Generic;
using System.Text;
using IBS_DALayer;
namespace IBS_BALayer
{
    public class MoneyTransactionValidation : IBSConnection
    {
        public void MoneyDeposit(int amount, int acctId)
        {
            try
            {
                if(amount <= 0)
                {
                    throw new Exception("Amount should be grater than 0");
                }
                IbsConnection.Open();
                IbsCommand.CommandText = "ShowById_Acc_Details @AccountId";
                IbsCommand.Connection = IbsConnection;
                IbsCommand.Parameters.AddWithValue("@AccountId", acctId);
                IbsDataAdapter.SelectCommand = IbsCommand;
                IbsDataAdapter.Fill(IbsDataset, "Account");
                if (IbsDataset.Tables[0].Rows.Count <= 0)
                    throw new Exception("Record not found");
                else
                {
                    MoneyTransactionModule money = new MoneyTransactionModule();
                    money.Deposit(amount, acctId);
                } 
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
            finally
            {
                IbsConnection.Close();
                IbsCommand.Parameters.Clear();
                IbsDataset.Clear();
            }
        }
    }
}
