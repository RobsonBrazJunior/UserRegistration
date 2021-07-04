using UserRegistration.Entities;
using UserRegistration.Repository.Interfaces;

namespace UserRegistration.Repository.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
    }
}
