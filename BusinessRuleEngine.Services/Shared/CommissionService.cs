using BusinessRuleEngine.Services.Contracts.Commission;

namespace BusinessRuleEngine.Services.Shared
{
    public class CommissionService : ICommissionService
    {
        internal const double Percentage = 10;

        public double Calculate(double paymentValue)
        {
            // TO DO: Data validation logic to be written to avoid exception.

            if (paymentValue == 0) { return 0; }

            return (paymentValue * Percentage) / (double)100;
        }
    }
}
