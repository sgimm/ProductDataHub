using ProductDataHub.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDataHub.Services
{
    public interface IProductService
    {
        ProductDto GetProductById(int id);     
    }
}
