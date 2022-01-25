using ApplicationCore.Entities;
using Infrastructure.Identity;
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
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly AppIdentityDbContext _db;
        public CreateUserCommandHandler(AppIdentityDbContext db)
        {
            _db = db;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            _db.Users.Add(new User() 
            { 
                UserName = request.Username
            });

            await _db.SaveChangesAsync();

            return new CreateUserCommandResponse()
            {
                IsSuccess = true,
                Username = request.Username
            };
        }
    }
}
