using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Database;
using WebApi.Database.Entities;
using WebApi.ViewModel;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public UsuariosController(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserViewModel>>> Get()
        {
            var users = await _dbContext.Users.ToListAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult<UserViewModel>> Post([FromBody] UserViewModel user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newUser = _mapper.Map<User>(user);

            _dbContext.Add(newUser);
            await _dbContext.SaveChangesAsync();
            return Ok(_mapper.Map<UserViewModel>(newUser));
        }

        [HttpDelete]
        public async Task<ActionResult<UserViewModel>> Delete([FromBody] UserViewModel user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (!_dbContext.Users.Any(x => x.Id == user.Id))
                return NotFound();
            
            var deleteUser = _mapper.Map<User>(user);

            _dbContext.Remove(deleteUser);
            await _dbContext.SaveChangesAsync();

            return Ok(_mapper.Map<UserViewModel>(deleteUser));
        }

        [HttpPut]
        public async Task<ActionResult<UserViewModel>> Put([FromBody] UserViewModel user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (!_dbContext.Users.Any(x => x.Id == user.Id))
                return NotFound();

            var updateUser = _mapper.Map<User>(user);

            _dbContext.Update(updateUser);
            await _dbContext.SaveChangesAsync();
            return Ok(_mapper.Map<UserViewModel>(updateUser));
        }
    }
}
