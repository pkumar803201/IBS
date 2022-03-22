using System;
using System.Collections.Generic;
using System.Text;
using IBS_DALayer;
using System.Data;
using IBS_Exception_Layer;

namespace IBS_BALayer
{
    public class InterestCalculationValidation : IBSConnection
    {
        /// <summary>
        /// This functuins validates the account no in backend and checks the type of account
        /// </summary>
        /// <param name="AccountNo">takes in account no to check in backend</param>
        /// <returns>Status of calculate interest </returns>
        public string AccountValidationForInterest(int AccountNo)
        {
            try
            {
                if (AccountNo == null)
                {
                    throw new Exception("Insert Account Number");
                }
                IbsConnection.Open();
                IbsCommand.CommandText = "Show_Account_Details @AccountId";
                IbsCommand.Connection = IbsConnection;
                IbsCommand.Parameters.AddWithValue("@AccountId", AccountNo);

                IbsDataAdapter.SelectCommand = IbsCommand;
                IbsDataAdapter.Fill(IbsDataset, "AccountDetails");
                if (IbsDataset.Tables[0].Rows.Count <= 0)
                    throw new Exception("Record not found");
                else
                {
                    InterestCalculationModule interest = new InterestCalculationModule();
                    interest.CalculateInterest(IbsDataset, AccountNo);
                }
            }
            catch (ICM_Exception )
            {
                throw new ICM_Exception("The given account is not eligible");
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
            return "Unsuccessful";
        }





    }
}