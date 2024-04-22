﻿using BookCar.Domain.Entities;
using BookCarOnion.Application.Features.CQRS.Queries.BannerQueries;
using BookCarOnion.Application.Features.CQRS.Results.BannerResults;
using BookCarOnion.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetBannerByIdQueryResult
            {
                BannerID=values.BannerID,
                BannerDescription=values.BannerDescription,
                BannerTitle=values.BannerTitle,
                BannerVideoDescription=values.BannerVideoDescription,
                BannerVideoUrl = values.BannerVideoUrl              
            };
        }
    }
}