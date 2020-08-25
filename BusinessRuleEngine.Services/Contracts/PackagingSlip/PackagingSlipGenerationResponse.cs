using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Bos.Slips;

namespace BusinessRuleEngine.Services.Contracts.PackagingSlip
{
    public class PackagingSlipGenerationResponse
    {
        public string ErrorMessage { get; set; }

        public PackagingSlipBo PackagingSlip { get; set; }

        public PackagingSlipGenerationResponseType PackagingSlipGenerationResponseType { get; set; }
    }
}
