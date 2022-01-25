using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.CQRS.Commands.Response;

namespace Web.CQRS.Commands.Request
{
    public class CreateTopicCommandRequest : IRequest<CreateTopicCommandResponse>
    {
        public string Title { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }
    }
}
