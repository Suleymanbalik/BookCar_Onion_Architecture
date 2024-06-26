﻿using BookCar.Domain.Entities;
using BookCarOnion.Application.Features.CQRS.Results.CategoryResults;
using BookCarOnion.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values =await _repository.GetAllAsync();
            return values.Select(x=> new GetCategoryQueryResult
            {                
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
            }).ToList();
        }
    }
}
