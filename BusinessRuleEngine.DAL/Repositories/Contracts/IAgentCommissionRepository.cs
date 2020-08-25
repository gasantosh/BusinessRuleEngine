using System.Collections.Generic;

using BusinessRuleEngine.DAL.Entities;
using BusinessRuleEngine.DAL.ResultObjects;

namespace BusinessRuleEngine.DAL.Repositories.Contracts
{
    public interface IAgentCommissionRepository : IRepository<AgentCommision>
    {
        IEnumerable<AgentTotalCommissionBo> GetTotalAgentCommision();
    }
}
