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
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommandRequest, CreateCommentCommandResponse>
    {
        private readonly DatabaseContext _db;
        public CreateCommentCommandHandler(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<CreateCommentCommandResponse> Handle(CreateCommentCommandRequest request, CancellationToken cancellationToken)
        {
            _db.Comments.Add(new Comment()
            { 
                Content = request.Content,
                NewsId = request.NewsId,
                UserId = request.UserId
            });

            await _db.SaveChangesAsync();

            return new CreateCommentCommandResponse()
            { 
                IsSuccess = true
            };
        }
    }
}
