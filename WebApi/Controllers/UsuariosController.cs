using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Database;
using WebApi.Database.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public UsuariosController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            return Ok(_dbContext.Users.ToList());
        }

        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User user)
        {
            _dbContext.Add(user);
            await _dbContext.SaveChangesAsync();
            return Ok(user);
        }

        [HttpDelete]
        public async Task<ActionResult<User>> Delete([FromBody] User user)
        {
            _dbContext.Remove(user);
            await _dbContext.SaveChangesAsync();
            return Ok(user);
        }

        [HttpPut]
        public async Task<ActionResult<User>> Put([FromBody] User user)
        {
            _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();
            return Ok(user);
        }
    }
}
