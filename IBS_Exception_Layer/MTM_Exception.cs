using System;
using System.Collections.Generic;
using System.Text;

namespace IBS_Exception_Layer
{
    public class MTM_Exception : Exception
    {

        public MTM_Exception()
           : base()
        {
        }

        public MTM_Exception(string message)
            : base(message)
        {
        }
        public MTM_Exception(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
