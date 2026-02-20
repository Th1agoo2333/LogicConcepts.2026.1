namespace Share;

public static class ConsoleExtension
{
    public static int GetInt(string message)
    {
        Console.Write(message);
        var NumberString = Console.ReadLine();
        if (int.TryParse(NumberString, out int NumberInt))
        {
            return NumberInt;
        }
        
    }

    public static string? GetValidOptions(string message, List<string> options)
    {
        Console.Write(message);
        var answer = Console.ReadLine();
        if (options.Any(x => x.Equals(answer,StringComparison.CurrentCultureIgnoreCase)))
        {
            return answer;
        }
        return null;
    }
}
