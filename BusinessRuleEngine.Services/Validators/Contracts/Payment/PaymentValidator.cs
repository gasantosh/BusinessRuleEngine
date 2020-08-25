using System;
using System.Collections.Generic;

using BusinessRuleEngine.Services.Dtos.Payments;
using BusinessRuleEngine.Enums;

namespace BusinessRuleEngine.Validators.Contracts
{
    public interface IPaymentValidator
    {
        IEnumerable<Tuple<PaymentResponseType, string>> Validate(PaymentDto payment);
    }
}
