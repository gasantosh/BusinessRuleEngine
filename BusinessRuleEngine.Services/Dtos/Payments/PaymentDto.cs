using System;

using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Dtos.Agents;
using BusinessRuleEngine.Services.Dtos.Customers;
using BusinessRuleEngine.Services.Dtos.Departments;

namespace BusinessRuleEngine.Services.Dtos.Payments
{
    public class PaymentDto
    {
        public Guid Id { get; set; }

        public CustomerDto Customer { get; set; }

        public PaymentType PaymentType { get; set; }

        public DepartmentDto Department { get; set; }

        public AgentDto Agent { get; set; }

        public double PaymentValue { get; set; }
    }
}
