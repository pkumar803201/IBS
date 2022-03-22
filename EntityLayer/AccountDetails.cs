using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class AccountDetails
    {
        public int AccountNumber { get; set; }          //Account Number will be Auto-Generated in Backend;

        private string branchName;
        public string BranchName
        {
            get
            {
                return branchName;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a valid name");
                }
                else
                {
                    branchName = value;
                }

            }
        }

        private string IFSCcode;
        public string IFSCCode
        {
            get
            {
                return IFSCcode;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a valid Code");
                }
                else
                {
                    IFSCcode = value;
                }
            }
        }

        private int accountBalance;
        public int AccountBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                if (value < 3000)
                {
                    throw new Exception("Minimum Balance should be 3000");
                }
                else
                {
                    accountBalance = value;
                }
            }
        }

        public string accountType;
        public string AccountType
        {
            get
            {
                return accountType;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Account Should be either Savings or Fixed");
                }
                else
                {
                    accountType = value;
                }
            }
        }


        public int AccountId { get; set; }                              //AccountId Would be auto generated

        public AccountDetails()
        {
            //AccountNumber = 00000;
            //BranchName = "Not Mentioned";
            //IFSCCode = "Not Mentioned";
            //AccountBalance = 3000;
            //AccountType = "Not Mentioned";
            //AccountId = 0;


        }
        public AccountDetails(string branchname, string IFSCcode, int accountbalance, string accounttype)
        {
            BranchName = branchname;
            IFSCCode = IFSCcode;
            AccountBalance = accountbalance;
            AccountType = accounttype;
        }
    }
}