namespace Smart_Task_Manager
{
     class Program
    {
        static void NotifyHighPriority(TaskBase task)
        {
            Console.WriteLine($" HIGH PRIORITY TASK: {task.Title}");
        }

        static void NotifyOverdue(TaskBase task)
        {
            Console.WriteLine($"OVERDUE TASK: {task.Title}");
        }
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
            manager.HighPriority = NotifyHighPriority;
            manager.Overdue = NotifyOverdue;

            while (true)
            {
                Console.WriteLine("\n1.Add Task  2.View Tasks  3.Complete Task  4.Remove Task  5.Exit");
                Console.Write("Choose option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Category: ");
                    string category = Console.ReadLine();

                    Console.Write("Enter Priority (1=High 2=Medium 3=Low): ");
                    int priority = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Deadline in days from today: ");
                    int days = Convert.ToInt32(Console.ReadLine());

                    manager.AddTask(new Task
                    {
                        Title = title,
                        Category = category,
                        Priority = priority,
                        Deadline = DateTime.Today.AddDays(days)
                    });
                }
                else if (choice == 2)
                {
                    manager.ListTasks();
                }
                else if (choice == 3)
                {
                    Console.Write("Enter task title to complete: ");
                    string title = Console.ReadLine();
                    manager.MarkCompleted(title);
                }
                else if (choice == 4)
                {
                    Console.Write("Enter task title to remove: ");
                    string title = Console.ReadLine();
                    manager.RemoveTask(title);
                }
                else if (choice == 5)
                {
                    break;
                }
                Console.ReadLine();
            }
        }
       
        }
    }

