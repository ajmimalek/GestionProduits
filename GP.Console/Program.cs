using System;
using GP.Domain;

namespace GP.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                ProductId = 1,
                Name = "Batata",
                Description = "tetgarmech",
                Price = 0.2,
                Quantity = 10,
                DateProd = DateTime.Today
            };
            System.Console.WriteLine(product);
        }
    }
}
