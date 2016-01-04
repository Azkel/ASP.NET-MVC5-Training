using Komsky.Data.Entities;
using System.Linq;
using System.Data.Entity;

namespace Komsky.Data.DataAccess.Repositories
{
    public class ApplicationUserRepository : GenericRepository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public ApplicationUser GetByEmail(string email)
        {
            return GetAll().SingleOrDefault(x => x.Email.ToLower() == email.ToLower());
        }
    }
}
