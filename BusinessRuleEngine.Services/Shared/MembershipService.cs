using BusinessRuleEngine.Common.Messages;
using BusinessRuleEngine.DAL.Repositories.Contracts;
using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Bos.Customers;
using BusinessRuleEngine.Services.Contracts.Membership;
using BusinessRuleEngine.Services.Shared.Validators;

namespace BusinessRuleEngine.Services.Membership
{
    public class MembershipService : IMembershipService
    {
        private readonly ILocalizedMessageProvider localizedMessageProvider;
        private readonly IMembershipRepository membershipRepository;

        public MembershipService(ILocalizedMessageProvider localizedMessageProvider, IMembershipRepository membershipRepository)
        {
            this.localizedMessageProvider = localizedMessageProvider;
            this.membershipRepository = membershipRepository;
        }

        public MembershipServiceResponse Activate(CustomerBo customer)
        {
            MembershipServiceResponse response;

            if (!customer.Validate(this.localizedMessageProvider, out response))
            {
                return response;
            }

            var membership = this.membershipRepository.GetByID(customer.Id);

            customer.Membership.IsActive = true;
            membership.IsActive = true;

            this.membershipRepository.Save();

            return new MembershipServiceResponse
            {
                MembershipServiceResponseType = MembershipServiceResponseType.Success
            };
        }

        public MembershipServiceResponse Upgrade(CustomerBo customer)
        {
            MembershipServiceResponse response;

            if (!customer.Validate(this.localizedMessageProvider, out response))
            {
                return response;
            }

            var membership = this.membershipRepository.GetByID(customer.Id);
            customer.Membership.MembershipType = MembershipType.Premium;
            membership.Type = MembershipType.Premium.ToString();
            this.membershipRepository.Save();

            return new MembershipServiceResponse
            {
                MembershipServiceResponseType = MembershipServiceResponseType.Success
            };
        }
    }
}
