using BookCar.Domain.Entities;
using BookCarOnion.Application.Features.CQRS.Results.CarResults;
using BookCarOnion.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetCarQueryResult
            {
                CarID=x.CarID,
                BrandID = x.BrandID,
                CarBigImageUrl = x.CarBigImageUrl,
                CarCoverImageUrl = x.CarCoverImageUrl,
                CarFuel = x.CarFuel,
                CarLuggage = x.CarLuggage,
                CarMileage = x.CarMileage,
                CarModel = x.CarModel,
                CarSeat = x.CarSeat,
                CarTransmission = x.CarTransmission,
            }).ToList();
        }
    }
}
