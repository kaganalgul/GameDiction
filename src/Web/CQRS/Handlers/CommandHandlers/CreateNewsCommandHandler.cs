﻿using ApplicationCore.Entities;
using Infrastructure.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Web.CQRS.Commands.Request;
using Web.CQRS.Commands.Response;

namespace Web.CQRS.Handlers.CommandHandlers
{
    public class CreateNewsCommandHandler : IRequestHandler<CreateNewsCommandRequest, CreateNewsCommandResponse>
    {
        private readonly DatabaseContext _db;

        public CreateNewsCommandHandler(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<CreateNewsCommandResponse> Handle(CreateNewsCommandRequest request, CancellationToken cancellationToken)
        {
            _db.News.Add(new News()
            {
                Title = request.Title,
                Content = request.Content
            });

            await _db.SaveChangesAsync();

            return new CreateNewsCommandResponse()
            {
                IsSuccess = true
            };
        }
    }
}
