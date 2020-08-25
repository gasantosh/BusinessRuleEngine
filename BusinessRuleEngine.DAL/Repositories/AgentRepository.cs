using BusinessRuleEngine.DAL.Context;
using BusinessRuleEngine.DAL.Entities;
using BusinessRuleEngine.DAL.Repositories.Contracts;

namespace BusinessRuleEngine.DAL.Repositories
{
    public class AgentRepository : RepositoryBase<Agent>, IAgentRepository
    {
        public AgentRepository(BusinessRuleEngineContext context):
            base(context)
        {
        }       
    }
}
