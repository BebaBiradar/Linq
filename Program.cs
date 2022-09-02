using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToobjectDemo
{
    public  class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string CompanyNmae { get; set; }

        public override string ToString()
        {
            return $"{Id} -> {Name} -> {Price} -> {CompanyNmae}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> pruducts = new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Price=465,CompanyNmae="Dell"},
                new Product{Id=2,Name="Mouse",Price=455,CompanyNmae="lenovo"},
                new Product{Id=3,Name="Laptop",Price=4245,CompanyNmae="Dell"},
                new Product{Id=4,Name="Printer",Price=489,CompanyNmae="sony"},
                new Product{Id=5,Name="Mouse",Price=465,CompanyNmae="Dell"},
                new Product{Id=6,Name="keybord",Price=4685,CompanyNmae="Microsoft"},
                new Product{Id=7,Name="RAm 4gb",Price=405,CompanyNmae="Intel"},
                new Product{Id=8,Name="Mouse",Price=4465,CompanyNmae="Dell"},
                new Product{Id=9,Name="laptop",Price=2065,CompanyNmae="Sony"},
                new Product{Id=10,Name="speaker",Price=4465,CompanyNmae="Dell"},
            };

            var result1 = from p in pruducts 
                          select p;

            var result2 = from p in pruducts
                          where p.Price < 2000
                          select p;

            var result3 = from p in pruducts
                          where p.CompanyNmae.StartsWith("D")
                          select p;
            var result4 = from p in pruducts
                          where p.Price > 2000 && p.Price < 3000
                          select p;

            foreach(Product item in result3)
            {
                Console.WriteLine(item);
            }

            // Lambda expression
            var res = products.Where(p => p.Price < 2000).ToList();
            var res2 = products.Where(p => p.Price > 2000).OrderBy(x => x.Name).ToList();
            // retrive single record
            var res4 = products.Where(x => x.Id == 1).SingleOrDefault();
            var res3 = products.Where(x => x.Price < 2500).OrderBy(x => x.Price).ToList().Take(3);
            var res5 = products.Where(x => x.Price < 2500).OrderBy(x => x.Price).ToList().Skip(3);
        }
    }
}
