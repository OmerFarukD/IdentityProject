using IdentityProject.WebApi.Models.Dtos.Users.Request;

namespace IdentityProject.WebApi.Models;

public sealed class User : Entity
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }


    public int RoleId { get; set; }
    public Role Role { get; set; }



    public static explicit operator User(AddUserRequestDto dto)
    {
        return new User
        {
            Email = dto.Email,
            Password = dto.Password,
            Phone = dto.Phone,
            RoleId = dto.RoleId,
            Username = dto.Username
        };
    }

}
