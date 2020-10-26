using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController:ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context; 
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>>  GetUsers(){
            
            return await _context.User.ToListAsync();;
        }


        // api/Get/id
        [HttpGet("{id}")]
        public async  Task<ActionResult<AppUser>>  GetUsers(int id){
            
            return await _context.User.FirstOrDefaultAsync(x=>x.ID==id);
        } 
    }
}