using System;
using System.Collections.Generic;
using System.Text;

namespace IBS_Exception_Layer
{
    public class ICM_Exception : Exception
    {

        public ICM_Exception()
           : base()
        {
        }

        public ICM_Exception(string message)
            : base(message)
        {
        }
        public ICM_Exception(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
