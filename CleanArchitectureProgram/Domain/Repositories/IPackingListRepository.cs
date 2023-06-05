using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Repositories
{
    public interface IPackingListRepository
    {
        Task<PackingList> GetAsync(PackingListId id);
        Task AddAsync(PackingList packingList);
        Task DeleteAsync(PackingList packingList);
        Task UpdateAsync(PackingList packingList);
    }
}
