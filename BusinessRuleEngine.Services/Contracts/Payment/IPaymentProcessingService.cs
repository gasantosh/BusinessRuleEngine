using BusinessRuleEngine.Services.Bos.Payments;
using BusinessRuleEngine.Services.Bos.Responses;

namespace BusinessRuleEngine.Services.Contracts.Payment
{
    public interface IPaymentProcessingService
    {
        PaymentResponseBo Process(PaymentBo payment);
    }
}
