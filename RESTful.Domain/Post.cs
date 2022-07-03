using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTful.Domain
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public Blog Blogs { get; set; } = null!;
    }
}
