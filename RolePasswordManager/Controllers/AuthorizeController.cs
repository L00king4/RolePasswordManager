using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RolePasswordManager.Models.Requests;
using RolePasswordManager.Services.RegisterService;

namespace RolePasswordManager.Controllers
{
    [Route("/[controller]/[action]")]
    public class AuthorizeController : Controller
    {
        private readonly IRegisterService _registerService;
        public AuthorizeController(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _registerService.Register(request);
            return Ok();
        }
    }
}
