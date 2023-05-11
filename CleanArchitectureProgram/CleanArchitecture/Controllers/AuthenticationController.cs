using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [Route("register")]
        public IActionResult Register(RegisterRequest request)
        {
            return Ok();
        }
    }
}
