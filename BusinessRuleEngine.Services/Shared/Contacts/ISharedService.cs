using System.Collections.Generic;

using BusinessRuleEngine.DAL.ResultObjects;
using BusinessRuleEngine.Services.Bos.Memberships;

namespace BusinessRuleEngine.Services.Shared.Contacts
{
    public interface ISharedService
    {
        IEnumerable<AgentTotalCommissionBo> GetAgentTotalCommission();

        IEnumerable<MembershipBo> GetAllActiveMember();
    }
}
