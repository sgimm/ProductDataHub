using ProductDataHub.DTOs;
using ProductDataHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDataHub.Mappers
{
    public interface IProductMapper
    {
        Product ToEntity(ProductDto productDto);

        ProductDto ToDto(Product product);
    }
}

