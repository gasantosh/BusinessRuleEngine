using System;

using BusinessRuleEngine.Enums;

namespace BusinessRuleEngine.Services.Bos.Memberships
{
    public class MembershipBo
    {
        public Guid Id { get; set; }

        public MembershipType MembershipType { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
