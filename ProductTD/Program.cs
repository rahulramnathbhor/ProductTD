using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product{Id=1,Name="HP Laptop",Price=35000},
                new Product{Id=2,Name="Dell Laptop",Price=35400},
                new Product{Id=3,Name="Lenovo Laptop",Price=35050},
                new Product{Id=4,Name="Sony Laptop",Price=34000},
                new Product{Id=5,Name="Accer Laptop",Price=31000}

            };
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

    }
}
