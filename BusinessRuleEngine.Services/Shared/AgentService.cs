using System;

using BusinessRuleEngine.DAL.Entities;
using BusinessRuleEngine.DAL.Repositories.Contracts;
using BusinessRuleEngine.Services.Bos.Agents;
using BusinessRuleEngine.Services.Contracts.Agent;

namespace BusinessRuleEngine.Services.Shared
{
    public class AgentService : IAgentService
    {
        private readonly IAgentCommissionRepository agentCommissionRepository;

        public AgentService(IAgentCommissionRepository agentCommissionRepository)
        {
            this.agentCommissionRepository = agentCommissionRepository;
        }

        public void ReceieveCommission(AgentBo agent, double commission)
        {
            AgentCommision agentCommision = new AgentCommision 
            { 
                Id = Guid.NewGuid(), 
                AgentId = agent.Id, 
                CommissionAmount = commission, 
                DateTimeStamp = DateTime.UtcNow 
            };

            this.agentCommissionRepository.Add(agentCommision);
            this.agentCommissionRepository.Save();
        }
    }
}
