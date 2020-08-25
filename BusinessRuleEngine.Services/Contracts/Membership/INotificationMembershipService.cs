using BusinessRuleEngine.Services.Bos.Customers;

namespace BusinessRuleEngine.Services.Contracts.Membership
{
    public interface INotificationMembershipService 
    {
        MembershipServiceResponse ActivateNotify(CustomerBo customer);

        MembershipServiceResponse UpgradeNotify(CustomerBo customer);
    }
}
