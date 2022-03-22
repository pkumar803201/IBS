using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using IBS_Exception_Layer;

namespace IBS_DALayer
{
    public class InterestCalculationModule : IBSConnection
    {
        /// <summary>
        /// This Function fetches the data from the backend to validate the customer type and calculate the interest
        /// </summary>
        /// <param name="DSet">sending the data from backend after validation </param>
        /// <param name="AccountNo">Takes the account no for validation and </param>
        public void CalculateInterest(DataSet DSet, int AccountNo)
        {

            try
            {
                double AcoountBalance = Convert.ToDouble(DSet.Tables[0].Rows[0][3]);
                string AccountType = Convert.ToString(DSet.Tables[0].Rows[0][4]);
                Console.WriteLine(AcoountBalance);
                if (AccountType == "Saving" || AccountType == "saving")
                {
                    AcoountBalance = AcoountBalance + (AcoountBalance * 1 / 12 * 5) / 100;
                    UpdateInterest(AccountNo, AcoountBalance);
                }

                if (AccountType == "Fixed" || AccountType == "fixed")
                {
                    AcoountBalance = AcoountBalance + (AcoountBalance * 1 * 10) / 100;
                    UpdateInterest(AccountNo, AcoountBalance);
                }
            }
            catch(ICM_Exception )
            {
                throw new ICM_Exception("The given account is not eligible");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// This Function will Add the interest to the Account balance depending upon the type of account
        /// </summary>
        /// <param name="AccountNo">taking account no to verify the customer account type</param>
        /// <param name="Balance">taking balance from backend to update the balance</param>
        public void UpdateInterest(int AccountNo, double Balance)
        {
            try
            {
                IbsConnection.Open();
                IbsCommand.CommandText = "Update_Account_Balance_Details";
                IbsCommand.CommandType = CommandType.StoredProcedure;
                IbsCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                IbsCommand.Parameters.AddWithValue("@AccountBalance", Balance);
                IbsCommand.Connection = IbsConnection;

                int r = IbsCommand.ExecuteNonQuery();
                if (r == 0)
                {
                    throw new Exception("record not found");
                }
            }
            catch (ICM_Exception )
            {
                throw new ICM_Exception("The given account is not eligible");
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

    }
}