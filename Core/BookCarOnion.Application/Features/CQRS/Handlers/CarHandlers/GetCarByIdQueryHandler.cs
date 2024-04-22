using BookCar.Domain.Entities;
using BookCarOnion.Application.Features.CQRS.Queries.CarQueries;
using BookCarOnion.Application.Features.CQRS.Results.CarResults;
using BookCarOnion.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                CarID = values.CarID,
                BrandID = values.BrandID,
                CarBigImageUrl = values.CarBigImageUrl,
                CarCoverImageUrl = values.CarCoverImageUrl,
                CarFuel = values.CarFuel,
                CarLuggage = values.CarLuggage,
                CarMileage = values.CarMileage,
                CarModel = values.CarModel,
                CarSeat = values.CarSeat,
                CarTransmission = values.CarTransmission,
            };
        }
    }
}
