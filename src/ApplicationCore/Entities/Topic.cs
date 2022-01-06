using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Topic : BaseEntity
    {
        public string Title { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }

        public User User { get; set; }

        public Category Category { get; set; }

        public ICollection<Entry> Entries { get; set; }
    }
}
