using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Exceptions
{
    public class PackingItemNotFoundException : PackItException
    {
        public PackingItemNotFoundException(string itemName) : base($"Packing item {itemName} was not found") 
        {
        }
    }
}
