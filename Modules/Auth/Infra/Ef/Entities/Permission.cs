using csharp_template.src.shared.infra.ef.entities;
using System.Collections.Generic;

namespace csharp_template.src.modules.auth.infra.ef.entities
{
    public class Permission : BaseEntity
    {
        public int Name { get; set; }
        public int Reference { get; set; }
        public int Resource { get; set; }
        public int Action { get; set; }
        public bool Enabled { get; set; }

        public ICollection<Role> Roles { get; set; }

    }
}
