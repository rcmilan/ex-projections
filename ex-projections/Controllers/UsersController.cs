using ex_projections.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ex_projections.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post(CreateUserInput input)
        {
            var res = new CreateUserOutput(1);

            return Ok(res);
        }

        [HttpGet] public async Task<IActionResult> Get(uint id)
        {
            return Ok();
        }
    }
}
