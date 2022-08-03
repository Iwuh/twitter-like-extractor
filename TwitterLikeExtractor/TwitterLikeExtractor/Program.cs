using System.Text.Json;

namespace TwitterLikeExtractor;

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: TwitterLikeExtractor.exe filename");
            return;
        }

        try
        {
            using JsonDocument har = JsonDocument.Parse(File.ReadAllText(args[0]));
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Could not open file '{ex.FileName}'.");
        }
        catch (JsonException)
        {
            Console.WriteLine($"Could not deserialize the HAR file.");
        }
    }
}