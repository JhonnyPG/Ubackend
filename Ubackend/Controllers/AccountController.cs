using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ubackend.Data;
using Ubackend.Helpers;
using Ubackend.Models;

namespace Ubackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly JwtSettings _jwtSettings;
        public AccountController(JwtSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }
        private IEnumerable<User> Login = new List<User>()
        {
            new User()
            {
                Id = 1,
                Email = "admin@user.com",
                Name = "Admin",
                Password = "Admin"
            },
             new User()
            {
                Id = 2,
                Email = "user@user.com",
                Name = "user1",
                Password = "user1"
            }
        };

        [HttpPost]
        public IActionResult GetToken(UserLogin userLogin)
        {
            try
            {
                var Token = new UserToken();
                var Valid = Login.Any(user => user.Name.Equals(userLogin.UserName, StringComparison.OrdinalIgnoreCase));
                if (Valid)
                {
                    var user = Login.FirstOrDefault(user => user.Name.Equals(userLogin.UserName, StringComparison.OrdinalIgnoreCase));
                    Token = JwtHelpers.GenTokenKey(new UserToken()
                    {
                        UserName = user.Name,
                        EmailId = user.Email,
                        Id = user.Id,
                        GuidId = Guid.NewGuid(),


                    },_jwtSettings );
                }else
                {
                    return BadRequest("wrong password");
                }
                return Ok(Token);

            }
            catch (Exception ex)
            {
                throw new Exception("error of Token", ex);
            }
        }
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator" )]
        public IActionResult GetUserList()
        {
            return Ok(Login);
        }
    }
}
