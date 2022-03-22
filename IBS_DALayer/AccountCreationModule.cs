using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using System.Data;
namespace IBS_DALayer
{
    public class AccountCreationModule : IBSConnection
    {
        public Customer RegisteringCustomer(AccountDetails ad, PersonalDetails pd, NomineeDetails nd)
        {
            Customer customer = new Customer();
            Random random = new Random();  
            int Cid = random.Next();
            int Pass = random.Next();
            try
            {
                IbsConnection.Open();
                IbsCommand.CommandText = "Insert_Customer_Details @CustomerId ,@Password";
                IbsCommand.Parameters.AddWithValue("@CustomerId", Cid);
                IbsCommand.Parameters.AddWithValue("@Password", Pass);
                IbsCommand.Connection = IbsConnection;
                IbsCommand.ExecuteNonQuery();
                IbsCommand.CommandText = "select top 1 AccountId,CustomerId,Password from Customer order by AccountId desc";
                IbsCommand.Connection = IbsConnection;
                IbsDataAdapter.SelectCommand = IbsCommand;
                IbsDataAdapter.Fill(IbsDataset, "customerac");
                foreach (DataRow item in IbsDataset.Tables[0].Rows)
                {
                    customer.AcctId = (int)item[0];
                    customer.Id = (int)item[1];
                    customer.Pass = (int)item[2];
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
                IbsConnection.Open();
                IbsCommand.CommandText = "Insert_Prs_Details @CustomerName ,@CustomerPhoneNo, @PAN ,@AadharNumber ,@DateOfBirth ,@CustomerEmailId ,@CustomerAddress  ,@AccountId ";
                IbsCommand.Parameters.AddWithValue("@CustomerName", pd.CustomerName);
                IbsCommand.Parameters.AddWithValue("@CustomerPhoneNo", pd.PhoneNumber);
                IbsCommand.Parameters.AddWithValue("@PAN", pd.PAN);
                IbsCommand.Parameters.AddWithValue("@AadharNumber", pd.Aadhar);
                IbsCommand.Parameters.AddWithValue("@DateOfBirth", pd.DOB);
                IbsCommand.Parameters.AddWithValue("@CustomerEmailId", pd.Email);
                IbsCommand.Parameters.AddWithValue("@CustomerAddress", pd.Address);
                IbsCommand.Parameters.AddWithValue("@AccountId", customer.AcctId);
                IbsCommand.Connection = IbsConnection;
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
            try
            {
                IbsConnection.Open();
                IbsCommand.CommandText = "Insert_Nom_Details @NomineeName,@Relation,@PhoneNumber,@NomineeAddress,@AccountId";
                IbsCommand.Parameters.AddWithValue("@NomineeName", nd.NomineeName);
                IbsCommand.Parameters.AddWithValue("@Relation", nd.Relation);
                IbsCommand.Parameters.AddWithValue("@PhoneNumber", nd.PhoneNumber);
                IbsCommand.Parameters.AddWithValue("@NomineeAddress", nd.nomineeAddress);
                IbsCommand.Parameters.AddWithValue("@AccountId", customer.AcctId);
                IbsCommand.Connection = IbsConnection;
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
            try
            {
                IbsConnection.Open();
                IbsCommand.CommandText = "Insert_Acc_Details @BranchName,@IFSCCode ,@AccountBalance ,@AccountType ,@AccountId ";
                IbsCommand.Parameters.AddWithValue("@BranchName", ad.BranchName);
                IbsCommand.Parameters.AddWithValue("@IFSCCode", ad.IFSCCode);
                IbsCommand.Parameters.AddWithValue("@AccountBalance", ad.AccountBalance);
                IbsCommand.Parameters.AddWithValue("@AccountType", ad.accountType);
                IbsCommand.Parameters.AddWithValue("@AccountId", customer.AcctId);
                IbsCommand.Connection = IbsConnection;
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
            return customer;
        }
    }
}
