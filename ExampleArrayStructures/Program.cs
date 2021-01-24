using System;

namespace ExampleArrayStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Products Example = new Products();

            Products[] productsArray = new Products[]
            {
                new Products{ },
                new Products{ },
                new Products{ }
            };


            productsArray[0].Id = 1;
            productsArray[0].CategoryId = 2;
            productsArray[0].Name = "Apple";
            productsArray[0].Price = 2.5;
            productsArray[0].UnitAmount = 150;

            Console.WriteLine(productsArray[0].Id);
        }
    }
}
