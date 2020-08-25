using BusinessRuleEngine.Common.Logger;
using BusinessRuleEngine.Common.Messages;
using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Bos.Payments;
using BusinessRuleEngine.Services.Bos.Responses;
using BusinessRuleEngine.Services.Contracts.Membership;
using BusinessRuleEngine.Services.Contracts.Payment;

namespace BusinessRuleEngine.Services.BusinessServices
{
    public class MembershipPaymentProcessingService : IPaymentProcessingService
    {
        private readonly IMembershipService membershipService;
        private readonly INotificationMembershipService notificatiionMembershipService;
        private readonly ILocalizedMessageProvider localizedMessageProvider;

        public MembershipPaymentProcessingService(
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
            var membershipServiceResponse = membershipService.Activate(payment.Customer);

            if (membershipServiceResponse.MembershipServiceResponseType == MembershipServiceResponseType.Failure)
            {
                Logger.Instance.Log(LoggerType.Error, membershipServiceResponse.ErrorMessage);

                return new PaymentResponseBo
                {
                    ErrorMessage = membershipServiceResponse.ErrorMessage,
                    PaymentResponseType = PaymentResponseType.Failure
                };
            }

            var notificationResponse = notificatiionMembershipService.ActivateNotify(payment.Customer);

            if (notificationResponse.MembershipServiceResponseType == MembershipServiceResponseType.Failure)
            {
                Logger.Instance.Log(LoggerType.Error, membershipServiceResponse.ErrorMessage);

                return new PaymentResponseBo
                {
                    ErrorMessage = membershipServiceResponse.ErrorMessage,
                    PaymentResponseType = PaymentResponseType.Failure
                };
            }

            Logger.Instance.Log(LoggerType.Information, this.localizedMessageProvider.GetMembershipPaymentSucessfulMessage);

            return new PaymentResponseBo
            {
                PaymentResponseType = PaymentResponseType.Success
            };
        }
    }
}
