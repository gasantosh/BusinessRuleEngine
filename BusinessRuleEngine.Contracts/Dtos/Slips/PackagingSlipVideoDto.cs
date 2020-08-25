using BusinessRuleEngine.Contracts.Dtos.Videos;

namespace BusinessRuleEngine.Contracts.Dtos.Slips
{
    public class PackagingSlipVideoDto : PackagingSlipDto
    {
        public VideoDto Video { get; set; }
    }
}
