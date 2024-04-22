using BookCar.Domain.Entities;
using BookCarOnion.Application.Features.CQRS.Commands.BannerCommands;
using BookCarOnion.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class CreateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public CreateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBannerCommand command)
        {
            await _repository.CreateAsync(new Banner
            {
                BannerTitle = command.BannerTitle,
                BannerDescription = command.BannerDescription,
                BannerVideoDescription = command.BannerVideoDescription,
                BannerVideoUrl = command.BannerVideoUrl,
            });
        }
    }
}
