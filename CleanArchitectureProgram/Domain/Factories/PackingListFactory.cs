using CleanArchitecture.Domain.Constants;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Policies;
using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Factories
{
    public class PackingListFactory : IPackingListFactory
    {
        private readonly IEnumerable<IPackingItemPolicy> _policies;

        public PackingListFactory(IEnumerable<IPackingItemPolicy> policies)
        {
            _policies = policies;
        }

        public PackingList Create(PackingListId id, PackingListName name, Localization localization)
            => new(name, localization, id);

        public PackingList CreateWithDefaultItems(PackingListId id, PackingListName name, TravelDays days, GenderEnum gender,
            Temperature temperature, Localization localization)
        {
            var data = new PolicyData(days, gender, temperature, localization);
            var applicablePolicies = _policies.Where(policy => policy.isApplicable(data));

            var items = applicablePolicies.SelectMany(q=>q.GenerateItems(data));
            var packingList = Create(id, name, localization);
            packingList.AddItems(items);

            return packingList;
        }
    }
}
