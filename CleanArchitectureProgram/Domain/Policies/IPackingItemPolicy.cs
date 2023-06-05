using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Policies
{
    public interface IPackingItemPolicy
    {
        bool isApplicable(PolicyData data);

        IEnumerable<PackingItem> GenerateItems(PolicyData data);
    }
}
