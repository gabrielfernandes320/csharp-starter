using CSharpStarter.Shared.Infra.Ef.Entities;

namespace CSharpStarter.Modules.Users.Infra.Ef.Entities
{
    public class User : BaseEntity
    {
        public string Name {  get; set; }
        public string Email {  get; set; }
        public string Password {  get; set; }

    }
}
