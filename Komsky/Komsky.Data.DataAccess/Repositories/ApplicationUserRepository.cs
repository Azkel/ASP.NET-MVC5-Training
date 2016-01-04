using Komsky.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
