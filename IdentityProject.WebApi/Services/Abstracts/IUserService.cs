using IdentityProject.WebApi.Models;
using IdentityProject.WebApi.Models.Dtos.Users.Request;

namespace IdentityProject.WebApi.Services.Abstracts;

public interface IUserService
{
    List<User> GetAllUsers();
    User GetById(int id);
    User Add(AddUserRequestDto dto);
    User Update(User user);
    User GetByEmail(string email);
    User Delete(int id);

}
