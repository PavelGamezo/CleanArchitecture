using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Common
{
    public abstract class PackItException : Exception
    {
        public PackItException(string message) : base(message)
        {
        }
    }
}
