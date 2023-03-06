using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class CustomException
    {
        public class Custom : Exception
        {
            public Custom(string message) : base(message) { }
        }
    }
}
