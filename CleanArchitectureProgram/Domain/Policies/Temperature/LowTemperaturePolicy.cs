using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Policies.Temperature
{
    public class LowTemperaturePolicy : IPackingItemPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>()
            {
                new("Winter hat", 1, true),
                new("Scatf", 1, true),
                new("Warm jacket", 1, true)
            };

        public bool isApplicable(PolicyData data)
            => data.Temperature < 100;
    }
}
