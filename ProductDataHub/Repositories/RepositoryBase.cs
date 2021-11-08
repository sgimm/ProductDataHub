using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDataHub.Repositories
{
    public class RepositoryBase
    {

        protected ProductDbContext _dbContext = null;
        public RepositoryBase(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
