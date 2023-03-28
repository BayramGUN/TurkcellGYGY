// See https://aka.ms/new-console-template for more information
using LinqIntro;

// LINQ: Lenguage INtegrated Query.

var products = new ProductService().GetProducts();

// var anonymousType = new { Name = "Türkay", Age = 42 };

var nameAndPriceList = from p in products
                        where p.Price < 4000
                        select new { Name = p.Name, Fiyat = p.Price };


nameAndPriceList.ToList().ForEach(x => Console.WriteLine($"{x.Name}\t..........{x.Fiyat}"));