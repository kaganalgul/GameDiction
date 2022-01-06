using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class User : IdentityUser
    {
        public ICollection<Entry> Entries { get; set; }

        public ICollection<Topic> Topics { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
