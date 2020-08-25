using BusinessRuleEngine.Common.Messages;
using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Bos.Customers;
using BusinessRuleEngine.Services.Contracts.Membership;
using BusinessRuleEngine.Services.Contracts.Notification;
using BusinessRuleEngine.Services.Shared.Validators;

namespace BusinessRuleEngine.Services.Shared
{
    public class NotificatiionMembershipService : INotificationMembershipService
    {
        private readonly IEmailService emailService;
        private readonly ILocalizedMessageProvider localizedMessageProvider;
        private const string activateMembershipMailSubject = "Activate Membership"; 
        private const string activateMembershipMailContent = "Menbership is activated";
        private const string upgradeMembershipMailSubject = "Upgrade Membership";
        private const string upgradeMembershipMailContent = "Menbership is upgraded";

        public NotificatiionMembershipService(IEmailService emailService, ILocalizedMessageProvider localizedMessageProvider)
        {
            this.emailService = emailService;
            this.localizedMessageProvider = localizedMessageProvider;
        }

        public MembershipServiceResponse ActivateNotify(CustomerBo customer)
        {
            MembershipServiceResponse response;

            if (!customer.Validate(this.localizedMessageProvider, out response))
            {
                return response;
            }

            emailService.SendMail(customer.Email, activateMembershipMailSubject, activateMembershipMailContent);

            return new MembershipServiceResponse
            {
                MembershipServiceResponseType = MembershipServiceResponseType.Success
            };
        }

        public MembershipServiceResponse UpgradeNotify(CustomerBo customer)
        {
            MembershipServiceResponse response;

            if (!customer.Validate(this.localizedMessageProvider, out response))
            {
                return response;
            }

            emailService.SendMail(customer.Email, activateMembershipMailSubject, activateMembershipMailContent);

            return new MembershipServiceResponse
            {
                MembershipServiceResponseType = MembershipServiceResponseType.Success
            };
        }
    }
}
