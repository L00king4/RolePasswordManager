using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    class PasswordRecord
    {
        public string Id { get; set; }
        public string EncryptionString { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
