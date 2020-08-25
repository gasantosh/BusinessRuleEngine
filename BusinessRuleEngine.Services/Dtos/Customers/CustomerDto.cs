using System;

using BusinessRuleEngine.Services.Dtos.Memberships;

namespace BusinessRuleEngine.Services.Dtos.Customers
{
    public class CustomerDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public MembershipDto Membership { get; set; }
    }
}
