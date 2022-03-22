using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using IBS_DALayer;
using EntityLayer;

namespace IBS_BALayer
{
    public class AccountCreationValidation : IBSConnection
    {
        
        public bool ValidateAdmin(int id,int pass)
        {
            try

            {
                IbsConnection.Open();
                IbsCommand.CommandText = "pro_valid_admin @id,@pass";
                IbsCommand.Parameters.AddWithValue("@id", id);
                IbsCommand.Parameters.AddWithValue("@pass", pass);
                IbsCommand.Connection = IbsConnection;
                IbsDataAdapter.SelectCommand = IbsCommand;
                IbsDataAdapter.Fill(IbsDataset, "Admin");
                if (IbsDataset.Tables[0].Rows.Count <= 0)
                    return false;
                return true;
            }
            catch (Exception ex)

            {
                throw new Exception(ex.Message);
            }
            finally

            {
                IbsConnection.Close();
                IbsCommand.Parameters.Clear();
            }
        }
        public bool ValidateCustomer(int id, int pass,out int acctId)
        {
             acctId = 0;
            try
            {
                IbsConnection.Open();
                IbsCommand.CommandText = "pro_valid_Customer @id,@pass";
                IbsCommand.Parameters.AddWithValue("@id", id);
                IbsCommand.Parameters.AddWithValue("@pass", pass);
                IbsCommand.Connection = IbsConnection;
                IbsDataAdapter.SelectCommand = IbsCommand;
                IbsDataAdapter.Fill(IbsDataset, "Customer");
                if (IbsDataset.Tables[0].Rows.Count <= 0)
                    return false;

                foreach (DataRow item in IbsDataset.Tables[0].Rows)
                {
                    acctId = (int)item[0];
                }
                return true;
            }
            catch (Exception ex)

            {
                throw new Exception(ex.Message);
            }
            finally

            {
                IbsConnection.Close();
                IbsCommand.Parameters.Clear();
            }
        }
        public Customer ValidateCustomerDetails(AccountDetails ad,PersonalDetails pd,NomineeDetails nd)
        {
            Console.WriteLine("Please Wait...\nwe are validating details.....");
            Customer customer = new Customer();
            
            try
            {
                IbsConnection.Open();
                IbsCommand.CommandText = "validate_PanAndAadhar @pan,@aadhar";
                IbsCommand.Parameters.AddWithValue("@pan", pd.PAN);
                IbsCommand.Parameters.AddWithValue("@aadhar", pd.aadhar);
                IbsCommand.Connection = IbsConnection;
                IbsDataAdapter.SelectCommand = IbsCommand;
                IbsDataAdapter.Fill(IbsDataset, "Register");
                if (IbsDataset.Tables[0].Rows.Count <= 0)
                {
                    AccountCreationModule creationModule = new AccountCreationModule();
                    customer = creationModule.RegisteringCustomer(ad, pd, nd);
                    return customer;
                }
                else
                {
                    throw new Exception("Already register User ");
                }

            }
            catch (Exception ex)
            {
                if(ex.InnerException!=null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return customer;
        }
    }
}
