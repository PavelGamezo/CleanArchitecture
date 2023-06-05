using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Exceptions
{
    public class InvalidTravelDaysException : PackItException
    {
        public int Days { get; set; }

        public InvalidTravelDaysException(int days) : base($"Value {days} is invalid travel days.") 
            => Days = days;
    }
}
