using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Task_Manager
{
    abstract class TaskBase
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }

        public abstract void Display();
    }
}
