using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Policies.Gender
{
    public class MaleGenderPolicy : IPackingItemPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>()
            {
                new("Laptop", 1, true),
                new("Beer", 10, true),
                new("Book", 5, true)
            };

        public bool isApplicable(PolicyData data)
            => data.Gender is Constants.GenderEnum.Male;
    }
}
