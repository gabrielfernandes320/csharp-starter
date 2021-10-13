using CSharpStarter.Shared.Infra.Ef.Entities;
using System;
using System.Collections.Generic;

namespace CSharpStarter.Modules.Auth.Infra.Ef.Entities
{
    public class Permission : BaseEntity
    {
        public string Name { get; set; }
        public string Reference { get; set; }
        public string Resource { get; set; }
        public string Action { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
