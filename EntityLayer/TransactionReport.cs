using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class TransactionReport
    {
        public int SenderAccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get; set; }
        public int RecieverAccountNo { get; set; }
        public string TransactionType { get; set; }

        public TransactionReport()
        {
            SenderAccountNo = 1234567890;
            CustomerName = "Default Name";
            Amount = 0D;
            RecieverAccountNo = 1234567890;
            TransactionType = "Default Type";
        }
        public TransactionReport(int SANo, string CName, double Amt, int RANo, string TType)
        {
            SenderAccountNo = SANo;
            CustomerName = CName;
            Amount = Amt;
            RecieverAccountNo = RANo;
            TransactionType = TType;
        }
    }
}
