using BusinessRuleEngine.DAL;
using BusinessRuleEngine.Services.BusinessServices;
using BusinessRuleEngine.Services.Contracts.Agent;
using BusinessRuleEngine.Services.Contracts.Commission;
using BusinessRuleEngine.Services.Contracts.Membership;
using BusinessRuleEngine.Services.Contracts.Notification;
using BusinessRuleEngine.Services.Contracts.PackagingSlip;
using BusinessRuleEngine.Services.Contracts.Payment;
using BusinessRuleEngine.Services.Factories;
using BusinessRuleEngine.Services.Factories.Contracts;
using BusinessRuleEngine.Services.Membership;
using BusinessRuleEngine.Services.Orchestrators.Contracts.Payment;
using BusinessRuleEngine.Services.Orchestrators.Payment;
using BusinessRuleEngine.Services.Shared;
using BusinessRuleEngine.Services.Shared.Contacts;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessRuleEngine.Services
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IPaymentFactory, PaymentFactory>();
            services.AddTransient<IPaymentOrchestrator, PaymentOrchestrator>();
            services.AddTransient<IAgentService, AgentService>(); 
            services.AddTransient<ICommissionService, CommissionService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IMembershipService, MembershipService>();
            services.AddTransient<INotificationMembershipService, NotificatiionMembershipService>();
            services.AddTransient<IPackagingSlipNumberGenerator, PackagingSlipNumberGenerator>();
            services.AddTransient<IPackagingSlipService, PackagingSlipService>();
            services.AddTransient<IPaymentProcessingService, BookPaymentProcessingService>();
            services.AddTransient<IPaymentProcessingService, MembershipPaymentProcessingService>();
            services.AddTransient<IPaymentProcessingService, PhysicalProductPaymentProcessingService>();
            services.AddTransient<IPaymentProcessingService, UpgradeMembershipPaymentProcessingService>();
            services.AddTransient<IPaymentService, PaymentService>();
            services.AddTransient<ISharedService, SharedService>();

            services.RegisterRepositories(configuration);

            return services;
        }
    }
}
