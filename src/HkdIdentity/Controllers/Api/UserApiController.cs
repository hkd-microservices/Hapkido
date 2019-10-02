using IdentityServerAspNetIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace hkd.ms.IdentityServer.Controllers.Api
{
    [ApiController]
    public class UserApiController : ControllerBase
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserApiController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet("~/api/user/teste")]
        public async Task<IActionResult> TesteAsync(string user, string password)
        {

            var applicationUser = await _userManager.FindByNameAsync(user);

            if (applicationUser != null)
            {
                Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.CheckPasswordSignInAsync(applicationUser, password, false);
                if (result.Succeeded)
                {
                    //todo get token
                    return Ok(result);
                }
            }


            return BadRequest();
        }
    }
}