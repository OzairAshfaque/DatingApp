using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
         return  await  _context.Users.ToListAsync();//Ok(Configuration.ToString());
     
        

    }
    [Authorize]
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        return await _context.Users.FindAsync(id);

    }
        
    }
}