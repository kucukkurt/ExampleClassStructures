using System;
using System.Collections.Generic;

namespace ExampleUseListOf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            List<Products> productsArray = new List<Products>();


            Products[] products = new Products[10];


            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    products[i] = new Products();

                    Console.Write("Id girişi :");
                    products[i].Id = Convert.ToInt32(Console.ReadLine());


                    productsArray.Add(products[i]);
                }
            }

            Console.WriteLine("Id Araması :");
            int search = Convert.ToInt32(Console.ReadLine());


            for (int Idx = 0; Idx < products.Length; Idx++)
            {
                if (search == productsArray[Idx].Id)
                {
                    Console.Write("Aradığınız ürün bilgileri :");
                    Console.WriteLine(productsArray[Idx].Id);
                }
            }
 
            //Console.WriteLine(products[0].Id);
            //Console.WriteLine(products[0].CategoryId);

            //Console.WriteLine(products[0].Name);

            //Console.WriteLine(products[0].Price);


        }
    }
}
