using BusinessRuleEngine.Services.Bos.Payments;
using BusinessRuleEngine.Services.Bos.Responses;
using BusinessRuleEngine.Services.Contracts.Payment;
using BusinessRuleEngine.Services.Factories.Contracts;

namespace BusinessRuleEngine.Services.BusinessServices
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentFactory paymentFactory;

        public PaymentService(IPaymentFactory paymentFactory)
        {
            this.paymentFactory = paymentFactory;
        }

        public PaymentResponseBo Pay(PaymentBo payment)
        {
            var paymentProcessingService = this.paymentFactory.Create(payment.PaymentType);
            var response = paymentProcessingService.Process(payment);

            return response;
        }
    }
}
