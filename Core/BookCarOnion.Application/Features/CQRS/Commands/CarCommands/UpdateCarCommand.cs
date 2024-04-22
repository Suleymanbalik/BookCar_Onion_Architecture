using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Commands.CarCommands
{
    public class UpdateCarCommand
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public string CarModel { get; set; }
        public string CarCoverImageUrl { get; set; }
        public int CarMileage { get; set; }
        public string CarTransmission { get; set; }
        public int CarSeat { get; set; }
        public int CarLuggage { get; set; }
        public string CarFuel { get; set; }
        public string CarBigImageUrl { get; set; }
    }
}
