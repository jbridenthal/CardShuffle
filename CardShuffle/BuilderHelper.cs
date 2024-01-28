using Microsoft.Extensions.DependencyInjection;
using CardShuffle.Services;
using CardShuffle.Data;
using Microsoft.EntityFrameworkCore;

namespace CardShuffle
{
    public static class BuilderHelper
    {
        public static void AddCardShuffleServices(this IServiceCollection services)
        {
            services.AddDbContextFactory<CardShuffleDBContext>(opt =>
                                opt.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=cardshuffle;Encrypt=False;Trusted_Connection=True;", b => b.MigrationsAssembly("CardShuffle.Data")));
            services.AddScoped<TeamService>();
        }
    }
}
