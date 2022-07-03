using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTful.Domain
{
    public class Blog
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Post> Post { get; set; } = null!;
    }
}
