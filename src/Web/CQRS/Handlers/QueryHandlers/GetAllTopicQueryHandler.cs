using Infrastructure.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Web.CQRS.Queries.Request;
using Web.CQRS.Queries.Response;

namespace Web.CQRS.Handlers.QueryHandlers
{
    public class GetAllTopicQueryHandler : IRequestHandler<GetAllTopicQueryRequest, List<GetAllTopicQueryResponse>>
    {
        private readonly DatabaseContext _db;

        public GetAllTopicQueryHandler(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<List<GetAllTopicQueryResponse>> Handle(GetAllTopicQueryRequest request, CancellationToken cancellationToken)
        {
            return _db.Topics.Select(topic => new GetAllTopicQueryResponse()
            { 
                Title = topic.Title,
                UserId = topic.UserId
            }).ToList();
        }
    }
}
