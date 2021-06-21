using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class PasswordsRole
    {
        public string Identifier { get; set; }

        public string PasswordRecordId { get; set; }
        public PasswordRecord PasswordRecord { get; set; }

        public string RoleId { get; set; }
        public Role Role { get; set; }

        
    }
}
