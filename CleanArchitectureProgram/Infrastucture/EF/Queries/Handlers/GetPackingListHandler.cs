using CleanArchitecture.Application.DTO;
using CleanArchitecture.Application.Queries;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Common.Queries;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Infrastucture.EF.Contexts;
using CleanArchitecture.Infrastucture.EF.Models;
using CleanArchitecture.Infrastucture.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastucture.EF.Queries.Handlers
{
    internal sealed class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDto>
    {
        private readonly DbSet<PackingListReadModel> _packingLists;

        public GetPackingListHandler(ReadDbContext dbContext)
        {
            _packingLists = dbContext.PackingLists;
        }

        public Task<PackingListDto> HandleAsync(GetPackingList query) 
            => _packingLists.Include(q => q.Items)
                            .Where(q => q.Id == query.Id)
                            .Select(q => q.AsDto())
                            .AsNoTracking()
                            .SingleOrDefaultAsync();
    }
}
