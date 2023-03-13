// See https://aka.ms/new-console-template for more information
string[] products = new string[12];

Array.Resize(ref products, products.Length + 1);

List<string> productList = new List<string>
{
    "Tv",
    "Soundbar",
    "XBOX One"
};

List<string> shoppingCart = new List<string>();

char character = Convert.ToChar(Console.ReadLine().ToLower());


foreach(var product in productList)
{
    foreach(var c in product.ToLower())
        if(c == character){
            shoppingCart.Add(product);
            break;
        }
}

foreach(string entity in shoppingCart)
{
    productList.Remove(entity);
    Console.WriteLine(entity);
}

