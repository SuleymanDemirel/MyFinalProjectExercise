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
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAllByCategoryId(2))// 2 numaralı kategorisindeki ürünleri getir.GetAll,GetByUnitPrice gibi istediğimiz gibi filtreleri.
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadLine();
        }
    }
}
