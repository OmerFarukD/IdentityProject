using IdentityProject.WebApi.Contexts;
using IdentityProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    MsSqlContext msSqlContext = new MsSqlContext();


    [HttpPost("add")]
    public IActionResult Add(User user)
    {
        // insert into Users(...) values (...)
        msSqlContext.Users.Add(user);
        msSqlContext.SaveChanges();

        return Ok(user);
    }
    // IEntityTypeConfigurationBuilder


    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        // select * from users
        List<User> users = msSqlContext.Users.ToList();
        return Ok(users);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        // select * from users where id = (id)
        User user = msSqlContext.Users.Find(id);

        return Ok(user);

    }

}
