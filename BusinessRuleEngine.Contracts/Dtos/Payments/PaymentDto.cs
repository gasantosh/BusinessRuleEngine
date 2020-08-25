using System;
using BusinessRuleEngine.Contracts.Dtos.Agents;
using BusinessRuleEngine.Contracts.Dtos.Customers;
using BusinessRuleEngine.Contracts.Dtos.Departments;
using BusinessRuleEngine.Enums;

namespace BusinessRuleEngine.Contracts.Dtos.Payments
{
    public class PaymentDto
    {
        public Guid Id { get; set; }

        public CustomerDto Customer { get; set; }

        public PaymentType PaymentType { get; set; }

        public DepartmentDto Department { get; set; }

        public AgentDto Agent { get; set; }

        public double PaymentValue { get; set; }

        public VideoType VideoType { get; set; }
    }
}
