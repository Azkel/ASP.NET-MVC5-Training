using Komsky.Data.Entities;
using Komsky.Data.Repositories;

namespace Komsky.Data.DataAccess.Repositories
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        ApplicationUser GetByEmail(string email);
    }
}
