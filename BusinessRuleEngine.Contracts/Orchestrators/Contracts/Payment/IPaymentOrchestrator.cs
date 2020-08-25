using System;
using System.Collections.Generic;

using BusinessRuleEngine.Contracts.Dtos.Payments;
using BusinessRuleEngine.Enums;

namespace BusinessRuleEngine.Orchestrators.Contracts.Payment
{
    public interface IPaymentOrchestrator
    {
        IEnumerable<Tuple<PaymentResponseType, string>> Pay(PaymentDto payment);
    }
}
