using Microsoft.Extensions.DependencyInjection;
using Moq;
using SampleApp.Repository.DataRepository;
using SampleApp.Repository.Modules.Blogging;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Repository.Tests
{
    public class DependencyFixture
    {
        public ServiceCollection ServiceCollection { get; private set; }

        public DependencyFixture()
        {
            ServiceCollection = new ServiceCollection();

            ServiceCollection.AddScoped<IBlogRepository, BlogRepository>();
        }
    }
}
