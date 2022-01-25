using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.CQRS.Queries.Response
{
    public class GetByCategoryIdTopicQueryResponse
    {
        public int CategoryId { get; set; }

        public string TopicTitle { get; set; }
    }
}
