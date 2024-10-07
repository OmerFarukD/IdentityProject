using IdentityProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{

    private static List<User> users = new List<User>()
    {
        new User
        {
            Id = 1,
            Email = "seren@gmail.com",
            Password = "deneme123",
            Phone = "05654123687",
            Username = "qubitfaruk"
        },
        new User
        {
            Id = 2,
            Email = "muhammed_kus@gmail.com",
            Password = "deneme_123",
            Phone = "05412569874",
            Username = "cıstakcıstak"
        },
           new User
        {
            Id = 3,
            Email = "safa_turizm@gmail.com",
            Password = "sarımsak37",
            Phone = "05412569884",
            Username = "gastamonulu_baba"
        }
    };

    [HttpGet("getall")]
    public List<User> GetUsers()
    {
        return users;
    }

    [HttpGet("getbyid")]
    // http://localhost:5242/api/getbyid/3
    public IActionResult GetById(int id)
    {
        

        User user = users.FirstOrDefault(x=> x.Id == id);
        if(user is null)
        {
            return NotFound("Aradığınız kullanıcı bulunamadı.");
        }
        
        return Ok(user);


    }

    [HttpPost("add")]
    public IActionResult Add([FromBody]User user)
    {
        User? getUserByEmail = users.SingleOrDefault(x => x.Email == user.Email);
        if (getUserByEmail is not null)
        {
            string message = $"Aynı email e ait kullanıcı mevcuttur: {user.Email}";
            return BadRequest(message);
        }

        users.Add(user);
        return Ok("Kullanıcı eklendi.");
    }


    [HttpDelete("delete")]
    public IActionResult Delete(string email)
    {
        User? user = users.SingleOrDefault(u=> u.Email==email);
        if (user is null)
        {
            return NotFound("Aradığınız email e göre kullanıcı bulunamadı.");
        }

        users.Remove(user);
        return Ok(user);
    }

    [HttpPut("Update")]
    public IActionResult Update([FromQuery]int id,[FromBody] User updated)
    {
        User user = users.FirstOrDefault(x => x.Id == id);
        if (user is null)
        {
            return NotFound("Aradığınız kullanıcı bulunamadı.");
        }

        int index = users.IndexOf(user);
        users.Remove(user);
        users.Insert(index,updated);

        return Ok("Güncellendi.");

    }


}
