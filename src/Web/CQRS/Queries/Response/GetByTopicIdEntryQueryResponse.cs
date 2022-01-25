using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.CQRS.Queries.Response
{
    public class GetByTopicIdEntryQueryResponse
    {
        public int UserId { get; set; }

        public string EntryContent { get; set; }
    }
}
