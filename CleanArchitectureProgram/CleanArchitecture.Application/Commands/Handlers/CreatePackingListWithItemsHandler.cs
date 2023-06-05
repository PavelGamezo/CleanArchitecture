using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Common.Commands;
using CleanArchitecture.Domain.Exceptions;
using CleanArchitecture.Domain.Factories;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Commands.Handlers
{
    public class CreatePackingListWithItemsHandler : ICommandHandler<CreatePackingListWithItems>
    {
        private readonly IPackingListRepository _repository;
        private readonly IPackingListFactory _factory;
        private readonly IPackingListReadService _readService;
        private readonly IWeatherService _weatherService;

        public CreatePackingListWithItemsHandler(IPackingListRepository repository,
            IPackingListFactory factory, 
            IPackingListReadService readService,
            IWeatherService weatherService)
        {
            _repository = repository;
            _factory = factory;
            _readService = readService;
            _weatherService = weatherService;
        }

        public async Task HandleAsync(CreatePackingListWithItems command)
        {
            // ----------------- provides some sort of item potency -----------------
            var (id, name, days, gender, localizationWriteModel) = command;

            if(await _readService.ExistsByName(name))
            {
                throw new PackingListAlreadyExistsException(name);
            }

            // ----------------- get our weather from localization -----------------

            var localization = new Localization(localizationWriteModel.City, localizationWriteModel.Country);
            var weather = await _weatherService.GetWeaterAsync(localization);

            if (weather is null)
            {
                throw new MissingLocalizationWeatherException(localization);
            }

            // ----------------- create packingList -----------------

            var packingList = _factory.CreateWithDefaultItems(id, name, days, gender, weather.Temperature, localization);

            // ----------------- add packingList -----------------

            await _repository.AddAsync(packingList);
        }
    }
}
