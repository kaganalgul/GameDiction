using ApplicationCore.Entities;
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
    public class CreateTopicCommandHandler : IRequestHandler<CreateTopicCommandRequest, CreateTopicCommandResponse>
    {
        private readonly DatabaseContext _db;

        public CreateTopicCommandHandler(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<CreateTopicCommandResponse> Handle(CreateTopicCommandRequest request, CancellationToken cancellationToken)
        {
            _db.Topics.Add(new Topic()
            {
                Title = request.Title,
                UserId = request.UserId,
                CategoryId = request.CategoryId
            }
            );

            await _db.SaveChangesAsync();

            return new CreateTopicCommandResponse()
            { 
                IsSuccess = true
            };
        }
    }
}
