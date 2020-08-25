using System;
using System.Collections.Generic;

using BusinessRuleEngine.Common.Messages;
using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Dtos.Payments;
using BusinessRuleEngine.Validators.Contracts;

namespace BusinessRuleEngine.Validators
{
    public class PaymentValidator : IPaymentValidator
    {
        private readonly ILocalizedMessageProvider localizedMessageProvider;

        public PaymentValidator(ILocalizedMessageProvider localizedMessageProvider)
        {
            this.localizedMessageProvider = localizedMessageProvider;
        }
        public IEnumerable<Tuple<PaymentResponseType, string>> Validate(PaymentDto payment)
        {
            List<Tuple<PaymentResponseType, string>> validationMessages = new List<Tuple<PaymentResponseType, string>>();
            if (payment == null)
            {
                var response = Tuple.Create(PaymentResponseType.Failure, this.localizedMessageProvider.GetPaymentCannotBeEmptyMessage);
                validationMessages.Add(response);
            }

            if (payment.Customer == null)
            {
                var response = Tuple.Create(PaymentResponseType.Failure, this.localizedMessageProvider.GetCustomerCannotBeEmptyMessage);
                validationMessages.Add(response);
            }

            if (payment.Agent == null)
            {
                var response = Tuple.Create(PaymentResponseType.Failure, this.localizedMessageProvider.GetAgentCannotBeEmptyMessage);
                validationMessages.Add(response);
            }

            if (payment.Department == null)
            {
                var response = Tuple.Create(PaymentResponseType.Failure, this.localizedMessageProvider.GetDepartmentCannotBeEmptyMessage);
                validationMessages.Add(response);
            }

            if (payment.PaymentValue == 0)
            {
                var response = Tuple.Create(PaymentResponseType.Failure, this.localizedMessageProvider.GetPaymentValueCannotBeZeoMessage);
                validationMessages.Add(response);
            }

            return validationMessages;
        }
    }
}
