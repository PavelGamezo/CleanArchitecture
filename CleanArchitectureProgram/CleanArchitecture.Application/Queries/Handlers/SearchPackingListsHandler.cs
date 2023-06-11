using CleanArchitecture.Application.DTO;
using CleanArchitecture.Common.Queries;
using CleanArchitecture.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Queries.Handlers
{
    public class SearchPackingListsHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListDto>>
    {
        private readonly IPackingListRepository _repository;

        public Task<IEnumerable<PackingListDto>> HandleAsync(SearchPackingLists query)
        {
            throw new Exception();
        }
    }
}
