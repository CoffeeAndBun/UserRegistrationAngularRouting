using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApi.Models.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public ApplicationUserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("Register")]
        //POST : /api/ApplicationUser/Register
        public async Task<Object> PostApplicationUser(ApplicationUserModel userModel)
        {
            var applicationUser = new ApplicationUser()
            {
                UserName = userModel.UserName,
                Email = userModel.Email,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName
            };

            try
            {
                var result = await _userManager.CreateAsync(applicationUser, userModel.Password);
                return Ok(result);

            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}