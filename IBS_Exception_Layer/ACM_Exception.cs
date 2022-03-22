using System;
using System.Collections.Generic;
using System.Text;

namespace IBS_Exception_Layer
{
    public class ACM_Exception : Exception
    {

        public ACM_Exception()
           : base()
        {
        }

        public ACM_Exception(string message)
            : base(message)
        {
        }
        public ACM_Exception(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
