using IdentityProject.WebApi.Models;

namespace IdentityProject.WebApi.Repository.Abtstracts;

public interface IUserRepository : IEntityRepository<User>
{


    User GetByEmail(string email);
    List<User> GetAllByUsernameContains(string text);

}
