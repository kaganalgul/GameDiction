using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.CQRS.Queries.Response;

namespace Web.CQRS.Queries.Request
{
    public class GetByCategoryIdTopicQueryRequest : IRequest<List<GetByCategoryIdTopicQueryResponse>>
    {
        public int CategoryId { get; set; }
    }
}
