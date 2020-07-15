using demo.domain;
using demo.domain.Models.Administration;

namespace demo.domain.Repositories.Administration
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DbEntities dbEntities) : base(dbEntities) { }
    }

    public interface IUserRepository : IRepository<User>
    {
    }
}