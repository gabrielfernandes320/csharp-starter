using System;

namespace csharp_template.src.shared.infra.ef.entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public void SetCreated()
        {
            CreatedAt = DateTime.Now;
        }
        public void SetUpdated()
        {
            UpdatedAt = DateTime.Now;
        }

    }
}
