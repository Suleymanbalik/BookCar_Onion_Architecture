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
    public class UpdateCarCommandHandler
    {
        public readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID);
            values.CarFuel = command.CarFuel;
            values.CarSeat = command.CarSeat;
            values.CarBigImageUrl = command.CarBigImageUrl;
            values.CarCoverImageUrl = command.CarCoverImageUrl;
            values.CarLuggage = command.CarLuggage;
            values.CarMileage = command.CarMileage;
            values.CarModel = command.CarModel;
            values.CarTransmission = command.CarTransmission;
            values.BrandID = command.BrandID;
            await _repository.UpdateAsync(values);
        }
    }
}
