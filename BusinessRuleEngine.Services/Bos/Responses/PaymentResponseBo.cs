using BusinessRuleEngine.Enums;

namespace BusinessRuleEngine.Services.Bos.Responses
{
    public class PaymentResponseBo
    {
        public PaymentResponseType PaymentResponseType { get; set; }

        public string ErrorMessage { get; set; }
    }
}
