using BusinessRuleEngine.DAL.Context;
using BusinessRuleEngine.DAL.Entities;
using BusinessRuleEngine.DAL.Repositories.Contracts;

namespace BusinessRuleEngine.DAL.Repositories
{
    public class LibraryRepository : RepositoryBase<Library>, ILibraryRepository
    {
        public LibraryRepository(BusinessRuleEngineContext context):
            base(context)
        {

        }
    }
}
