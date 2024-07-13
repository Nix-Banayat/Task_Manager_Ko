using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager_Ko
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string title, string description, string priority)
        {
            Title = title;
            Description = description;
            Priority = priority;
            IsCompleted = false;
        }
    }
}
