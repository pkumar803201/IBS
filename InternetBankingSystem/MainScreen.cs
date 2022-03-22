using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using IBS_DALayer;
using IBS_BALayer;
using EntityLayer;
namespace IBS_UILayer
{
    public class MainScreen
    {
        RegsiterUser user = new RegsiterUser();
        public void User()
        {
            try
            {
                
                Console.WriteLine("**Welcome to the InternetBankingSystem**");
                Console.WriteLine("========Please Select the Portal ========");
                Console.WriteLine("     1.Admin Portal");
                Console.WriteLine("     2.Customer Portal");
                Console.WriteLine("     3.Exit");
                Console.Write("Enter Your Choice : ");
                string choice = Console.ReadLine();
                if (choice == "")
                {
                    Console.Clear();
                    Console.WriteLine("Pleaase enter a valid option");
                    User();
                }
                switch (choice)
                {
                    case "1":
                        user.Admin();
                        break;
                    case "2":
                        Customer();
                        break;
                    case "3":
                        Environment.Exit(1);
                        break;

                    default:
                        if (choice != "1" || choice != "2" || choice != "3")
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid option");
                            User();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Portal me Customer select krenge to ye call hoga
        public void Customer()
        {
            char c = 'n';
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("========CUSTOMER Portal======== ");
                    Console.WriteLine("     1.Login");
                    Console.WriteLine("     2.Register");
                    Console.WriteLine("     3.Rertun to MAIN MENU");
                    Console.WriteLine("     4.EXIT");
                    Console.Write("Enter Your Choice : ");
                    string choice = Console.ReadLine();
                    if (choice == "")
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid operation,Please select a valid option");
                        Customer();
                    }
                    else
                    {

                        switch (choice)
                        {
                            case "1":
                                user.Login();
                                break;
                            case "2":
                                user.Register();
                                break;
                            case "3":
                                User();
                                break;
                            case "4":
                                Environment.Exit(1);
                                break;
                            default:
                                if (choice != "1" || choice != "2" || choice != "3" || choice != "4")
                                {
                                    Console.WriteLine("Please enter a valid option");
                                    Customer();
                                }
                                break;

                        }
                    }
                    Console.WriteLine("Show the Customer Menu again (y/n) ?");
                    c = Convert.ToChar(Console.ReadLine());
                } while (c == 'y');

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //Portal me Admin select krenge to ye Admin function call hoga
        public void Admin()
        {

            char c = 'n';
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("========Admin Portal======== ");
                    Console.WriteLine("     1.Login");
                    Console.WriteLine("     2.Return to Main Screen");
                    Console.WriteLine("     3.Exit");

                    Console.Write("Please select an Option : ");
                    string choice = Console.ReadLine();
                    if (choice == "")
                    {
                        Console.Clear();
                        Console.WriteLine("Pleaase enter a valid option");
                        Admin();
                    }
                    else
                    {

                        switch (choice)
                        {
                            case "1":
                                user.Admin();
                                Console.WriteLine("Login Sucessfull");
                                break;
                            case "2":
                                User();
                                break;
                            case "3":
                                Environment.Exit(1);
                                break;

                            default:
                                if (choice != "1" || choice != "2" || choice != "3")
                                {
                                    Console.WriteLine("Please enter a valid option");
                                    Admin();
                                }
                                break;
                        }
                    }
                    Console.WriteLine("Show the Customer Menu again (y/n) ?");
                    c = Convert.ToChar(Console.ReadLine());
                } while (c == 'y');
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //Admin Login karne pe AdminFunctions Call hoga
        public void AdminFunctions()
        {
            char c = 'n';
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("**Welcome***");
                    Console.WriteLine("========Admin======== ");
                    Console.WriteLine("     1.Show All Customer ");
                    Console.WriteLine("     2.Get Customer Details By Account No");
                    Console.WriteLine("     3.Calculate Interest for Fixed Deposits");
                    Console.WriteLine("     4.Show All Transaction Details");
                    Console.WriteLine("     5.Show Transaction Details By Account Number");
                    Console.WriteLine("     6.Log Out");
                    Console.WriteLine("     7.Exit ");

                    Console.Write("Please select an Option : ");
                    string choice = Console.ReadLine();
                    if (choice == "")
                    {
                        Console.Clear();
                        Console.WriteLine("Pleaase enter a valid option");
                        AdminFunctions();
                    }
                    else
                    {

                        switch (choice)
                        {
                            case "1":
                                ShowAllCustomer();
                                break;
                            case "2":
                                ShowCustomerByAccountNo();
                                break;
                            case "3":
                                Console.WriteLine("Insert the Admin CalculateInterest Function here");
                                break;
                            case "4":
                                ShowAllTransaction();
                                break;
                            case "5":
                                ShowTransactionByAccountNo();
                                break;
                            case "6":
                                Console.WriteLine("Call the Admin Portal here");
                                break;
                            case "7":
                                Environment.Exit(1);
                                break;

                            default:
                                if (choice != "1" || choice != "2" || choice != "3" || choice != "4" || choice != "5" || choice != "6" || choice != "7")
                                {
                                    Console.WriteLine("Please enter a valid option");
                                    AdminFunctions();
                                }
                                break;
                        }
                    }
                    Console.WriteLine("Show the Customer Menu again (y/n) ?");
                    c = Convert.ToChar(Console.ReadLine());
                } while (c == 'y');
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void CustomerFunctions(Customer customer)
        {
            char c = 'n';
            try
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine(customer.AcctId);
                    Console.WriteLine("***Welcome Back***");
                    Console.WriteLine("============================ ");
                    Console.WriteLine("     1.Deposit");
                    Console.WriteLine("     2.Withdrawl");
                    Console.WriteLine("     3.Online Transfer");
                    Console.WriteLine("     4.Check Account Balance");
                    Console.WriteLine("     5.Show my Personal Details");
                    Console.WriteLine("     6.Update my personal details");
                    Console.WriteLine("     7.Update Password");
                    Console.WriteLine("     8.Logout");
                    Console.WriteLine("     9.EXIT");
                    Console.Write("Enter Your Choice : ");
                    string choice = Console.ReadLine();
                    if (choice == "")
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid operation,Please select a valid option");
                        CustomerFunctions(customer);

                    }
                    else
                    {

                        switch (choice)
                        {
                            case "1":
                                Console.WriteLine("Please insert the Deposit function here");
                                break;
                            case "2":
                                Console.WriteLine("Please insert the Withdrawl Fucntin here");
                                break;
                            case "3":
                                Console.WriteLine("Please insert the Transfer function here");
                                break;
                            case "4":
                                Console.WriteLine("Please insert the Check Account Balance function here");
                                break;
                            case "5":
                                Console.WriteLine("Please insert the Show Customer PersonalDetails and Account Details here function here");
                                break;
                            case "6":
                                Console.WriteLine("Please insert Update  Customer PersonalDetails   function here");
                                break;
                            case "7":
                                Console.WriteLine("Please insert the UpdatePassword Function");
                                break;
                            case "8":
                                Console.WriteLine("Please Insert the Customer() functions here so to jump  on customer portal");
                                break;
                            case "9":
                                Environment.Exit(1);
                                break;

                            default:
                                if (choice != "1" || choice != "2" || choice != "3" || choice != "4" || choice != "5" || choice != "6" || choice != "7" || choice != "8" || choice != "9")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Please enter a valid option");
                                    CustomerFunctions(customer);                                
                                }
                                break;


                        }
                    }
                    Console.WriteLine("Show the Customer Menu again (y/n) ?");
                    c = Convert.ToChar(Console.ReadLine());
                } while (c == 'y');

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void ShowAllTransaction()
        {
            ReportModule rm = new ReportModule();
            DataSet ds = new DataSet();
            ds = rm.DisplayTransactionReport();
            foreach (DataRow r in ds.Tables[0].Rows)

            {
                Console.WriteLine("======================================");
                Console.WriteLine($"Transaction Id  :{r[0]}");
                Console.WriteLine($"SenderAccount Number  :{r[1]}");
                Console.WriteLine($"Amount  :{r[2]}");
                Console.WriteLine($"RecieverAccountNo  :{r[3]}");
                Console.WriteLine($"TransactionType  :{r[4]}");
                Console.WriteLine($"DateOfTransaction : {r[5]}");
                Console.WriteLine("==================================");

            }
        }

