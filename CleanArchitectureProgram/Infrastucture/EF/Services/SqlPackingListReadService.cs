using CleanArchitecture.Application.DTO;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Infrastucture.EF.Contexts;
using CleanArchitecture.Infrastucture.EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastucture.EF.Services
{
    internal sealed class SqlPackingListReadService : IPackingListReadService
    {
        private readonly DbSet<PackingListReadModel> _packingList;

        public SqlPackingListReadService(ReadDbContext context)
        {
            _packingList = context.PackingLists;
        }

        public Task<bool> ExistsByName(string name)
            => _packingList.AnyAsync(q => q.Name == name);
    }
}
