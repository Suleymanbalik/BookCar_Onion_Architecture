using BookCar.Domain.Entities;
using BookCarOnion.Application.Features.CQRS.Commands.CarCommands;
using BookCarOnion.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BrandID = command.BrandID,
                CarBigImageUrl = command.CarBigImageUrl,
                CarCoverImageUrl = command.CarCoverImageUrl,
                CarFuel = command.CarFuel,
                CarLuggage = command.CarLuggage,
                CarSeat = command.CarSeat,
                CarTransmission = command.CarTransmission,
                CarModel = command.CarModel,
                CarMileage = command.CarMileage,
            });
        }
    }
}
