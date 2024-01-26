using Microsoft.Extensions.DependencyInjection;
using CardShuffle.Services;
using CardShuffle.Data;
using Microsoft.EntityFrameworkCore;

namespace CardShuffle.WebHelper
{
    public static class BuilderHelper 
    {
        public static void AddCardShuffleServices(this IServiceCollection services)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            var dbPath =  Path.Join(path, "cardshuffle.db");
            services.AddSingleton<DummyService>();
            services.AddDbContextFactory<CardShuffleDBContext>(opt =>
                                opt.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=cardshuffle;Encrypt=False;Trusted_Connection=True;", b => b.MigrationsAssembly("CardShuffle.Data")));
            services.AddScoped<TeamService>();
        }
    }
}
