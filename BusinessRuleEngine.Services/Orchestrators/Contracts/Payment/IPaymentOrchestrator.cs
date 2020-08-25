using System;
using System.Collections.Generic;

using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Dtos.Payments;

namespace BusinessRuleEngine.Services.Orchestrators.Contracts.Payment
{
    public interface IPaymentOrchestrator
    {
        IEnumerable<Tuple<PaymentResponseType, string>> Pay(PaymentDto payment);
    }
}
