using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager_Ko
{
    internal class Processing
    {
        public static void Options(int option)
        {
            switch (option)
            {
                case 1:
                    Compiler.AddTaskCompile();
                    break;
                case 2:
                    Compiler.ViewTasks();
                    break;
                case 3:
                    Compiler.EditTasksCompile();
                    break;
                case 4:
                    Compiler.DeleteTaskCompile();
                    break;
                case 5:
                    Compiler.MarkTaskAsCompletedCompile();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    TaskManage.Arrange();
                    break;
            }
        }
    }
}
