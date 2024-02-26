int n = int.Parse(Console.ReadLine());

var continents = new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split(' ')
        .ToArray();
    string continent = input[0];
    string country = input[1];
    string city = input[2];
    if (!continents.ContainsKey(continent))
    {
        continents.Add(continent, new Dictionary<string, List<string>>());
    }
    if (!continents[continent].ContainsKey(country))
    {
        continents[continent][country] = new List<string>();
    }
    continents[continent][country].Add(city);
}

foreach (var (continentName, countries) in continents)
{
    Console.WriteLine($"{continentName}:");
    foreach (var (countryName, cities) in countries)
    {
        Console.WriteLine($"{countryName} -> {string.Join(", ", cities)}");
    }
}