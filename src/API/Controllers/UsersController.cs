using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace src.API.Controllers
{

    public class UsersController : BaseApiController
    {
        private  IConfiguration Configuration {get;}
        private readonly DataContext _context;
        public UsersController(DataContext context, IConfiguration config)
        {
            _context = context;
            Configuration = config;
        }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
         return   Ok(Configuration["TokenKey"]);// _context.Users.ToListAsync();
     
        

    }
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        return await _context.Users.FindAsync(id);

    }
        
    }
}