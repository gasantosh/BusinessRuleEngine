using BusinessRuleEngine.Services.Bos.Agents;

namespace BusinessRuleEngine.Services.Contracts.Agent
{
    public interface IAgentService
    {
        void ReceieveCommission(AgentBo agent, double commission);
    }
}
