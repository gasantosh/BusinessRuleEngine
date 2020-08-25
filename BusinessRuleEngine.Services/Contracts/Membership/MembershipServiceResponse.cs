using BusinessRuleEngine.Enums;

namespace BusinessRuleEngine.Services.Contracts.Membership
{
    public class MembershipServiceResponse
    {
        public string ErrorMessage { get; set; }

        public MembershipServiceResponseType MembershipServiceResponseType { get; set; }
    }
}
