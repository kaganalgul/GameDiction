using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.CQRS.Commands.Response;

namespace Web.CQRS.Commands.Request
{
    public class CreateCommentCommandRequest : IRequest<CreateCommentCommandResponse>
    {
        public string Content { get; set; }

        public int NewsId { get; set; }

        public int UserId { get; set; }
    }
}
