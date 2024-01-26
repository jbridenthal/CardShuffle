using CardShuffle.Data;
using CardShuffle.Models;

namespace CardShuffle.Services
{
    public class TeamService
    {
        private CardShuffleDBContext _dbContext;
        public TeamService(CardShuffleDBContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task TeamSave(params Team[] model)
        {
            await _dbContext.AddRangeAsync(model);
            await _dbContext.SaveChangesAsync();
        }
    }
}
