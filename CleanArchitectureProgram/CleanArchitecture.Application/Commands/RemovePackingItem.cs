using CleanArchitecture.Common.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Commands
{
    public record RemovePackingItem(Guid Id, string Name) : ICommand;
}
