using BusinessRuleEngine.DAL.Context;
using BusinessRuleEngine.DAL.Entities;
using BusinessRuleEngine.DAL.Repositories.Contracts;

namespace BusinessRuleEngine.DAL.Repositories
{
    public class MembershipRepository : RepositoryBase<Membership>, IMembershipRepository
    {
        public MembershipRepository(BusinessRuleEngineContext context):
            base(context)
        {

        }
    }
}
