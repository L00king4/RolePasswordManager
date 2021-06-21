using Microsoft.AspNetCore.Identity;
using RolePasswordManager.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolePasswordManager.Services.RegisterService
{
    public interface IRegisterService
    {
        public Task<IdentityResult> Register(RegisterRequest request);
    }
}
