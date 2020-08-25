namespace BusinessRuleEngine.Common.Messages
{
    public interface ILocalizedMessageProvider
    {
        string GetAgentCannotBeEmptyMessage { get; }

        string GetBookPaymentSucessfulMessage { get; }

        string GetCustomerCannotBeEmptyMessage { get; }

        string GetCustomerEmailCannotBeEmptyMessage { get; }

        string GetDepartmentCannotBeEmptyMessage { get; }

        string GetDepartmentNotProvidedMessage { get; }

        string GetDepartmentNotRoyalityMessage { get; }

        string GetMembershipCannotBeEmptyMessage { get; }

        string GetMembershipPaymentSucessfulMessage { get; }

        string GetPaymentCannotBeEmptyMessage { get; }

        string GetPaymentExceptionOccurredMessage { get; }

        string GetPaymentTypeNotSupportedMessage { get; }

        string GetPaymentValueCannotBeZeoMessage { get; }

        string GetPhysicalProductPaymentSucessfulMessage { get; }

        string GetUpgradeMembershipPaymentSucessfulMessage { get; }

        string GetVideoPaymentSucessfulMessage { get; }

        string GetVideoTypeNotLearningMessage { get; }
    }
}
