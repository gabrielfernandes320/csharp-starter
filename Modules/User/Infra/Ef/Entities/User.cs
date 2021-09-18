using csharp_template.src.modules.auth.infra.ef.entities;
using csharp_template.src.shared.infra.ef.entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_template.src.modules.user.infra.ef.entities
{
    [Index(nameof(Email), IsUnique = true)]
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
        public ICollection<Role> Roles { get; set; }

    }

}
