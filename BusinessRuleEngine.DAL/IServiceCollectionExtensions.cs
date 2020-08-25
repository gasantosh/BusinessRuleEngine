using BusinessRuleEngine.DAL.Context;
using BusinessRuleEngine.DAL.Repositories;
using BusinessRuleEngine.DAL.Repositories.Contracts;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessRuleEngine.DAL
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["sqlconnection:connectionString"];
            services.AddDbContext<BusinessRuleEngineContext>(o => o.UseSqlServer(connectionString));
            services.AddTransient<IAgentRepository, AgentRepository>();
            services.AddTransient<IAgentCommissionRepository, AgentCommissionRepository>();
            services.AddTransient<ILibraryRepository, LibraryRepository>();
            services.AddTransient<IMembershipRepository, MembershipRepository>();

            return services;
        }
    }
}
