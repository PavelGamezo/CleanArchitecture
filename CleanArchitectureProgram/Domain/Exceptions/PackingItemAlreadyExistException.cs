using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Exceptions
{
    public class PackingItemAlreadyExistException : PackItException
    {
        public string ListName { get; }
        public string ItemName { get; }

        public PackingItemAlreadyExistException(string listName, string itemName) 
            : base($"Packing item {itemName} already exist in {listName}")
        {
            ListName = listName;
            ItemName = itemName;
        }
    }
}
