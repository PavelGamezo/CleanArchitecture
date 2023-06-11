﻿using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTO
{
    public class PackingListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Localization Localization { get; set; }
        public IEnumerable<PackingItemDto> Items { get; set; }
    }
}