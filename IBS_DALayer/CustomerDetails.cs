using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IBS_DALayer
{
    public class CustomerDetails : IBSConnection
    {
        public DataSet ShowAllCustomer()
        {

            try

            {

                IbsConnection.Open();



                IbsCommand.CommandText = "Show_Customer_Details";

                IbsCommand.CommandType = CommandType.StoredProcedure;
                IbsCommand.Connection = IbsConnection;

                IbsDataAdapter.SelectCommand = IbsCommand;

                IbsDataAdapter.Fill(IbsDataset, "Customer");
                return IbsDataset;

            }


            catch (Exception ex)

            {

                // throw new Exception("Internal Server Error");

                throw new Exception(ex.Message);

            }


            finally

            {

                IbsConnection.Close();

            }

        }
        public DataSet DisplayCustomerByAccountNo(int AccountNo)
        {
            try

            {

                IbsConnection.Open();


                IbsCommand.CommandText = "Show_Customer_Details_By_AccountNo";

                IbsCommand.CommandType = CommandType.StoredProcedure;

                IbsCommand.Parameters.AddWithValue("@AccountNumber", AccountNo);

                IbsCommand.Connection = IbsConnection;

                IbsDataAdapter.SelectCommand = IbsCommand;

                IbsDataAdapter.Fill(IbsDataset, "Customer"); if (IbsDataset.Tables[0].Rows.Count <= 0)

                    throw new Exception("Record not found");
                return IbsDataset;

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