using ProductDataHub.DTOs;
using ProductDataHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDataHub.Mappers
{
    public class ProductMapper : IProductMapper
    {
        public ProductDto ToDto(Product product)
        {
            if (product != null)
                return new ProductDto { Id = product.Id };
            else
                return null;
        }

        public Product ToEntity(ProductDto productDto)
        {
            return new Product { Id = productDto.Id };
        }
    }
}
