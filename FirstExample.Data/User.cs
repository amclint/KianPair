using System;
using System.Collections.Generic;

#nullable disable

namespace FirstExample.Data
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastClint { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
