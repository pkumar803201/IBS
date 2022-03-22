using System;
using IBS_DALayer;
using IBS_BALayer;
using System.Data;
using EntityLayer;
namespace IBS_UILayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //MoneyTransactionModule money = new MoneyTransactionModule();
                //money.Deposit(1000, 10004001);
                //MoneyTransactionValidation transactionValidation = new MoneyTransactionValidation();
                //transactionValidation.MoneyDeposit(1100, 1000401);
                //money.Withdrawal(1000, 10004001);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Just To Check Function is Working or Not

            //ReportModule rm = new ReportModule();
            //DataSet ds = new DataSet();
            //ds = rm.DisplayTransactionReport();
            //foreach (DataRow r in ds.Tables[0].Rows)

            //{
            //    Console.WriteLine("======================================");
            //    Console.WriteLine($"Transaction Id  :{r[0]}");
            //    Console.WriteLine($"SenderAccount Number  :{r[1]}");
            //    Console.WriteLine($"Customer Name  :{r[2]}");
            //    Console.WriteLine($"Amount  :{r[3]}");
            //    Console.WriteLine($"RecieverAccountNo  :{r[4]}");
            //    Console.WriteLine($"TransactionType  :{r[5]}");
            //    Console.WriteLine("==================================");

            //}

            //ds = rm.DisplayTransactionReportByAccountNo(11111);
            //foreach (DataRow r in ds.Tables[0].Rows)
            //{
            //    Console.WriteLine("======================================");
            //    Console.WriteLine($"Transaction Id  :{r[0]}");
            //    Console.WriteLine($"SenderAccount Number  :{r[1]}");
            //    Console.WriteLine($"Customer Name  :{r[2]}");
            //    Console.WriteLine($"Amount  :{r[3]}");
            //    Console.WriteLine($"RecieverAccountNo  :{r[4]}");
            //    Console.WriteLine($"TransactionType  :{r[5]}");
            //    Console.WriteLine("==================================");
            //}
            //Console.WriteLine("before main");
            MainScreen mainScreen = new MainScreen();
            mainScreen.User();
        }
    }
}
