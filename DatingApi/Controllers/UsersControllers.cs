using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult <IEnumerable<AppUser>>> GetUsers(){

            return  await this._context.Users.ToListAsync();
            
            

        }

        [HttpGet("{id}")]
        public async Task<ActionResult <AppUser>> GetUser(int id){

            return await this._context.Users.FindAsync(id);           

        }
    }
}