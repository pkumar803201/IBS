using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Customer
    {
        public int Id { get; set; }
        public int Pass { get; set; }
        public int AcctId { get; set; }
        public Customer()
        {

        }

        public Customer(int id, int pass, int acctId)
        {
            Id = id;
            Pass = pass;
            AcctId = acctId;
        }
    }
}
