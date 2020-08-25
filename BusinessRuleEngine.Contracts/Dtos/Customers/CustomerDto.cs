using System;
using BusinessRuleEngine.Contracts.Dtos.Memberships;

namespace BusinessRuleEngine.Contracts.Dtos.Customers
{
    public class CustomerDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public MembershipDto Membership { get; set; }
    }
}
