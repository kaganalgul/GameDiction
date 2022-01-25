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
    public class GetByTopicIdEntryQueryHandler : IRequestHandler<GetByTopicIdEntryQueryRequest, List<GetByTopicIdEntryQueryResponse>>
    {
        private readonly DatabaseContext _db;

        public GetByTopicIdEntryQueryHandler(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<List<GetByTopicIdEntryQueryResponse>> Handle(GetByTopicIdEntryQueryRequest request, CancellationToken cancellationToken)
        {
            return _db.Entries.Where(x => x.TopicId.Equals(request.TopicId)).Select(entry => new GetByTopicIdEntryQueryResponse()
            { 
                EntryContent = entry.Content,
                UserId = entry.UserId
            }).ToList();
        }
    }
}
