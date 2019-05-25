using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleApp.DomainModel.Models;
using SampleApp.Repository.DataRepository;

namespace SampleApp.Repository.Modules.Blogging
{
    public class BlogRepository : IBlogRepository
    {
        private readonly IDataRepository<Blog> _blogRepository;

        public BlogRepository(IDataRepository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<Blog>> GetAllBlogsAsync()
        {
            var blogs = await _blogRepository.Query().ToListAsync();

            return blogs;
        }
    }
}
