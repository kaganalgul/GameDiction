using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.CQRS.Queries.Response
{
    public class GetByNewsIdCommentQueryResponse
    {
        public int UserId { get; set; }

        public string CommentContent { get; set; }
    }
}
