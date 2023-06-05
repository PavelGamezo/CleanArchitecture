using CleanArchitecture.Domain.Constants;
using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Policies
{
    public record PolicyData(TravelDays TravelDays, GenderEnum Gender, ValueObjects.Temperature Temperature, Localization Localization);
}
