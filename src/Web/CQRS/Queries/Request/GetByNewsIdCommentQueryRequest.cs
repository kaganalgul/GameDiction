using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.CQRS.Queries.Response;

namespace Web.CQRS.Queries.Request
{
    public class GetByNewsIdCommentQueryRequest : IRequest<List<GetByNewsIdCommentQueryResponse>>
    {
        public int NewsId { get; set; }
    }
}
