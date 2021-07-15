using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_EXCEPTION
{
    public class Lms_Exception:ApplicationException
    {
        public Lms_Exception() : base()
        {

        }
        public Lms_Exception(string message) : base(message)
        {

        }
    }
}
