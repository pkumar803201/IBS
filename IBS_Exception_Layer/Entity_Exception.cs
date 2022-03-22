using System;
using System.Collections.Generic;
using System.Text;

namespace IBS_Exception_Layer
{
    public class Entity_Exception : Exception
    {

        public Entity_Exception()
           : base()
        {
        }

        public Entity_Exception(string message)
            : base(message)
        {
        }
        public Entity_Exception(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
