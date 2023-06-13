using CleanArchitecture.Application.DTO;
using CleanArchitecture.Infrastucture.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastucture.Queries
{
    internal static class Extensions
    {
        public static PackingListDto AsDto(this PackingListReadModel readModel) 
            => new()
            {
                Id = readModel.Id,
                Name = readModel.Name,
                Localization = new LocalizationDto
                {
                    City = readModel.Localization.City,
                    Country = readModel.Localization.Country
                },
                Items = readModel.Items.Select(q => new PackingItemDto
                {
                    Name = q.Name,
                    Quantity = q.Quantity,
                    IsPacked = q.IsPacked
                })
            };
    }
}
