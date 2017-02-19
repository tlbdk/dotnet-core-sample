using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreSample.DbModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreSample.Controllers {

    [Route("user")]
    public class UserController : Controller {
        DatabaseContext _db;

        public UserController(DatabaseContext dbContext)
        {
            _db = dbContext;
        }
        
        [HttpGet]
        public async Task<List<User>> Get() {
            return await _db.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) {
            var user = await _db.Users.SingleOrDefaultAsync(u => u.Id == id);
            
            if(user == null) {
                return NotFound();
            
            } else {
                return Ok(user);
            }
        }
    }
}

