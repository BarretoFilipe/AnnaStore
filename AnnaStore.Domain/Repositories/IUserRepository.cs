using AnnaStore.Domain.Entities;
using System.Collections.Generic;

namespace AnnaStore.Domain.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        User Authenticate(string email, string password);
        User GetByEmail(string email);
        List<User> List();
    }
}
