using System;
using blazor.Domain.Interfaces;

namespace blazor.Domain {
    public abstract class AuditedEntityBase : IAuditedEntityBase {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
