using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SampleApp.DomainModel.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public int BlogId { get; set; }

        [ForeignKey("BlogId")]
        public Blog Blog { get; set; }
    }
}
