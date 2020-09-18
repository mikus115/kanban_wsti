using System.Collections.Generic;

namespace Kanban.Data.Entities
{
    public class Task : IVersionedEntity
    {
        public virtual long TaskId { get; set; }
        public virtual string Subject { get; set; }
        public virtual string StartDate { get; set; }
        public virtual string DueDate { get; set; }
        public virtual string CompletedDate { get; set; }
        public virtual long StatusId { get; set; }
        public virtual string CreatedDate { get; set; }
        public virtual string CreatedUserId { get; set; }
        public virtual byte[] Version { get; set; }
    }
}