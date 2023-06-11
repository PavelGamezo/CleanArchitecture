using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Common.Commands;
using CleanArchitecture.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Commands.Handlers
{
    public class DeletePackingListHandler : ICommandHandler<DeletePackingList>
    {
        private readonly IPackingListRepository _repository;

        public DeletePackingListHandler(IPackingListRepository repository) =>
            _repository = repository;

        public async Task HandleAsync(DeletePackingList command)
        {
            var packingList = await _repository.GetAsync(command.PackingListId);

            if(packingList == null)
            {
                throw new PackingListNotFoundException(command.PackingListId);
            }

            await _repository.DeleteAsync(packingList);
        }
    }
}
