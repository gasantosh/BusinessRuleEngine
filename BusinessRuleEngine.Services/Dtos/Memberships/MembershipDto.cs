using System;

using BusinessRuleEngine.Enums;

namespace BusinessRuleEngine.Services.Dtos.Memberships
{
    public class MembershipDto
    {
        public Guid Id { get; set; }

        public MembershipType MembershipType { get; set; }

        public bool IsActive { get; set; }
    }
}
