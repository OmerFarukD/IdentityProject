using IdentityProject.WebApi.Models;

namespace IdentityProject.WebApi.Repository.Abtstracts;

public interface IUserRepository
{
    User? GetById(int id);
    List<User> GetAll();

    User Add(User user);
    User Update(User user);
    User Delete(int id);

    User GetByEmail(string email);
    List<User> GetAllByUsernameContains(string text);

}
