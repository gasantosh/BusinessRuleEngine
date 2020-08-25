using BusinessRuleEngine.Services.Bos.Customers;

namespace BusinessRuleEngine.Services.Contracts.Membership
{
    public interface IMembershipService
    {
        MembershipServiceResponse Activate(CustomerBo customer);

        MembershipServiceResponse Upgrade(CustomerBo customer);
    }
}
