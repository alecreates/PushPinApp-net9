using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]// /api/users
    public class UsersController(DataContext context) : ControllerBase
    {
        [HttpGet]
        // Returning ActionResult gives ability to return Http Responses
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await context.Users.ToListAsync();
            return users;
        }

        // Need different route parameter here so http can differentiate the methods
        [HttpGet("{id:int}")] // /api/users/1
        // Returning ActionResult gives ability to return Http Responses
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await context.Users.FindAsync(id);

            // Returns http response object not found
            if (user == null) return NotFound();

            return user;
        }
    }

}
