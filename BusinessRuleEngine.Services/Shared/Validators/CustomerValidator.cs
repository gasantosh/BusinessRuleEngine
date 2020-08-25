using BusinessRuleEngine.Common.Messages;
using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Bos.Customers;
using BusinessRuleEngine.Services.Contracts.Membership;

namespace BusinessRuleEngine.Services.Shared.Validators
{
    public static class CustomerValidator
    {
        public static bool Validate(this CustomerBo customer, ILocalizedMessageProvider localizedMessageProvider, out MembershipServiceResponse response)
        {
            response = null;

            if (customer == null)
            {
                response = new MembershipServiceResponse
                {
                    ErrorMessage = localizedMessageProvider.GetCustomerCannotBeEmptyMessage,
                    MembershipServiceResponseType = MembershipServiceResponseType.Failure
                };

                return false;
            }

            if (string.IsNullOrWhiteSpace(customer.Email))
            {
                response = new MembershipServiceResponse
                {
                    ErrorMessage = localizedMessageProvider.GetCustomerEmailCannotBeEmptyMessage,
                    MembershipServiceResponseType = MembershipServiceResponseType.Failure
                };

                return false;
            }

            if (customer.Membership == null)
            {
                response = new MembershipServiceResponse
                {
                    ErrorMessage = localizedMessageProvider.GetMembershipCannotBeEmptyMessage,
                    MembershipServiceResponseType = MembershipServiceResponseType.Failure
                };

                return false;
            }

            return true;
        }
    }
}
