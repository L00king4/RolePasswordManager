using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    class User : IdentityUser
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityRoleId { get; set; }
        public IdentityRole IdentityRole { get; set; }
        
        public byte[] Avatar { get; set; }
        public string GetAvatar => (Avatar is null) ? "" : $"data:image/jpeg;base64,{Convert.ToBase64String(Avatar)}";

        public DateTimeOffset DateOfRegister { get; set; } = DateTimeOffset.UtcNow;

    }
}
