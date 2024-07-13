using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager_Ko
{
    internal static class Compiler
    {
        public static void AddTaskCompile()
        {
            Console.Write("Enter task title: ");
            string title = Console.ReadLine();
            Console.Write("Enter task description: ");
            string description = Console.ReadLine();
            Console.Write("Enter task priority (High, Medium, Low): ");
            string priority = Console.ReadLine().ToLower();
            if (priority == "high" || priority == "medium" || priority == "low")
            {
                TaskManage.AddTask(title, description, priority);
                Console.WriteLine("Task added successfully!");
                TaskManage.Arrange();
            }
            else
            {
                Console.WriteLine("Invalid input. Task not saved.");
                TaskManage.Arrange();
            }
        }

        public static void ViewTasks()
        {
            List<Task> gawain = TaskManage.GetTasks();
            Console.WriteLine("High Priority Tasks:");
            foreach (Task task in gawain)
            {
                if (task.Priority == "high")
                {
                    Console.WriteLine($" •{task.Title}  \n -{task.Description}  \n {(task.IsCompleted ? "(Completed)" : "")}");
                }
            }
            TaskManage.Arrange();

            Console.WriteLine("Medium Priority Tasks:");
            foreach (Task task in gawain)
            {
                if (task.Priority == "medium")
                {
                    Console.WriteLine($" •{task.Title}  \n -{task.Description}  \n {(task.IsCompleted ? "(Completed)" : "")}");
                }
            }
            TaskManage.Arrange();

            Console.WriteLine("Low Priority Tasks:");
            foreach (Task task in gawain)
            {
                if (task.Priority == "low")
                {
                    Console.WriteLine($" •{task.Title}  \n -{task.Description}  \n {(task.IsCompleted ? "(Completed)" : "")}");
                }
            }
            TaskManage.Arrange();
        }

        public static void EditTasksCompile()
        {
            Console.Write("Enter task title to edit: ");
            string title = Console.ReadLine();
            Task task = TaskManage.GetTask(title);
            if (task != null)
            {
                Console.Write("Enter new task description: ");
                string newDescription = Console.ReadLine();
                Console.Write("Enter new task priority (High, Medium, Low): ");
                string newPriority = Console.ReadLine().ToLower();
                TaskManage.UpdateTask(title, newDescription, newPriority);
                Console.WriteLine("Task updated successfully!");
                TaskManage.Arrange();
            }
            else
            {
                Console.WriteLine("Task doesn't exist.");
            }
        }

        public static void DeleteTaskCompile()
        {
            Console.Write("Enter task title to delete: ");
            string title = Console.ReadLine();
            Task task = TaskManage.GetTask(title);
            if (task != null)
            {
                Console.WriteLine($"Task: {task.Title} - {task.Description} ({task.Priority})");
                Console.Write("Confirm deletion (yes/no): ");
                string confirm = Console.ReadLine();
                if (confirm.ToLower() == "yes")
                {
                    TaskManage.DeleteTask(title);
                    Console.WriteLine("Task deleted successfully!");
                    TaskManage.Arrange();
                }
                else
                {
                    Console.WriteLine("Deletion cancelled. Invalid selection.");
                    TaskManage.Arrange();
                }
            }
            else
            {
                Console.WriteLine("Task doesn't exist.");
                TaskManage.Arrange();
            }
        }

        public static void MarkTaskAsCompletedCompile()
        {
            Console.Write("Enter task title to mark as completed: ");
            string title = Console.ReadLine();
            Task task = TaskManage.GetTask(title);
            if (task != null)
            {
                Console.WriteLine($"Task: {task.Title} - {task.Description} ({task.Priority})");
                TaskManage.MarkTaskAsCompleted(title);
                Console.WriteLine("Task marked as completed successfully!");
                TaskManage.Arrange();
            }
            else
            {
                Console.WriteLine("Task doesn't exist.");
                TaskManage.Arrange();
            }
        }
    }
}
