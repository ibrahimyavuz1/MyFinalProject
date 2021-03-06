using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract    //Here, you must add Entity project reference to DataAccess Project( DataAccess project: Class Library .Net Standard)!
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
