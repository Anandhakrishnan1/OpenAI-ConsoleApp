using OpenAI_API;
using OpenAI_API.Completions;
namespace OpenAI_ConsoleApp.Service
{
    public class OpenAIService
    {
        public OpenAIService()
        {

        }

        public async Task<string> GetResponseAsync(string prompt)
        {
            var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new InvalidOperationException("OpenAI API key is not set in environment variables.");
            }

            var openAIApi = new OpenAIAPI(apiKey);

            var request = new CompletionRequest
            {
                Prompt = $"Provide detailed information about the location: {prompt}. Include details such as historical significance, main attractions, and geographic features.",
                MaxTokens = 1000
            };
            var result = await openAIApi.Completions.CreateCompletionAsync(request);
            return result.Completions[0].Text;
        }
    }
}
