using PMIDE.data.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;
using TaskBodyContentType = System.String;

namespace PMIDE.data.Data.Task
{
    public class Task
    {
        public string id { get; set; }
        public User creator { get; set; }
        public User assignedTo { get; set; }
        public Task parent;
        public virtual ICollection<Task> children { get; set; }
        public virtual ICollection<Task> prerequisites { get; set; }

        public virtual ICollection<TaskComment> comments { get; set; }
    }
}
