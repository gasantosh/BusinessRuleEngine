using System;

using BusinessRuleEngine.Common.Messages;
using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Bos.Departments;
using BusinessRuleEngine.Services.Bos.Slips;
using BusinessRuleEngine.Services.Contracts.PackagingSlip;
using BusinessRuleEngine.Services.Shared.Validators;

namespace BusinessRuleEngine.Services
{
    public class PackagingSlipService : IPackagingSlipService
    {
        private readonly IPackagingSlipNumberGenerator packagingSlipNumberGenerator;
        private readonly ILocalizedMessageProvider localizedMessageProvider;

        public PackagingSlipService(
            IPackagingSlipNumberGenerator packagingSlipNumberGenerator,
            ILocalizedMessageProvider localizedMessageProvider)
        {
            this.packagingSlipNumberGenerator = packagingSlipNumberGenerator;
            this.localizedMessageProvider = localizedMessageProvider;
        }

        public PackagingSlipGenerationResponse GenerateNewSlip()
        {
            return new PackagingSlipGenerationResponse
            {
                PackagingSlipGenerationResponseType = PackagingSlipGenerationResponseType.Success,
                PackagingSlip = new PackagingSlipBo
                {
                    Id = Guid.NewGuid(),
                    Number = packagingSlipNumberGenerator.Generate()
                }
            };
        }

        public PackagingSlipGenerationResponse GenerateDuplicateSlip(DepartmentBo department)
        {
            PackagingSlipGenerationResponse packagingSlipGenerationResponse;

            if (!department.Validate(this.localizedMessageProvider, out packagingSlipGenerationResponse))
            {
                return packagingSlipGenerationResponse;
            }

            return new PackagingSlipGenerationResponse
            {
                PackagingSlipGenerationResponseType = PackagingSlipGenerationResponseType.Success,
                PackagingSlip = new PackagingSlipBo
                {
                    Id = Guid.NewGuid(),
                    Number = packagingSlipNumberGenerator.Generate()
                }
            };
        }
    }
}
