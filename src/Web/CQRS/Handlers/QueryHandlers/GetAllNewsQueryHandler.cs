using Infrastructure.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Web.CQRS.Queries.Request;
using Web.CQRS.Queries.Response;

namespace Web.CQRS.Handlers.QueryHandlers
{
    public class GetAllNewsQueryHandler : IRequestHandler<GetAllNewsQueryRequest, List<GetAllNewsQueryResponse>>
    {
        private readonly DatabaseContext _db;

        public GetAllNewsQueryHandler([FromServices]DatabaseContext db)
        {
            _db = db;
        }

        public async Task<List<GetAllNewsQueryResponse>> Handle(GetAllNewsQueryRequest request, CancellationToken cancellationToken)
        {
            return _db.News.Select(news => new GetAllNewsQueryResponse()
            {
                Title = news.Title,
                Content = news.Content
            }).ToList();
        }
    }
}
