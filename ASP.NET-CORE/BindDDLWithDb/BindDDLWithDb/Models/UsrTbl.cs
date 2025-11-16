using System;
using System.Collections.Generic;

namespace BindDDLWithDb.Models
{
    public partial class UsrTbl
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
