namespace IdentityProject.WebApi.Models.Dtos.Users.Response
{
    public class UserResponseDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Rolename { get; set; }



        public static implicit operator UserResponseDto(User user)
        {
            return new UserResponseDto
            {
                Email = user.Email,
                Password = user.Password,
                Username = user.Username,
                Phone = user.Phone,
                Rolename = user.Role.Name
            };
        }
    }



}
