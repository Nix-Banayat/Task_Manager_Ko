using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager_Ko
{
    internal static class TaskManage
    {
        private static List<Task> gawain = new List<Task>();

        public static void AddTask(string title, string description, string priority)
        {
            Task task = new Task(title, description, priority);
            gawain.Add(task);
        }

        public static List<Task> GetTasks()
        {
            return gawain;
        }

        public static Task GetTask(string title)
        {
            foreach (Task task in gawain)
            {
                if (task.Title == title)
                {
                    return task;
                }
            }
            return null;
        }
        public static void UpdateTask(string title, string newDescription, string newPriority)
        {
            Task task = GetTask(title);
            if (task != null)
            {
                task.Description = newDescription;
                task.Priority = newPriority;
            }
        }

        public static void DeleteTask(string title)
        {
            Task task = GetTask(title);
            if (task != null)
            {
                gawain.Remove(task);
            }
        }

        public static void MarkTaskAsCompleted(string title)
        {
            Task task = GetTask(title);
            if (task != null)
            {
                task.IsCompleted = true;
            }
        }

        public static void Arrange()
        {
            Console.WriteLine("------------------------");
        }
    }
}
