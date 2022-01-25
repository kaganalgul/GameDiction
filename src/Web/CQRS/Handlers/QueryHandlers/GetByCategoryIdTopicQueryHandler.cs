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
    public class GetByCategoryIdTopicQueryHandler : IRequestHandler<GetByCategoryIdTopicQueryRequest, List<GetByCategoryIdTopicQueryResponse>>
    {
        private readonly DatabaseContext _db;

        public GetByCategoryIdTopicQueryHandler(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<List<GetByCategoryIdTopicQueryResponse>> Handle(GetByCategoryIdTopicQueryRequest request, CancellationToken cancellationToken)
        {
            return _db.Topics.Where(category => category.CategoryId.Equals(request.CategoryId)).Select(topic => new GetByCategoryIdTopicQueryResponse()
            { 
                CategoryId = topic.CategoryId,
                TopicTitle = topic.Title
            }).ToList();
        }
    }
}
