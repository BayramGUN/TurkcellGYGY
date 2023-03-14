// See https://aka.ms/new-console-template for more information
using ClassVSObject;
Console.WriteLine("Hello, World!");

Product product = new Product();
product.Name = "Laptop";

Product productTwo = product;

productTwo.Name = "Cell Phone";

Console.WriteLine(productTwo.Name.Equals(product.Name));