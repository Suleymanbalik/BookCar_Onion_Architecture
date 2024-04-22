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
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BannerID);
            values.BannerTitle = command.BannerTitle;
            values.BannerDescription = command.BannerDescription;
            values.BannerVideoDescription = command.BannerVideoDescription; 
            values.BannerVideoUrl = command.BannerVideoUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
