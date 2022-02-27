using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SE_BackEnd.Entity
{
    public abstract class EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