        public void ShowTransactionByAccountNo()
        {
            ReportModule rm = new ReportModule();
            DataSet ds = new DataSet();
            ds = rm.DisplayTransactionReportByAccountNo(12345);
            foreach (DataRow r in ds.Tables[0].Rows)

            {
                Console.WriteLine("======================================");
                Console.WriteLine($"Transaction Id  :{r[0]}");
                Console.WriteLine($"SenderAccount Number  :{r[1]}");
                Console.WriteLine($"Amount  :{r[2]}");
                Console.WriteLine($"RecieverAccountNo  :{r[3]}");
                Console.WriteLine($"TransactionType  :{r[4]}");
                Console.WriteLine($"DateOfTransaction : {r[5]}");
                Console.WriteLine("==================================");

            }

        }

        public void ShowAllCustomer()
        {
            CustomerDetails customerDetais = new CustomerDetails();
            DataSet ds = new DataSet();
            ds = customerDetais.ShowAllCustomer();
            foreach (DataRow r in ds.Tables[0].Rows)

            {
                Console.WriteLine("======================================");
                Console.WriteLine($"Account Id  :{r[0]}");
                Console.WriteLine($"Account Number  :{r[1]}");
                Console.WriteLine($"Account Holder Name  :{r[2]}");
                Console.WriteLine($"Account Balance  :{r[3]}");
                Console.WriteLine($"PAN Number  :{r[4]}");
                Console.WriteLine("==================================");

            }
        }

        public void ShowCustomerByAccountNo()
        {
            CustomerDetails customerDetais = new CustomerDetails();
            DataSet ds = new DataSet();
            ds = customerDetais.DisplayCustomerByAccountNo(99330002);

            foreach (DataRow r in ds.Tables[0].Rows)

            {
                Console.WriteLine("======================================");
                Console.WriteLine($"Account Id  :{r[0]}");
                Console.WriteLine($"Account Number  :{r[1]}");
                Console.WriteLine($"Account Holder Name  :{r[2]}");
                Console.WriteLine($"Account Balance  :{r[3]}");
                Console.WriteLine($"PAN Number  :{r[4]}");
                Console.WriteLine("==================================");

            }

        }

    }
}