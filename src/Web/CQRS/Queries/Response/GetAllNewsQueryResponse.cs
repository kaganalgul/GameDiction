using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.CQRS.Queries.Response
{
    public class GetAllNewsQueryResponse
    {
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
