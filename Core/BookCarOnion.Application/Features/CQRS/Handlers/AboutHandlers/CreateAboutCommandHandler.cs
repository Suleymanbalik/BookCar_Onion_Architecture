﻿using BookCar.Domain.Entities;
using BookCarOnion.Application.Features.CQRS.Commands.AboutCommands;
using BookCarOnion.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarOnion.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public CreateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutCommand command)
        {
            await _repository.CreateAsync(new About
            {
                AboutTitle = command.AboutTitle,
                AboutDescription = command.AboutDescription,
                AboutImageUrl = command.AboutImageUrl,
            });
        }
    }
}
