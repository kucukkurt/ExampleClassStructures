using System;

namespace ExampleClassStructures
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Products product = new Products();

            Console.Write("Ürün Identifier girişi yapınız :");
            product.Id = Int32.Parse( Console.ReadLine());

            Console.Write("Ürün kategori Identifier girişi yapınız :");
            product.CategoryId = Int32.Parse(Console.ReadLine());

            Console.Write("Ürün ismi girişi yapınız :");
            product.Name = Console.ReadLine();

            Console.Write("Ürün fiyatı girişi yapınız :");
            product.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ürün stok adedi girişi yapınız :");
            product.UnitAmount = Int32.Parse(Console.ReadLine());
            

            ProductArray productArray = new ProductArray();

            productArray.AddArray(product);

        }

        class ProductArray
        {
            //need to be new class
           public void AddArray(Products productsArray)
        {
                Console.WriteLine(productsArray.Id);
                Console.WriteLine(productsArray.CategoryId);
                Console.WriteLine(productsArray.Name);
                Console.WriteLine(productsArray.Price);
                Console.WriteLine(productsArray.UnitAmount);

            }
        }

    }
}

