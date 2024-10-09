using IdentityProject.WebApi.Models;

namespace IdentityProject.WebApi.Services.Abstracts;

public interface IUserService
{
    List<User> GetAllUsers();
    User GetById(int id);
    User Add(User user);
    User Update(User user);
    User GetByEmail(string email);
    User Delete(int id);

}
