using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    class Role : IdentityRole
    {
        public string Description { get; set; }
    }
}
