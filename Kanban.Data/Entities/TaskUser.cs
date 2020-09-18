using System.Collections.Generic;

namespace Kanban.Data.Entities
{
    public class TaskUser : IVersionedEntity
    {
        public virtual long TaskId { get; set; }
        public virtual long UserId { get; set; }
        public virtual byte[] Version { get; set; }
    }
}