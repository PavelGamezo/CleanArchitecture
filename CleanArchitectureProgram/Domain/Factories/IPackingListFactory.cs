using CleanArchitecture.Domain.Constants;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Factories
{
    public interface IPackingListFactory
    {

        PackingList Create(PackingListId id, PackingListName name, Localization localization);

        PackingList CreateWithDefaultItems(PackingListId id, PackingListName name, TravelDays days, GenderEnum gender,
            Temperature temperature, Localization localization);
    }
}
