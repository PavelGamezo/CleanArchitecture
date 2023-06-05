using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Exceptions
{
    public class InvalidTemperatureException : PackItException
    {
        public double Temperature { get; set; }

        public InvalidTemperatureException(double temperature) : base($"Value {temperature} is invalid temperature.")
            => Temperature = temperature;
    }
}
