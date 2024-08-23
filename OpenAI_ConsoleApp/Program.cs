using OpenAI_ConsoleApp.Service;

public class Program
{
    public static async Task Main(string[] args)
    {
        var openAIService = new OpenAIService();
        Console.WriteLine("Enter the place you want to know about : ");
        var prompt = Console.ReadLine();
        var result = await openAIService.GetResponseAsync(prompt);
        Console.WriteLine(result);
    }
}