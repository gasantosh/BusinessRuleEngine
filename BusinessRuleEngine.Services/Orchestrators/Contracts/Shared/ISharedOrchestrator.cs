using System;
using System.Collections.Generic;

using BusinessRuleEngine.Services.Dtos.Memberships;
using BusinessRuleEngine.Services.Dtos.Shared;

namespace BusinessRuleEngine.Services.Orchestrators.Contracts.Shared
{
    public interface ISharedOrchestrator
    {
        IEnumerable<MembershipDto> GetAllActiveMember();

        IEnumerable<AgentTotalCommissionDto> GetAgentTotalCommission();
    }
}
