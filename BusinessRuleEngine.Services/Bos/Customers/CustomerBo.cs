using System;

using BusinessRuleEngine.Services.Bos.Memberships;

namespace BusinessRuleEngine.Services.Bos.Customers
{
    public class CustomerBo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public MembershipBo Membership { get; set; }
    }
}
