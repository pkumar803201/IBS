using System;
using System.Collections.Generic;
using System.Text;

namespace IBS_Exception_Layer
{
    public class RM_Exception :Exception
    {
        public RM_Exception()
           : base()
        {
        }

        public RM_Exception(string message)
            : base(message)
        {
        }
        public RM_Exception(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
