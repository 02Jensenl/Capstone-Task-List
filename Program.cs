using System;
using System.Collections.Generic;

namespace Capstone_Task_List
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again)
            {
                

                Console.WriteLine("Welcome to the task manager. Please select an option below.");

                Console.WriteLine("1. List Tasks");
                Console.WriteLine("2. Add Tasks");
                Console.WriteLine("3. Delete Tasks");
                Console.WriteLine("4. Mark Task Complete");
                Console.WriteLine("5. Quit\n");

                string userResponse = Console.ReadLine();

                if (userResponse == "1")
                {
                    ToDo.ListTasks();
                }
                else if (userResponse == "2")
                {
                    ToDo.AddTask();
                }
                else if (userResponse == "3")
                {
                    ToDo.ListTasks();
                    ToDo.DeleteTask();
                }
                else if (userResponse == "4")
                {
                    ToDo.ListTasks();
                    ToDo.MarkTaskComplete();
                }
                else if (userResponse == "5")
                {
                    Console.WriteLine("Thank you for using the task manager.");
                  
                    again = ToDo.Quit();

                }
            }
        }
    }
}





