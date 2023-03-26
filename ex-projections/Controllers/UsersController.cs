using AutoMapper;
using AutoMapper.QueryableExtensions;
using ex_projections.Configurations;
using ex_projections.DTOs;
using ex_projections.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ex_projections.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post(
            [FromServices] CustomDbContext dbContext,
            [FromServices] IMapper mapper,
            CreateUserInput input)
        {
            var u = mapper.Map<User>(input);

            await dbContext.Set<User>()
                .AddAsync(u);

            await dbContext.SaveChangesAsync();

            var res = mapper.Map<CreateUserOutput>(u);

            return Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> Get(
            [FromServices] CustomDbContext dbContext,
            [FromServices] IMapper mapper,
            uint id)
        {
            var query = dbContext.Set<User>()
                .Where(u => u.Id == id)
                .AsQueryable();

            var res = await mapper
                .ProjectTo<UserDto>(query)
                .SingleOrDefaultAsync();

            return Ok(res);
        }
    }
}
