using IdentityProject.WebApi.Models;
using IdentityProject.WebApi.Repository.Abtstracts;
using IdentityProject.WebApi.Repository.Concretes;
using IdentityProject.WebApi.Services.Abstracts;

namespace IdentityProject.WebApi.Services.Concretes;

public class UserService : IUserService
{

    private IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;   
    }

    public User Add(User user)
    {
        throw new NotImplementedException();
    }

    public User Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public User GetByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public User GetById(int id)
    {
        throw new NotImplementedException();
    }

    public User Update(User user)
    {
        throw new NotImplementedException();
    }
}
