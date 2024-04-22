using BookCar.Domain.Entities;
using BookCarOnion.Application.Interfaces.CarInterfaces;
using BookCarOnion.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly BookCarContext _context;

        public CarRepository(BookCarContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }
    }
}
