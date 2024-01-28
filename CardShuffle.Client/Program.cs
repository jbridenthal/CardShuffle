using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

namespace CardShuffle.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddRadzenComponents();
            await builder.Build().RunAsync();
        }
    }
}
