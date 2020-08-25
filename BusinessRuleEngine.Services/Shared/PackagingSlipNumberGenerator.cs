using System;

using BusinessRuleEngine.Services.Contracts.PackagingSlip;

namespace BusinessRuleEngine.Services
{
    public class PackagingSlipNumberGenerator : IPackagingSlipNumberGenerator
    {
        public string Generate()
        {
            return "PS-" + DateTime.Now.Ticks.ToString();
        }
    }
}
