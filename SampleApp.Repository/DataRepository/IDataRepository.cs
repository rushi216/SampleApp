using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApp.Repository.DataRepository
{
    public interface IDataRepository<T> where T: class
    {
        IQueryable<T> Query();
    }
}
