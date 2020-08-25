using BusinessRuleEngine.Services.Bos.Payments;
using BusinessRuleEngine.Services.Bos.Responses;

namespace BusinessRuleEngine.Services.Contracts.Payment
{
    public interface IPaymentService
    {
        PaymentResponseBo Pay(PaymentBo payment);
    }
}
