using BusinessRuleEngine.Common.Logger;
using BusinessRuleEngine.Common.Messages;
using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Bos.Payments;
using BusinessRuleEngine.Services.Bos.Responses;
using BusinessRuleEngine.Services.Contracts.Membership;
using BusinessRuleEngine.Services.Contracts.Payment;

namespace BusinessRuleEngine.Services.BusinessServices
{
    public class UpgradeMembershipPaymentProcessingService : IPaymentProcessingService
    {
        private readonly IMembershipService membershipService;
        private readonly INotificationMembershipService notificatiionMembershipService;
        private readonly ILocalizedMessageProvider localizedMessageProvider;

        public UpgradeMembershipPaymentProcessingService(
            IMembershipService membershipService, 
            INotificationMembershipService notificatiionMembershipService,
            ILocalizedMessageProvider localizedMessageProvider)
        {
            this.membershipService = membershipService;
            this.notificatiionMembershipService = notificatiionMembershipService;
            this.localizedMessageProvider = localizedMessageProvider;
        }

        public PaymentResponseBo Process(PaymentBo payment)
        {
            var membershipServiceResponse = membershipService.Upgrade(payment.Customer);

            if (membershipServiceResponse.MembershipServiceResponseType == MembershipServiceResponseType.Failure)
            {
                Logger.Instance.Log(LoggerType.Error, membershipServiceResponse.ErrorMessage);

                return new PaymentResponseBo
                {
                    ErrorMessage = membershipServiceResponse.ErrorMessage,
                    PaymentResponseType = PaymentResponseType.Failure
                };
            }

            var notificationResponse = notificatiionMembershipService.UpgradeNotify(payment.Customer);

            if (notificationResponse.MembershipServiceResponseType == MembershipServiceResponseType.Failure)
            {
                Logger.Instance.Log(LoggerType.Error, notificationResponse.ErrorMessage);

                return new PaymentResponseBo
                {
                    ErrorMessage = membershipServiceResponse.ErrorMessage,
                    PaymentResponseType = PaymentResponseType.Failure
                };
            }

            Logger.Instance.Log(LoggerType.Information, this.localizedMessageProvider.GetUpgradeMembershipPaymentSucessfulMessage);

            return new PaymentResponseBo
            {
                PaymentResponseType = PaymentResponseType.Success
            };
        }
    }
}
