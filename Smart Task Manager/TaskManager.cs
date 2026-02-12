using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Smart_Task_Manager
{
     class TaskManager: ITaskManager
    {
        private List<TaskBase> tasks = new List<TaskBase>();
        public TaskNotification HighPriority;
        public TaskNotification Overdue;
        public void AddTask(TaskBase task)
        {
            tasks.Add(task);
            Console.WriteLine($"Task'{task.Title}'added Successfully");
            if(task.Priority==1 && HighPriority != null)
            {
                HighPriority(task);
            }
        }
        public void RemoveTask(string title)
        {
            var task = tasks.Find(t => t.Title.ToLower() == title.ToLower());
            if(task != null)
            {
                tasks.Remove(task);
                Console.WriteLine($"Task '{title}'removed");
            }
            else
            {
                Console.WriteLine("Task not Found!!");
            }
        }
        public void ListTasks()
        {
            Console.WriteLine("\n All Tasks:");
            foreach (var task in tasks)
            {
                task.Display();

                if (!task.IsCompleted && task.Deadline < DateTime.Today && Overdue != null)
                {
                    Overdue(task);
                }
            }
        }
        public void MarkCompleted(string title)
        {
            var task = tasks.Find(t => t.Title.ToLower() == title.ToLower());
            if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine($"Task '{title}' marked as completed.");
            }
            else
            {
                Console.WriteLine("Task not found!");
            }
        }
    }
}
