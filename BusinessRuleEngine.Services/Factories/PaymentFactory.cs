using System;
using System.Collections.Generic;
using System.Linq;

using BusinessRuleEngine.Common.Logger;
using BusinessRuleEngine.Common.Messages;
using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.BusinessServices;
using BusinessRuleEngine.Services.Contracts.Payment;
using BusinessRuleEngine.Services.Factories.Contracts;

namespace BusinessRuleEngine.Services.Factories
{
    public class PaymentFactory : IPaymentFactory
    {
        private readonly IEnumerable<IPaymentProcessingService> services;
        private readonly ILocalizedMessageProvider localizedMessageProvider;

        public PaymentFactory(IEnumerable<IPaymentProcessingService> services, ILocalizedMessageProvider localizedMessageProvider)
        {
            this.services = services;
            this.localizedMessageProvider = localizedMessageProvider;
        }

        public IPaymentProcessingService Create(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.PhysicalProduct:
                    return this.services.OfType<PhysicalProductPaymentProcessingService>().Single();

                case PaymentType.Book:
                    return this.services.OfType<BookPaymentProcessingService>().Single();                  

                case PaymentType.Membership:
                    return this.services.OfType<MembershipPaymentProcessingService>().Single();

                case PaymentType.UpgradeMembership:
                    return this.services.OfType<UpgradeMembershipPaymentProcessingService>().Single();

                default:
                    Logger.Instance.Log(LoggerType.Error, this.localizedMessageProvider.GetPaymentTypeNotSupportedMessage);
                    throw new Exception(this.localizedMessageProvider.GetPaymentTypeNotSupportedMessage);
            }
        }
    }
}
