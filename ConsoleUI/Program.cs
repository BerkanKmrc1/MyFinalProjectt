using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var categoy in categoryManager.GetAll())
            {
                Console.WriteLine(categoy.CategoryName);
            }
        }

        private static void ProductTest()
        {
            
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + "/" + item.CategoryName);
                }
            }
            else
            {
                Console.Write(result.Message);
            }
                
        }
    }
}
