using System;
using System.Collections.Generic;

namespace ExampleUseListOf_2
{
    class Program
    {
        static void Main(string[] args)
        {

                Products[] products = new Products[10];

                List<Products> productsArray = new List<Products> { };

                EntryInformation entryInformation = new EntryInformation();

                EntrySearch entrySearch = new EntrySearch();

            while (true)
            {
                Console.Write("Ürün girişi için 'e' , ürün aratmak için 's' tuşuna basınız :");
                char ch = Convert.ToChar(Console.ReadLine());

                if (ch == 'e')
                {
                    for (int i = 0; i < products.Length; i++)
                    {
                        if (products[i] == null)
                        {
                            products[i] = new Products();
                            entryInformation.EntryInfos(products[i]);

                            productsArray.Add(products[i]);
                            break;
                        }
                    }
                }
                else if (ch == 's')
                {
                    Console.Clear();

                    Console.Write("Lütfen Id giriniz : ");
                    string TempId = Console.ReadLine();

                    int Idx = 0;
                    bool Exist = false;

                    foreach (var Id in productsArray)
                    {
                        if (productsArray[Idx].Id == TempId)
                        {
                            Console.WriteLine("Id : {0}", productsArray[Idx].Id);
                            Console.WriteLine("Category Id : {0}", productsArray[Idx].CategoryId);
                            Console.WriteLine("Name : {0}", productsArray[Idx].Name);
                            Console.WriteLine("Price : {0}", productsArray[Idx].Price);
                            Console.WriteLine("Stock : {0}", productsArray[Idx].UnitAmount);

                            Exist = true;
                            break;
                        }
                        Idx++;
                    }

                    if (Exist == false)
                    {
                        Console.WriteLine("Girilen Id kaydı yoktur.");
                    }
                
                    //for (int i = 0; i <= products.Length; i++)
                    //{
                    //    if (TempId == i && products[i] != null)
                    //    {


                    //        Console.WriteLine("Id : {0}", products[i].Id);
                    //        Console.WriteLine("Category Id : {0}", products[i].CategoryId);
                    //        Console.WriteLine("Name : {0}", products[i].Name);
                    //        Console.WriteLine("Price : {0}", products[i].Price);
                    //        Console.WriteLine("Stock : {0}", products[i].UnitAmount);

                    //        break;

                    //    }
                    //    else
                    //    {

                    //        Console.WriteLine("Girilen Id kaydı yoktur.");

                    //        break;
                    //    }
                    //}

                }
                else
                {
                    Console.WriteLine("Yanlış seçim yapıldı.Lütfen tekrar deneyiniz.");
                }

            }
            
            
        }
    }
}
