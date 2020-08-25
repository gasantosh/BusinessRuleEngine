using BusinessRuleEngine.Services.Bos.Slips;

namespace BusinessRuleEngine.Services.Bos.Responses
{
    public class PackagingSlipPaymentResponseBo : PaymentResponseBo
    {
        public PackagingSlipBo PackagingSlip { get; set; }
    }
}
