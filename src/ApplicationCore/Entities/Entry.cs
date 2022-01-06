using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Entry : BaseEntity
    {
        public int UserId { get; set; }

        public int TopicId { get; set; }

        public string Content { get; set; }

        public int LikesCount { get; set; }

        public int UnlikesCount { get; set; }

        public User User { get; set; }

        public Topic Topic { get; set; }
    }
}
