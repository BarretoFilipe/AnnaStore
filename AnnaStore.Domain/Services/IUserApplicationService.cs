using AnnaStore.Domain.Commands.UserCommands;
using AnnaStore.Domain.Entities;
using System.Collections.Generic;

namespace AnnaStore.Domain.Services
{
    public interface IUserApplicationService
    {
        User Register(RegisterUserCommand command);
        User Authenticate(string email, string password);
        List<User> List();
    }
}
