using ProductDataHub.DTOs;
using ProductDataHub.Mappers;
using ProductDataHub.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDataHub.Services
{
    public class ProductService : IProductService
    {

        private ProductRepository _productRepository = null;
        private IProductMapper _productMapper = null;

        public ProductService(ProductDbContext productDbContext, IProductMapper productMapper)
        {
            _productRepository = new ProductRepository(productDbContext);
            _productMapper = productMapper;
        }

        public ProductDto GetProductById(int id)
        {
            return _productMapper.ToDto(_productRepository.GetProductById(id));
        }
    }
}
