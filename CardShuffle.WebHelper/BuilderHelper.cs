using Microsoft.Extensions.DependencyInjection;
using CardShuffle.Services;

namespace CardShuffle.WebHelper
{
    public static class BuilderHelper 
    {
        public static void AddCardShuffleServices(this IServiceCollection services)
        {
            services.AddSingleton<DummyService>();
        }
    }
}
