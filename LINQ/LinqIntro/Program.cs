// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using LinqIntro;

// LINQ: Lenguage INtegrated Query.

var products = new ProductService().GetProducts();

// var anonymousType = new { Name = "Türkay", Age = 42 };

var nameAndPriceList = from p in products
                        where p.Price < 4000
                        select new { Name = p.Name, Fiyat = p.Price };


Console.WriteLine("Result with normal query");
nameAndPriceList.ToList().ForEach(x => Console.WriteLine($"{x.Name}\t..........{x.Fiyat}"));

var stopWatch = Stopwatch.StartNew();

var sameResult = products.Where( p => p.Price < 4000 )
                        .Select( p => new { Name = p.Name, Price = p.Price} )
                        .ToList();

Console.WriteLine("Result with LINQ Extension methods");
sameResult.ForEach(x => Console.WriteLine($"{x.Name}\t..........{x.Price}"));

stopWatch.Stop();
Console.WriteLine($"{stopWatch.Elapsed.ToString()}");

stopWatch.Restart();
var same = products.ToList().Where( p => p.Price < 4000 )
                        .Select( p => new { Name = p.Name, Price = p.Price} );
Console.WriteLine("\n Result with LINQ Extension methods");
same.ToList().ForEach(x => Console.WriteLine($"{x.Name}\t..........{x.Price}"));
stopWatch.Stop();
Console.WriteLine($"{stopWatch.Elapsed.ToString()}");



Console.WriteLine("------------------- FirstOrDefault ---------------------");

var product = products?.FirstOrDefault(p => p.Id == 3);

Console.WriteLine($"product-3: {product?.Name}");

Console.WriteLine("------------------- SingleOrDefault ---------------------");
var sportProduct = products?.SingleOrDefault(p => p.Description == "Sportive");
Console.WriteLine($"product: {sportProduct?.Name}");

Console.WriteLine("----------------------- OrderBy -------------------------");
var orderedOne = products?.OrderBy(p => p.Price).ThenByDescending(st => st.Stock).ToList();

Console.WriteLine("OrderedBy Price from min. to max.");
orderedOne?.ForEach(orderedProduct => Console.WriteLine($"{orderedProduct.Name} {orderedProduct.Price}"));


Console.WriteLine("------------------ Aggregate Functions -------------------");
var avaragePrice = products?.Average(p => p.Price);
var totalItem = products?.Count(p => p.Description.Contains("Camping"));

Console.WriteLine($"price avarage: {avaragePrice}, sum = {products?.Sum(p => p.Price)}");
Console.WriteLine($"product description contains 'Camping': {totalItem}");

var expensiveProduct = products?.FirstOrDefault(p => p.Price == products?.Max(pr => pr.Price));
Console.WriteLine($"most expensive product: {expensiveProduct?.Name} {expensiveProduct?.Price}");




Console.WriteLine("------JOIN-------");
/// <summary>
/// <title>
/// JOIN
/// </title>
/// 
/// <description>
/// </description>
/// <example>
/// 
///     Products
///     Id      Name    CatId
///    --------------------------
///     1       A       1
///     2       B       3
/// 
/// 
///     Categories
///     Id      Name 
///    --------------
///     1       X    
///     2       Y    
///     3       Z    
///     
///     Output
///     Id      Name   Category
///    -------------------------
///     1       A         X
///     2       B         Z
/// </example>
/// </summary>


var service = new ProductService();
var categories = service.GetCategories();

var joinQuery = categories.Join(
                                    products,
                                    category => category,
                                    product => product?.Category,
                                    (category, product) => new { CategoryName = category.Name, ProductName = product.Name }
                                ).ToList();

joinQuery.ForEach(result => Console.WriteLine($"{result.ProductName} {result.CategoryName}"));


var joinAlternate = products.Select(pr => new {ProductName = pr.Name, CategoryName = pr.Category?.Name }).ToList();
joinAlternate.ForEach(result => Console.WriteLine($".....{result.ProductName} \t\t .....{result.CategoryName}"));


// GroupBy:

var productGroup = products.GroupBy
                            (
                                product => product.Category?.Name,
                                result => new { result.Name, result.Price },
                                (category, products) => new
                                {
                                    Key = category,
                                    HowMany = products.Count(),
                                    Cheapest = products.Min(x => x.Price),
                                    MostExpensive = products.Max(x => x.Price)
                                } 
                            );
Console.WriteLine("\n--------- GroupBy ------------");
foreach (var item in productGroup)
{
    Console.WriteLine($"Category: {item.Key}");
    Console.WriteLine($"HowMany: {item.HowMany}");
    Console.WriteLine($"Min Price: {item.Cheapest}");
    Console.WriteLine($"Max Price: {item.MostExpensive}");
}