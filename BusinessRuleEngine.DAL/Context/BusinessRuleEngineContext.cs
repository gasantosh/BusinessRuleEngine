using BusinessRuleEngine.DAL.Entities;

using Microsoft.EntityFrameworkCore;

namespace BusinessRuleEngine.DAL.Context
{
    public class BusinessRuleEngineContext : DbContext
    {
        public BusinessRuleEngineContext(DbContextOptions options)
           : base(options)
        {
        }

        public DbSet<Agent> Agents { get; set; }

        public DbSet<Membership> Memberships { get; set; }

        public DbSet<Library> Libraries { get; set; }

        public DbSet<AgentCommision> AgentCommisions { get; set; }
    }
}
