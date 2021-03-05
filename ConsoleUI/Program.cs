using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{                                     //Here, you must add Entity project, DataAccess project, Business project references to ConsoleUI project(ConsoleUI project: Console Application .Net Core)
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productmanager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productmanager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
