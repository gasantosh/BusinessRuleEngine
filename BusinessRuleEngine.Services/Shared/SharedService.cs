using System.Collections.Generic;
using System.Linq;

using BusinessRuleEngine.DAL.Repositories.Contracts;
using BusinessRuleEngine.DAL.ResultObjects;
using BusinessRuleEngine.Services.Bos.Memberships;
using BusinessRuleEngine.Services.Shared.Contacts;

using AutoMapper;

namespace BusinessRuleEngine.Services.Shared
{
    public class SharedService : ISharedService
    {
        private readonly IAgentCommissionRepository agentCommissionRepository;
        private readonly IMembershipRepository membershipRepository;
        private readonly IMapper mapper;

        public SharedService(
            IAgentCommissionRepository agentCommissionRepository, 
            IMembershipRepository membershipRepository,
            IMapper mapper)
        {
            this.agentCommissionRepository = agentCommissionRepository;
            this.membershipRepository = membershipRepository;
            this.mapper = mapper;
        }

        public IEnumerable<MembershipBo> GetAllActiveMember()
        {
            var memnerships = this.membershipRepository.GetByFilter(x => x.IsActive);
            var membershipBos = memnerships.Select(s => this.mapper.Map<MembershipBo>(s));
            return membershipBos;
        }

        public IEnumerable<AgentTotalCommissionBo> GetAgentTotalCommission()
        {
            return this.agentCommissionRepository.GetTotalAgentCommision();
        }
    }
}
