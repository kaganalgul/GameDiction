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
    public class GetByNewsIdCommentQueryHandler : IRequestHandler<GetByNewsIdCommentQueryRequest, List<GetByNewsIdCommentQueryResponse>>
    {
        private readonly DatabaseContext _db;

        public GetByNewsIdCommentQueryHandler(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<List<GetByNewsIdCommentQueryResponse>> Handle(GetByNewsIdCommentQueryRequest request, CancellationToken cancellationToken)
        {
            return _db.Comments.Where(comment => comment.NewsId.Equals(request.NewsId)).Select(x => new GetByNewsIdCommentQueryResponse()
            {
                UserId = x.UserId,
                CommentContent = x.Content
            }).ToList();
        }
    }
}
