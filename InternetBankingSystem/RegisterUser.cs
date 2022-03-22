using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using IBS_BALayer;
namespace IBS_UILayer
{
    public class RegsiterUser
    {
        
        Customer customerdetails = new Customer();
        PersonalDetails personal = new PersonalDetails();
        NomineeDetails nominee = new NomineeDetails();
        AccountDetails account = new AccountDetails();

        public void Register()
        {
            try
            {
                bool flag = true;
                RegisterPersonalDetails();
                Console.Clear();
                RegisterNomineeDetails();
                Console.Clear();
                RegisterAccountDetails();
                Console.Clear();
                PersonalDetails personalDetails=new PersonalDetails();
                AccountDetails accountDetails= new AccountDetails();
                NomineeDetails nomineeDetails = new NomineeDetails();
                try
                {
                    personalDetails = new PersonalDetails(personal.customerName, personal.PhoneNumber, personal.PAN, personal.aadhar, personal.DOB, personal.email, personal.address);
                }
                catch (Exception ex)
                {
                    flag = false;
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    accountDetails = new AccountDetails(account.BranchName, account.IFSCCode, account.AccountBalance, account.accountType);
                }
                catch (Exception ex)
                {
                    flag = false;
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    nomineeDetails = new NomineeDetails(nominee.NomineeName, nominee.Relation, nominee.PhoneNumber, nominee.nomineeAddress);
                }
                catch (Exception ex)
                {

                    flag = false;
                    Console.WriteLine(ex.Message);
                }
                if (flag)
                {
                    AccountCreationValidation accountCreation = new AccountCreationValidation();
                    customerdetails = accountCreation.ValidateCustomerDetails(accountDetails,personalDetails,nomineeDetails);
                    Console.WriteLine("your successfully register to the bank ");
                    Console.WriteLine("We are sending you your customerid and password ");
                    Console.WriteLine("Account ID  : " + customerdetails.AcctId);
                    Console.WriteLine("Customer ID : " + customerdetails.Id);
                    Console.WriteLine("Password    : " + customerdetails.Pass);
                }
                else
                {
                    MainScreen screen = new MainScreen();
                    screen.Customer();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Admin()
        {
            MainScreen mainscreen = new MainScreen();
            try
            {
                
                Console.WriteLine("Enter your Id : ");
                int userId = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter your Pass : ");
                int pass = Convert.ToInt32(Console.ReadLine());
                AccountCreationValidation validation = new AccountCreationValidation();
                if (validation.ValidateAdmin(userId, pass))
                {
                    Console.WriteLine("Successful login");
                    mainscreen.AdminFunctions();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("please enter valid credentials");
                    Console.WriteLine("-------------------------------");
                    mainscreen.User();
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Login()
        {
            try
            {
                MainScreen mainscreen = new MainScreen();
                Console.WriteLine("Enter your Id : ");
                int userId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Pass : ");
                int pass = Convert.ToInt32(Console.ReadLine());
                AccountCreationValidation validation = new AccountCreationValidation();
                if (validation.ValidateCustomer(userId, pass,out int acctid))
                {
                    Console.WriteLine("Successful login");
                    Customer customer = new Customer(userId,pass, acctid);
                    Console.WriteLine(customer.AcctId);
                    Console.ReadKey();
                    mainscreen.CustomerFunctions(customer); 
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("please enter valid credentials");
                    Console.WriteLine("-------------------------------");
                    mainscreen.Customer();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void RegisterPersonalDetails()
        {
            try
            {
                Console.WriteLine("Enter your Personal Details");
                Console.WriteLine("Please Enter your Name:");
                personal.CustomerName = Console.ReadLine();
                Console.WriteLine("Please Enter your Phone Number:");
                personal.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Please Enter your PAN details:");
                personal.PAN = Console.ReadLine();
                Console.WriteLine("Please Enter your Date Of Birth in YYYY/MM/DD Format:");
                personal.DOB = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Please Enter your Aadhar Card Info:");
                personal.Aadhar = Console.ReadLine();
                Console.WriteLine("Please Enter your Email Id:");
                personal.Email = Console.ReadLine();
                Console.WriteLine("Please Enter your Address:");
                personal.Address = Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void RegisterNomineeDetails()
        {
            try 
            { 
                Console.WriteLine("Enter the Details of your Nominee");
                Console.WriteLine("Please Enter your Nominee's Name:");
                nominee.NomineeName = Console.ReadLine();
                Console.WriteLine("Please Enter your Relationship with the Nominee:");
                nominee.Relation = Console.ReadLine();
                Console.WriteLine("Please Enter Phone number of Nominee");
                nominee.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Please Enter the Address of Nominee:");
                nominee.NomineeAddress = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RegisterAccountDetails()
        {
            try
            {
                Console.WriteLine("Enter the Details of your Branch");
                Console.WriteLine("Please Enter your Branch Name:");
                account.BranchName = Console.ReadLine();
                Console.WriteLine("Please Enter the IFSC code:");
                account.IFSCCode = Console.ReadLine();
                Console.WriteLine("Please Enter the deposit Amount **Please Note, the miinimum balance is 3000");
                account.AccountBalance = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter the Type of Account you wish to open: Fixed or Saving");
                account.AccountType = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
