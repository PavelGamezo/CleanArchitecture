using CleanArchitecture.Common.Commands;
using CleanArchitecture.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Commands
{
    public record CreatePackingListWithItems(Guid Id, string Name, int Days, GenderEnum Gender, 
        LocalizationWithModel Localization) : ICommand;

    public record LocalizationWithModel(string City, string Country);
}
