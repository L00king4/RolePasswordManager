using AutoMapper;
using Entities;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using RolePasswordManager.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolePasswordManager.Services.RegisterService
{
    public class RegisterService : IRegisterService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IMapper _mapper;

        public RegisterService(ApplicationDbContext context, 
            UserManager<User> userManager,
            RoleManager<Role> roleManager,
            IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }
        public async Task<IdentityResult> Register(RegisterRequest request)
        {
            var user = _mapper.Map<User>(request);
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                user.EmailConfirmed = true;
                await _context.SaveChangesAsync();
            }
            return result;
        }
    }
}
