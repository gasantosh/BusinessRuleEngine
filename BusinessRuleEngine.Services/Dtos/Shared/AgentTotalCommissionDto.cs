using System;

namespace BusinessRuleEngine.Services.Dtos.Shared
{
    public class AgentTotalCommissionDto
    {
        public Guid AgentId { get; set; }

        public string AgentName { get; set; }

        public double Amount { get; set; }
    }
}
