using Fundementals_Assignment;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        GameInfo gameInfo = new GameInfo();

        // Number of games Section
        int numberOfGames = gameInfo.MetaData.Count;
        Console.WriteLine("Number of games: " + numberOfGames);

        // Most Frequent Genre Section
        var genreFrequency = gameInfo.MetaData
            .GroupBy(info => info.Genre)
            .OrderByDescending(group => group.Count())
            .First();
        string mostFrequentGenre = genreFrequency.Key;
        Console.WriteLine("Most frequent genre: " + mostFrequentGenre);

        // Here's where we count the number if characters that are in the map name
        var mapNamesWithMostChars = gameInfo.MetaData
            .SelectMany(info => info.MapNames)
            .Select(name => new
            {
                MapName = name,
                CharCount = name.Replace(" ", "").Length
            })
            .OrderByDescending(item => item.CharCount)
            .First();
        int maxChars = mapNamesWithMostChars.CharCount;
        Console.WriteLine("Map name with the most characters (excluding spaces):");
        Console.WriteLine($"Map Name: {mapNamesWithMostChars.MapName}, Characters: {maxChars}");

        // The Dictionary thing that uses Id as the Key
        Dictionary<int, Info> idDictionary = gameInfo.MetaData.ToDictionary(info => info.Id);
        Console.WriteLine("Dictionary using Id as Key:");
        foreach (var kvp in idDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value.Name}");
        }

        // Map's with "z" in the name
        var mapNamesWithZ = gameInfo.MetaData
            .SelectMany(info => info.MapNames)
            .Where(name => name.Contains("z"))
            .ToList();
        Console.WriteLine("Map names with the letter 'z':");
        foreach (var name in mapNamesWithZ)
        {
            Console.WriteLine(name);
        }
    }
}
