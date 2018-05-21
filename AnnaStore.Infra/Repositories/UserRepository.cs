using AnnaStore.Domain.Entities;
using AnnaStore.Domain.Repositories;
using AnnaStore.Domain.Specs;
using AnnaStore.Infra.Persistence.DataContexts;
using System.Collections.Generic;
using System.Linq;

namespace AnnaStore.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private StoreDataContext _context;

        public UserRepository(StoreDataContext context)
        {
            this._context = context;
        }

        public void Register(User user)
        {
            _context.Users.Add(user);
        }

        public User Authenticate(string email, string password)
        {
            return _context.Users
                .Where(UserSpecs.AuthenticateUser(email, password))
                .FirstOrDefault();
        }

        public User GetByEmail(string email)
        {
            return _context.Users
                .Where(UserSpecs.GetByEmail(email))
                .FirstOrDefault();
        }

        public List<User> List()
        {
            return _context.Users.OrderBy(x => x.Email).ToList();
        }
    }
}
