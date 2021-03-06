using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{                  
    //SOLID
    //Open Closed Principle
    //Here, you must add Entity project, DataAccess project, Business project references to ConsoleUI project(ConsoleUI project: Console Application .Net Core)
    // If you have a sql client error, you write connection string wrongly in DataAccess.Concrete.EntityFramework.
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productmanager = new ProductManager(new EfProductDal());
            foreach (var product in productmanager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
