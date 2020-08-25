using System.Collections.Generic;
using System.Linq;

using BusinessRuleEngine.Services.Dtos.Memberships;
using BusinessRuleEngine.Services.Dtos.Shared;
using BusinessRuleEngine.Services.Orchestrators.Contracts.Shared;
using BusinessRuleEngine.Services.Shared.Contacts;

using AutoMapper;

namespace BusinessRuleEngine.Services.Orchestrators.Shared
{
    public class SharedOrchestrator : ISharedOrchestrator
    {
        private readonly ISharedService sharedService;
        private readonly IMapper mapper;

        public SharedOrchestrator(
            ISharedService sharedService,
            IMapper mapper)
        {
            this.sharedService = sharedService;
            this.mapper = mapper;
        }

        public IEnumerable<MembershipDto> GetAllActiveMember()
        {
            var bos = this.sharedService.GetAllActiveMember();
            var dtos = bos.Select(this.mapper.Map<MembershipDto>);

            return dtos;
        }

        public IEnumerable<AgentTotalCommissionDto> GetAgentTotalCommission()
        {
            var bos = this.sharedService.GetAgentTotalCommission();

            var dtos = bos.Select(this.mapper.Map<AgentTotalCommissionDto>);

            return dtos;
        }
    }
}
