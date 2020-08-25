using BusinessRuleEngine.Services.Bos.Payments;
using BusinessRuleEngine.Services.Bos.Responses;
using BusinessRuleEngine.Services.Contracts.Agent;
using BusinessRuleEngine.Services.Contracts.Commission;
using BusinessRuleEngine.Services.Contracts.Payment;

namespace BusinessRuleEngine.Services.BusinessServices
{
    public abstract class BasePaymentProcessingService : IPaymentProcessingService
    {
        protected readonly ICommissionService commissionService;
        protected readonly IAgentService agentService;

        public BasePaymentProcessingService(ICommissionService commissionService, IAgentService agentService)
        {
            this.commissionService = commissionService;
            this.agentService = agentService;
        }

        public void CalculateAgentCommission(PaymentBo payment)
        {
            var commission = commissionService.Calculate(payment.PaymentValue);

            agentService.ReceieveCommission(payment.Agent, commission);
        }

        public abstract PaymentResponseBo Process(PaymentBo payment);
    }
}
