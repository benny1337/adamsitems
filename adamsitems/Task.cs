using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adamsitems
{
    public class Task
    {
        public string Name { get; set; }
        public TaskType Prio { get; set; }
        public DateTime CreatedOn { get; set; }
        public Task()
        {
            CreatedOn = DateTime.Now;
        }

    }

    public enum TaskType
    {
        normal,
        viktigsomfan
    }
}
