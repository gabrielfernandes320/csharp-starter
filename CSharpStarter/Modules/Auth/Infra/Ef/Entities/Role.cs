using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Shared.Infra.Ef.Entities;
using System;
using System.Collections.Generic;

namespace CSharpStarter.Modules.Auth.Infra.Ef.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<Permission> Permissions { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
