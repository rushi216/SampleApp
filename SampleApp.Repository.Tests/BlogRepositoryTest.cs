using Microsoft.Extensions.DependencyInjection;
using Moq;
using SampleApp.DomainModel.Models;
using SampleApp.Repository.DataRepository;
using SampleApp.Repository.Modules.Blogging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SampleApp.Repository.Tests
{
    public class BlogRepositoryTest : IClassFixture<DependencyFixture>
    {
        private readonly ServiceCollection _serviceCollection;

        public BlogRepositoryTest(DependencyFixture dependencyFixture)
        {
            _serviceCollection = dependencyFixture.ServiceCollection;
        }

        [Fact]
        public async Task GetAllBlogsTest()
        {
            var dataRepositoryMock = new Mock<IDataRepository<Blog>>();

            var blogList = new List<Blog>();

            blogList.Add(new Blog() { Id = 1, Url = "2" });

            dataRepositoryMock.Setup(x => x.Query()).Returns(blogList.AsQueryable());

            _serviceCollection.AddScoped<IDataRepository<Blog>>(x=> dataRepositoryMock.Object);

            var serviceProvider = _serviceCollection.BuildServiceProvider();

            var blogRepository = serviceProvider.GetService<IBlogRepository>();

            var blogs = await blogRepository.GetAllBlogsAsync();

            Assert.True(true);
        }
    }
}
