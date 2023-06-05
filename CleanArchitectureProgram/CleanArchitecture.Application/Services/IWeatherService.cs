using CleanArchitecture.Application.DTO.External;
using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public interface IWeatherService
    {
        Task<WeatherDto> GetWeaterAsync(Localization localization);
    }
}
