using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Comment : BaseEntity
    {
        public int UserId { get; set; }

        public int NewsId { get; set; }

        public string Content { get; set; }

        public User User { get; set; }

        public News News { get; set; }

    }
}
