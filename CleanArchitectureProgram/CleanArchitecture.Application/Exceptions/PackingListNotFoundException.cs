using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Exceptions
{
    public class PackingListNotFoundException : PackItException
    {
        public PackingListNotFoundException(Guid id) : base($"Packing list with id '{id}' wasn't found")
        {
        }
    }
}
