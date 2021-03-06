using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal max, decimal min);
        IDataResult<Product> GetById(int id);
        IDataResult <List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
        

    }
}
