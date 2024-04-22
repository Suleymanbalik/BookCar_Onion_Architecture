﻿using BookCar.Domain.Entities;
using BookCarOnion.Application.Features.CQRS.Results.BrandResults;
using BookCarOnion.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBrandQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBrandQueryResult
            {
                BrandID = x.BrandID,
                BrandName = x.BrandName,
            }).ToList();
        }
    }
}
