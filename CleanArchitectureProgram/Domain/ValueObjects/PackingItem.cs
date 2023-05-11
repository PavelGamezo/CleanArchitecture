using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.ValueObjects
{
    public record PackingItem
    {
        public string Name { get; }
        public uint Quantity { get; }
        public bool IsPacked { get; private set; }

        public PackingItem(string name, uint quantity, bool isPacked)
        {
            Name = name;
            Quantity = quantity;
            IsPacked = isPacked;
        }
    }
}
