using System;

namespace BusinessRuleEngine.DAL.ResultObjects
{
    public class AgentTotalCommissionBo
    {
        public Guid AgentId { get; set; }

        public string AgentName { get; set; }

        public double Amount { get; set; }
    }
}
