using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsCollab.CustomExceptions
{
    public class DataNotFound : Exception
    {
        public DataNotFound(string message) : base(message) { }
    }
}
