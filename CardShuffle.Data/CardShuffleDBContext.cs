using Microsoft.EntityFrameworkCore;
using CardShuffle.Models;

namespace CardShuffle.Data
{
    public class CardShuffleDBContext : DbContext
    {
        public DbSet<Team> Team { get; set; }

        public string DbPath { get; }


        public CardShuffleDBContext(DbContextOptions<CardShuffleDBContext> options)
            : base(options)
        {

        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite($"Data Source={DbPath}");


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=cardshuffle;Encrypt=False;Trusted_Connection=True;", b => b.MigrationsAssembly("CardShuffle.Data"));
    }
}