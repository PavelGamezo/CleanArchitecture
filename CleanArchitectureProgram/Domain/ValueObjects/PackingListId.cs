using CleanArchitecture.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.ValueObjects
{
    public class PackingListId
    {
        public Guid Value { get; private set; }

        public PackingListId(Guid value)
        {
            if(value == Guid.Empty)
            {
                throw new EmptyPackingListIdException();
            }

            Value = value;
        }

        public static implicit operator Guid(PackingListId id) 
            => id.Value;

        public static implicit operator PackingListId(Guid id) 
            => new(id);
    }
}
