using System;

using BusinessRuleEngine.Enums;
using BusinessRuleEngine.Services.Bos.Agents;
using BusinessRuleEngine.Services.Bos.Customers;
using BusinessRuleEngine.Services.Bos.Departments;

namespace BusinessRuleEngine.Services.Bos.Payments
{
    public class PaymentBo
    {
        public Guid Id { get; set; }

        public CustomerBo Customer { get; set; }

        public PaymentType PaymentType { get; set; }

        public DepartmentBo Department { get; set; }

        public AgentBo Agent { get; set; }

        public double PaymentValue { get; set; }
    }
}
