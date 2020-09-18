﻿using System.Collections.Generic;

namespace Kanban.Data.Entities
{
    public class User : IVersionedEntity
    {
        public virtual long UserId { get; set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Email { get; set; }
        public virtual byte[] Version { get; set; }
    }
}