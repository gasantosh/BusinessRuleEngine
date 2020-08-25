using System.Collections.Generic;
using System.Linq;

using BusinessRuleEngine.DAL.Context;
using BusinessRuleEngine.DAL.Entities;
using BusinessRuleEngine.DAL.Repositories.Contracts;
using BusinessRuleEngine.DAL.ResultObjects;

namespace BusinessRuleEngine.DAL.Repositories
{
    public class AgentCommissionRepository : RepositoryBase<AgentCommision>, IAgentCommissionRepository
    {
        public AgentCommissionRepository(BusinessRuleEngineContext context):
            base(context)
        {
        }

        public IEnumerable<AgentTotalCommissionBo> GetTotalAgentCommision()
        {
            var agentTotalCommisssion = (from ac in this.Context.AgentCommisions
                                         group ac by ac.AgentId into agac
                                         join ag in this.Context.Agents on agac.Key equals ag.Id
                                         select new AgentTotalCommissionBo 
                                         { 
                                             Amount= agac.Sum(s => s.CommissionAmount), 
                                             AgentName = ag.Name,
                                             AgentId = ag.Id
                                         }).ToArray();

            return agentTotalCommisssion;

        }
    }
}
