using CleanArchitecture.Application.DTO;
using CleanArchitecture.Application.Queries;
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
    internal sealed class SearchPackingListsHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListDto>>
    {
        private readonly DbSet<PackingListReadModel> _packingLists;

        public SearchPackingListsHandler(ReadDbContext dbContext)
        {
            _packingLists = dbContext.PackingLists;
        }

        public async Task<IEnumerable<PackingListDto>> HandleAsync(SearchPackingLists query)
        {
            var dbQuery = _packingLists.Include(q => q.Items)
                                       .AsQueryable();

            if(query.SearchPhrase is not null)
            {
                // We are searching PackingListReadModel like our SearchPhrase
                dbQuery = dbQuery.Where(q => Microsoft.EntityFrameworkCore.EF.Functions.Like(q.Name, query.SearchPhrase));
            }

            return await dbQuery.Select(q => q.AsDto())
                                .AsNoTracking()
                                .ToListAsync();
        }
    }
}
