using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleUseListOf_2
{
    class EntryInformation
    {

        public void EntryInfos(Products product)
        {
            Console.Clear();

            Console.Write("Id girişi :");
            product.Id = Console.ReadLine();

            Console.Write("Category Id girişi :");
            product.CategoryId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ürün isim girişi :");
            product.Name = Console.ReadLine();

            Console.Write("Ürün fiyat girişi :");
            product.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ürün stok adedi girişi :");
            product.UnitAmount = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

        }
    }
}

