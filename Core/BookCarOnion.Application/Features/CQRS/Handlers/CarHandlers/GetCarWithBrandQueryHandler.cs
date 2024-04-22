using BookCar.Domain.Entities;
using BookCarOnion.Application.Features.CQRS.Results.CarResults;
using BookCarOnion.Application.Interfaces;
using BookCarOnion.Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values =  _repository.GetCarsListWithBrands();
            return values.Select(x => new GetCarWithBrandQueryResult
            {
                CarID = x.CarID,
                CarBrandName =x.Brand.BrandName,
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
