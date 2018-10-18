using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using DataRepository.DbEntities.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PublicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //https://habr.com/post/227351/
        //return _customUserManager ?? (_customUserManager = HttpContext.Current.GetOwinContext().GetUserManager<CustomUserManager>());

        // POST: api/User
        [HttpPost]
        public async Task<IActionResult> RegisterClient([FromBody] User user)
        {
            var userToAdd = Mapper.Map<AppUser>(user);

            var result = await _userManager.CreateAsync(userToAdd);

            return Ok();
        }
    }
}
