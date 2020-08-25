using BusinessRuleEngine.Common.Messages;
using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Bos.Departments;
using BusinessRuleEngine.Services.Contracts.PackagingSlip;

namespace BusinessRuleEngine.Services.Shared.Validators
{
    public static class DepartmentValidator
    {
        public static bool Validate(this DepartmentBo department, ILocalizedMessageProvider localizedMessageProvider, out PackagingSlipGenerationResponse response)
        {
            response = null;

            if (department == null)
            {
                response = new PackagingSlipGenerationResponse
                {
                    ErrorMessage = localizedMessageProvider.GetDepartmentNotProvidedMessage,
                    PackagingSlipGenerationResponseType = PackagingSlipGenerationResponseType.Failure
                };

                return false;
            }

            if (department.DepartmentType != DepartmentType.Royality)
            {
                response = new PackagingSlipGenerationResponse
                {
                    ErrorMessage = localizedMessageProvider.GetDepartmentNotRoyalityMessage,
                    PackagingSlipGenerationResponseType = PackagingSlipGenerationResponseType.Failure
                };

                return false;
            }

            return true;
        }
    }
}
