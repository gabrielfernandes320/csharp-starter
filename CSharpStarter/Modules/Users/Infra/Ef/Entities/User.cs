using CSharpStarter.Modules.Auth.Infra.Ef.Entities;
using CSharpStarter.Shared.Infra.Ef.Entities;
using System;
using System.Collections.Generic;

namespace CSharpStarter.Modules.Users.Infra.Ef.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<Role> Roles {  get; set; }
    }
}
