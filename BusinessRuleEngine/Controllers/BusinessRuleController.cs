using System;
using System.Linq;

using BusinessRuleEngine.Services.Dtos.Payments;
using BusinessRuleEngine.Services.Orchestrators.Contracts.Payment;
using BusinessRuleEngine.Services.Orchestrators.Contracts.Shared;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BusinessRuleEngine.Controllers
{
    [ApiController]
    [Route("api/BusinessRule")]
    public class BusinessRuleController : ControllerBase
    {
        private readonly ILogger<BusinessRuleController> _logger;
        private readonly IPaymentOrchestrator paymentOrchestrator;
        private readonly ISharedOrchestrator sharedOrchestrator;

        public BusinessRuleController(IPaymentOrchestrator paymentOrchestrator, ISharedOrchestrator sharedOrchestrator)
        {
            this.paymentOrchestrator = paymentOrchestrator;
            this.sharedOrchestrator = sharedOrchestrator;
        }

        [HttpGet("getAllActiveUser")]
        public IActionResult GetAllActiveUser()
        {
            var response = this.sharedOrchestrator.GetAllActiveMember();

            return Ok(response);
        }

        [HttpGet("getAgentTotalCommission")]
        public IActionResult GetAgentTotalCommission()
        {
            var response = this.sharedOrchestrator.GetAgentTotalCommission();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Payment(PaymentDto paymentDto)
        {
            try
            {
                var response = this.paymentOrchestrator.Pay(paymentDto);
                if (response.Any())
                {
                    return StatusCode(400,  response.Select(s => s.Item2).ToArray());
                }

                return StatusCode(200);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside payment action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
