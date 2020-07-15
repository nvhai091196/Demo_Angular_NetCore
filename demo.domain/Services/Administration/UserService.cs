using System.Collections.Generic;
using demo.domain.Models.Administration;
using demo.domain.Repositories.Administration;
namespace demo.domain.Services.Administration
{
    public interface IUserService : IServiceBase<User>
    {
    }

    public class UserService : ServiceBase<User>, IUserService
    {
        public UserService(IUserRepository UserRepository, IUnitOfWork unitOfWork) : base(UserRepository, unitOfWork)
        {
        }
    }
}