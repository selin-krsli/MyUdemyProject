using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult CreateToken()
        {
            return Ok(new CreateToken().TokenCreate());
        }
        [HttpGet("[action]")]
        public IActionResult CreateTokenAdmin()
        {
            return Ok(new CreateToken().TokenCreateAdmin());
        }

        [HttpGet("[action]")]
        [Authorize]
        public IActionResult Test2()
        {
            return Ok("Hoşgeldiniz");
        }

        [HttpGet("[action]")]
        [Authorize(Roles ="Admin, Visitor")]
        public IActionResult Test3()
        {
            return Ok("Token Başarılı Bir Şekilde Giriş Yaptı!!");
        }
    }
}
