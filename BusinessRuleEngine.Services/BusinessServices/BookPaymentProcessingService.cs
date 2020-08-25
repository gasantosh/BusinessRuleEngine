using BusinessRuleEngine.Common.Logger;
using BusinessRuleEngine.Common.Messages;
using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Bos.Payments;
using BusinessRuleEngine.Services.Bos.Responses;
using BusinessRuleEngine.Services.Contracts.Agent;
using BusinessRuleEngine.Services.Contracts.Commission;
using BusinessRuleEngine.Services.Contracts.PackagingSlip;

namespace BusinessRuleEngine.Services.BusinessServices
{
    public class BookPaymentProcessingService : BasePaymentProcessingService
    {
        private readonly IPackagingSlipService packagingSlipService;
        private readonly ILocalizedMessageProvider localizedMessageProvider;

        public BookPaymentProcessingService(
            IPackagingSlipService packagingSlipService, 
            ICommissionService commissionService, 
            IAgentService agentService,
            ILocalizedMessageProvider localizedMessageProvider)
            : base(commissionService, agentService)
        {
            this.packagingSlipService = packagingSlipService;
            this.localizedMessageProvider = localizedMessageProvider;
        }

        public override PaymentResponseBo Process(PaymentBo payment)
        {
            var packagingSlipServiceResponse = packagingSlipService.GenerateDuplicateSlip(payment.Department);

            if (packagingSlipServiceResponse.PackagingSlipGenerationResponseType == PackagingSlipGenerationResponseType.Failure)
            {
                Logger.Instance.Log(LoggerType.Error, packagingSlipServiceResponse.ErrorMessage);

                return new PaymentResponseBo
                {
                    ErrorMessage = packagingSlipServiceResponse.ErrorMessage,
                    PaymentResponseType = PaymentResponseType.Failure
                };
            }

            CalculateAgentCommission(payment);

            Logger.Instance.Log(LoggerType.Information, this.localizedMessageProvider.GetBookPaymentSucessfulMessage);

            return new PackagingSlipPaymentResponseBo
            {
                PaymentResponseType = PaymentResponseType.Success,
                PackagingSlip = packagingSlipServiceResponse.PackagingSlip
            };
        }
    }
}
