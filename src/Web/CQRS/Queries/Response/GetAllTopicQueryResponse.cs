using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.CQRS.Queries.Response
{
    public class GetAllTopicQueryResponse
    {
        public string Title { get; set; }

        public int UserId { get; set; }
    }
}
