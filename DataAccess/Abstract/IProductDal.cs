using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract    //Here, you must add Entity project reference to DataAccess Project( DataAccess project: Class Library .Net Standard)!
{
    public interface IProductDal
    {
        List<Product> GetALL();
        void Add(Product product); // Interface methods are public as default.  
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);
    }
}
