using CleanArchitecture.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public interface IPackingListReadService
    {
        Task<IEnumerable<PackingListDto>> SearchAsync(string searchPhrase);
        Task<bool> ExistsByName(string name);
    }
}
