using CleanArchitecture.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.ValueObjects
{
    public record TravelDays
    {
        public int Value { get; private set; }

        public TravelDays(int value)
        {
            if (value is 0 or > 100)
            {
                throw new InvalidTravelDaysException(value);
            }

            Value = value;
        }

        public static implicit operator int(TravelDays days)
            => days.Value;

        public static implicit operator TravelDays(int days)
            => new(days);
    }
}
