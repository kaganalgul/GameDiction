using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.CQRS.Commands.Response;

namespace Web.CQRS.Commands.Request
{
    public class CreateNewsCommandRequest : IRequest<CreateNewsCommandResponse>
    {
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
