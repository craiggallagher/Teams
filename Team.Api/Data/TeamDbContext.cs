using Microsoft.EntityFrameworkCore;
using Team.Api.Models;
using TeamEntity = Team.Api.Models.Team;

namespace Team.Api.Data
{
    public class TeamDbContext: DbContext
    {
        public TeamDbContext(DbContextOptions<TeamDbContext> options) : base(options)
        {
        }
        public DbSet<TeamEntity> Teams { get; set; } = null!;
    }
}
