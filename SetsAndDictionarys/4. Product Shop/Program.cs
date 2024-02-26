var shops = new Dictionary<string, Dictionary<string, double>>();
string line;
while ((line = Console.ReadLine()) != "Revision")
{
    string[] productsInfo = line.Split(", ");
    string shop = productsInfo[0];
    string product = productsInfo[1];
    double price = double.Parse(productsInfo[2]);
    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new Dictionary<string, double>());
    }
    shops[shop].Add(product, price);
}
var orderedShops = shops.OrderBy(s => s.Key)
 .ToDictionary(x => x.Key, x => x.Value);

foreach (var (store , products) in orderedShops)
{
    Console.WriteLine($"{store}->");
    foreach(var (product, price) in products)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }
}
