using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Exceptions
{
    public class MissingLocalizationWeatherException : PackItException
    {
        public MissingLocalizationWeatherException(Localization localization) 
            : base($"Couldn't fatch weather data for localization {localization.Country} {localization.City}")
        {
        }
    }
}
