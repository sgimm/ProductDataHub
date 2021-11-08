using ProductDataHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDataHub.Repositories
{
    public class ProductRepository : RepositoryBase
    {
        public ProductRepository(ProductDbContext dbContext) : base(dbContext)
        {
        }

        public Product GetProductById(int id)
        {
            return null;
        }
    }
}
