using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Events
{
    public record PackingItemAdded(PackingList PackingList, PackingItem PackingItem) : IDomainEvent;
}
