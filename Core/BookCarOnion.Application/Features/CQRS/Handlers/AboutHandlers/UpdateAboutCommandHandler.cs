using BookCar.Domain.Entities;
using BookCarOnion.Application.Features.CQRS.Commands.AboutCommands;
using BookCarOnion.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateAboutCommand command)
        {
            var values =await _repository.GetByIdAsync(command.AboutID);
            values.AboutDescription = command.AboutDescription;
            values.AboutImageUrl= command.AboutImageUrl;
            values.AboutTitle = command.AboutTitle;
            await _repository.UpdateAsync(values);
        }
    }
}
