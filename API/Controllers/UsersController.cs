using API.Data;
// using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class UsersController : ControllerBase
    {
      private readonly DataContext _context;
      public UsersController(DataContext context)
      {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users =  await _context.MyProperty.ToListAsync();
 
        // return BadRequest();

        return users;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await _context.MyProperty.FindAsync(id);
        return user;
    }

}
}