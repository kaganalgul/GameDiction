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
    public class CreateEntryCommandHandler : IRequestHandler<CreateEntryCommandRequest, CreateEntryCommandResponse>
    {
        private readonly DatabaseContext _db;
        public CreateEntryCommandHandler(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<CreateEntryCommandResponse> Handle(CreateEntryCommandRequest request, CancellationToken cancellationToken)
        {
            _db.Entries.Add(new Entry()
            { 
                Content = request.Content,
                UserId = request.UserId,
                TopicId = request.TopicId
            });

            await _db.SaveChangesAsync();

            return new CreateEntryCommandResponse()
            {
                IsSuccess = true
            };
        }
    }
}
