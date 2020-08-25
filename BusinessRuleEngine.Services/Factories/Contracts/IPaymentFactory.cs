using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Contracts.Payment;

namespace BusinessRuleEngine.Services.Factories.Contracts
{
    public interface IPaymentFactory
    {
        IPaymentProcessingService Create(PaymentType paymentType);
    }
}
