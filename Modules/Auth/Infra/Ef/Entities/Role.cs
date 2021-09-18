using csharp_template.src.modules.user.infra.ef.entities;
using csharp_template.src.shared.infra.ef.entities;
using System.Collections.Generic;

namespace csharp_template.src.modules.auth.infra.ef.entities
{
    public class Role : BaseEntity
    {
        public int Name { get; set; }
        public int? Reference { get; set; }
        public bool Enabled { get; set; }
        public ICollection<Permission> Permissions { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
