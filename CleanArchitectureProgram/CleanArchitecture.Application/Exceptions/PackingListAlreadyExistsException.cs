using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Exceptions
{
    public class PackingListAlreadyExistsException : PackItException
    {
        public string Name { get; }

        public PackingListAlreadyExistsException(string name) : base($"Packing list with name '{name}' already exists")
        {
        }
    }
}
