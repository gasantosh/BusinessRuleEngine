using System;
using System.Collections.Generic;
using System.Linq;

using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Bos.Payments;
using BusinessRuleEngine.Services.Contracts.Payment;
using BusinessRuleEngine.Services.Dtos.Payments;
using BusinessRuleEngine.Services.Orchestrators.Contracts.Payment;
using BusinessRuleEngine.Validators.Contracts;

using AutoMapper;

namespace BusinessRuleEngine.Services.Orchestrators.Payment
{
    public class PaymentOrchestrator : IPaymentOrchestrator
    {
        private readonly IPaymentValidator paymentValidator;

        private readonly IPaymentService paymentService;

        private readonly IMapper mapper;

        public PaymentOrchestrator(
            IPaymentValidator paymentValidator, 
            IPaymentService paymentService, 
            IMapper mapper)
        {
            this.paymentValidator = paymentValidator;
            this.paymentService = paymentService;
            this.mapper = mapper;
        }

        public IEnumerable<Tuple<PaymentResponseType, string>> Pay(PaymentDto payment)
        {
            var response = this.paymentValidator.Validate(payment);
            if (response.Any())
            {
                return response;
            }

            var paymnetBo = this.mapper.Map<PaymentBo>(payment);

            var paymentResponse = this.paymentService.Pay(paymnetBo);
            var res = new[]
            {
                Tuple.Create(paymentResponse.PaymentResponseType, paymentResponse.ErrorMessage)
            };

            return res;
        }
    }
}
