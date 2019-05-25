using Microsoft.EntityFrameworkCore;
using SampleApp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApp.Repository.DataRepository
{
    public class DataRepository<T> : IDataRepository<T> where T: class
    {
        private readonly BloggingContext _context;
        private readonly DbSet<T> _dbSet;

        public DataRepository(BloggingContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        } 

        public IQueryable<T> Query()
        {
            return _dbSet.AsQueryable<T>();
        }
    }
}
