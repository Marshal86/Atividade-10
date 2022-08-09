using AtividadePolimorf.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AtividadePolimorf
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Product> Lista = new List<Product>();
            
            Console.Write("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());

            for (int i =1; i <=n; i++)
            {
                Console.WriteLine($"Product {i} data: ");
                Console.Write("Common, used or imported(c / u / i) ? ");
                string choice = Console.ReadLine();
                Console.Write("Name ");
                string name = Console.ReadLine();
                Console.Write("Price ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                switch (choice)
                {
                   
                    case "i":


                        Console.Write("Customs fee: ");
                        double customFee = double.Parse(Console.ReadLine());


                        Lista.Add(new ImportedProduct(name, price, customFee));
                        break;

                    case "u":

                        Console.Write("Manufacture date (DD/MM/YYYY):");
                        DateTime data = DateTime.Parse(Console.ReadLine());

                        Lista.Add(new UsedProducted(name, price, data));
                        
                        break;

                    default:
                        Lista.Add(new Product(name, price));
                        break;

                }

                
                

            }

            foreach (Product list in Lista)
            {
                Console.WriteLine(list.PriceTag());
            }
        }
    }
}
