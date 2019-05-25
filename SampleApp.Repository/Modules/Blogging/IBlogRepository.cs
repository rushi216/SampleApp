using SampleApp.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Repository.Modules.Blogging
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetAllBlogsAsync();
    }
}
