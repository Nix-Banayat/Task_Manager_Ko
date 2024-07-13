namespace Task_Manager_Ko
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome To Task Manager.");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Add Tasks.");
                Console.WriteLine("2. View Tasks.");
                Console.WriteLine("3. Edit Tasks.");
                Console.WriteLine("4. Delete Tasks.");
                Console.WriteLine("5. Mark Task as Completed.");
                Console.WriteLine("6. Shop.");
                Console.WriteLine("7. Exit.");
                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());
                Processing.Options(option);
            }
        }
    }
}
