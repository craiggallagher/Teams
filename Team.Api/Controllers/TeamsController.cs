using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;
using Team.Api.Data;
using Team.Api.DTOs;
using TeamEntity = Team.Api.Models.Team;

namespace Team.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly TeamDbContext _context;

        public TeamsController(TeamDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<TeamDto>>> GetTeams()
        {
            List<TeamDto> teams = await _context.Teams
                .Select(team => new TeamDto
                {
                    Id = team.Id,
                    Name = team.Name,
                    StadiumCapacity = team.StadiumCapacity,
                    EstablishedDate = team.EstablishedDate,
                    CrestUrl = team.CrestUrl
                }).ToListAsync();
            return Ok(teams);
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<TeamDto>> GetTeam(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }
            var teamDto = new TeamDto
            {
                Id = team.Id,
                Name = team.Name,
                StadiumCapacity = team.StadiumCapacity,
                EstablishedDate = team.EstablishedDate,
                CrestUrl = team.CrestUrl
            };
            return Ok(teamDto);
        }

        [HttpPost]

        public async Task<ActionResult<TeamDto>> CreateTeam(CreateTeamDto createTeamDto)
        {
            var team = new TeamEntity
            {
                Name = createTeamDto.Name,
                StadiumCapacity = createTeamDto.StadiumCapacity,
                EstablishedDate = createTeamDto.EstablishedDate,
                CrestUrl = createTeamDto.CrestUrl
            };
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();
            

            var teamDto = new TeamDto
            {
                Id = team.Id,
                Name = team.Name,
                StadiumCapacity = team.StadiumCapacity,
                EstablishedDate = team.EstablishedDate,
                CrestUrl = team.CrestUrl
            };
            return CreatedAtAction(nameof(GetTeam), new { id = team.Id }, teamDto);
        }
    }
}
