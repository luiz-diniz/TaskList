using Microsoft.AspNetCore.Mvc;
using TaskList.Core.Interfaces;
using TaskList.Entities;

namespace TaskList.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserManager _userManager;

    public UserController(IUserManager userManager)
    {
        _userManager = userManager;
    }

    [HttpPost]
    [Route("create")]
    public IActionResult Create(User user)
    {
        try
        {
            _userManager.Create(user);

            return Ok();
        }
        catch (Exception)
        {
            return Problem("Error while creating user.");
        }
    }
}