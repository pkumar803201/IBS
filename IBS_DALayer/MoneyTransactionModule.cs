using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace IBS_DALayer
{
    public class MoneyTransactionModule : IBSConnection
    {
        public void Deposit(int amount,int acctId)
        {
            int balance = 0,acctNo=0;
            try
            {
                IbsConnection.Open();
                IbsCommand.CommandText = "ShowById_Acc_Details @AccountId";
                IbsCommand.Connection = IbsConnection;
                IbsCommand.Parameters.AddWithValue("@AccountId", acctId);
                IbsDataAdapter.SelectCommand = IbsCommand;
                IbsDataAdapter.Fill(IbsDataset, "Account");

                foreach (DataRow item in IbsDataset.Tables[0].Rows)
                {
                    acctNo = (int)item[0];
                    balance = (int)item[3];
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
            try
            {
                balance = balance + amount;
                IbsConnection.Open();
                IbsCommand.CommandText = "Update_Acc_Details @AccountNumber,@AccountBalance";
                IbsCommand.Connection = IbsConnection;
                IbsCommand.Parameters.AddWithValue("@AccountNumber", acctNo);
                IbsCommand.Parameters.AddWithValue("@AccountBalance", balance);
                IbsCommand.ExecuteNonQuery();
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

        public void Withdrawal(int amount, int acctId)
        {
            int balance = 0, acctNo = 0;
            try
            {
                IbsConnection.Open();
                IbsCommand.CommandText = "ShowById_Acc_Details @AccountId";
                IbsCommand.Connection = IbsConnection;
                IbsCommand.Parameters.AddWithValue("@AccountId", acctId);
                IbsDataAdapter.SelectCommand = IbsCommand;
                IbsDataAdapter.Fill(IbsDataset, "Account");

                foreach (DataRow item in IbsDataset.Tables[0].Rows)
                {
                    acctNo = (int)item[0];
                    balance = (int)item[3];
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
            try
            {
                balance = balance - amount;
                IbsConnection.Open();
                IbsCommand.CommandText = "Update_Acc_Details @AccountNumber,@AccountBalance";
                IbsCommand.Connection = IbsConnection;
                IbsCommand.Parameters.AddWithValue("@AccountNumber", acctNo);
                IbsCommand.Parameters.AddWithValue("@AccountBalance", balance);
                IbsCommand.ExecuteNonQuery();
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
