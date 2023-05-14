using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsCollab.CustomExceptions
{
    internal class UsernameAlreadyExists : Exception
    {
        public UsernameAlreadyExists(string message) : base(message) { }
    }
}
