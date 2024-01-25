using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using CardShuffle.WebHelper;

namespace CardShuffle.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddRadzenComponents();
            builder.Services.AddCardShuffleServices();
            await builder.Build().RunAsync();
        }
    }
}
