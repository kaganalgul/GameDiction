using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.CQRS.Commands.Response;

namespace Web.CQRS.Commands.Request
{
    public class CreateEntryCommandRequest : IRequest<CreateEntryCommandResponse>
    {
        public string Content { get; set; }

        public int UserId { get; set; }

        public int TopicId { get; set; }
    }
}
