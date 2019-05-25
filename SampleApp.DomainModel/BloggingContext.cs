using Microsoft.EntityFrameworkCore;
using SampleApp.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.DomainModel
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; }
    }
}