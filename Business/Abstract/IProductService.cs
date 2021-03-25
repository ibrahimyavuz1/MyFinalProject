using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract       //Here, you must add Entity and DataAccess project references to Business project(Business Project:Class Library .Net Standard)!
{
    //IResult: To void methods, because they don't contain any data.
    //IDataResult: To NOT void methods.
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>>GetProductDetails();
        IDataResult<Product> GetById(int id);
        IResult Add(Product product);
        IResult Update(Product product);
    }
}
