using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Task_Manager
{
    class Task : TaskBase
    {
        public override void Display()
        {
            Console.WriteLine($"[{(IsCompleted ? "done" : "pending")}] {Title} |Category:{Category}");
        }
    }
}