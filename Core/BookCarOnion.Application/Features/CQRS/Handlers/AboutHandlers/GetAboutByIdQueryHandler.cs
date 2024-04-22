using BookCar.Domain.Entities;
using BookCarOnion.Application.Features.CQRS.Queries.AboutQueries;
using BookCarOnion.Application.Features.CQRS.Results.AboutResults;
using BookCarOnion.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAboutByIdQueryResult
            {
                AboutID = values.AboutID,
                AboutDescription = values.AboutDescription,
                AboutTitle = values.AboutTitle,
                AboutImageUrl = values.AboutImageUrl
            };
        }
    }
}
