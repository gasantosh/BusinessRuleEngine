using Microsoft.Extensions.Localization;

namespace BusinessRuleEngine.Common.Messages
{
    public class LocalizedMessageProvider : ILocalizedMessageProvider
    {
        private readonly IStringLocalizer<Messages> messageLocalizer;

        public LocalizedMessageProvider(IStringLocalizer<Messages> messageLocalizer)
        {
            this.messageLocalizer = messageLocalizer;
        }

        public string GetAgentCannotBeEmptyMessage => this.GetLocalizedMessage("AgentCannotBeEmpty");

        public string GetBookPaymentSucessfulMessage => this.GetLocalizedMessage("BookPaymentSucessful");

        public string GetCustomerCannotBeEmptyMessage => this.GetLocalizedMessage("CustomerCannotBeEmpty");

        public string GetCustomerEmailCannotBeEmptyMessage => this.GetLocalizedMessage("CustomerEmailCannotBeEmpty");

        public string GetDepartmentCannotBeEmptyMessage => this.GetLocalizedMessage("DepartmentCannotBeEmpty");

        public string GetDepartmentNotProvidedMessage => this.GetLocalizedMessage("DepartmentNotProvided");

        public string GetDepartmentNotRoyalityMessage => this.GetLocalizedMessage("DepartmentNotRoyality");

        public string GetMembershipCannotBeEmptyMessage => this.GetLocalizedMessage("MembershipCannotBeEmpty");

        public string GetMembershipPaymentSucessfulMessage => this.GetLocalizedMessage("MembershipPaymentSucessful");

        public string GetPaymentCannotBeEmptyMessage => this.GetLocalizedMessage("PaymentCannotBeEmpty");

        public string GetPaymentExceptionOccurredMessage => this.GetLocalizedMessage("PaymentExceptionOccurred");

        public string GetPaymentTypeNotSupportedMessage => this.GetLocalizedMessage("PaymentTypeNotSupported");

        public string GetPaymentValueCannotBeZeoMessage => this.GetLocalizedMessage("PaymentValueCannotBeZero");

        public string GetPhysicalProductPaymentSucessfulMessage => this.GetLocalizedMessage("PhysicalProductPaymentSucessful");

        public string GetUpgradeMembershipPaymentSucessfulMessage => this.GetLocalizedMessage("UpgradeMembershipPaymentSucessful");

        public string GetVideoPaymentSucessfulMessage => this.GetLocalizedMessage("VideoPaymentSucessful");

        public string GetVideoTypeNotLearningMessage => this.GetLocalizedMessage("VideoTypeNotLearning");

        private string GetLocalizedMessage(string messageName)
        {
            return this.messageLocalizer.GetString(messageName);
        }
    }
}
