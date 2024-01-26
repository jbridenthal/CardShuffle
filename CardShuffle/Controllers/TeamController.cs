using CardShuffle.Models;
using CardShuffle.Services;
using Microsoft.AspNetCore.Mvc;

namespace CardShuffle.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {

        private TeamService _teamService;

        public TeamController( TeamService teamService)
        {
            _teamService = teamService;
        }


        [HttpPost(Name ="Team")]
        public async Task AddTeamAsync(Team team)
        {
            await _teamService.TeamSave(team);
        }
    }
}
