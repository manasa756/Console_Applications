using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Task_Manager
{
    interface ITaskManager
    {
        void AddTask(TaskBase task);
        void RemoveTask(string title);
        void ListTasks();
        void MarkCompleted(string title);
    }
}
