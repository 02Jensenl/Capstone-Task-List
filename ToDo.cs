using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone_Task_List
{
    class ToDo
    {
        private string name;
        private string description;
        private string dueDate;
        private bool complete;

        public static List<ToDo> toDos = new List<ToDo>
            {
                new ToDo("Creed", "QA check at the paper mill", "10/28/2020", false),
                new ToDo("Dwight", "Schedule meeting with client ", "10/31/2020", false),
                new ToDo("Pam", "Purchase office supplies", "11/02/2020", false),
                new ToDo("Michael", "Sign the expense reports", "11/03/2020", false)
            };

        public static void ListTasks()
        {
            int i = 0;
            foreach (ToDo task in toDos)
            {
                i++;
                Console.WriteLine($"\t{i}: {task.Name} | {task.Description} | {task.DueDate} | {task.Complete}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public bool Complete
        {
            get { return complete; }
            set { complete = value; }
        }

        public ToDo()
        {
        }
        public ToDo(string Name, string Description, string DueDate, bool Complete = false)
        {
            name = Name;
            description = Description;
            dueDate = DueDate;
            complete = Complete;
        }
       

        public static void AddTask()
        {
            ToDo toDo = new ToDo();

            Console.WriteLine("Enter name");
            toDo.Name = Console.ReadLine();

            Console.WriteLine("Enter task description");
            toDo.Description = Console.ReadLine();

            Console.WriteLine("Enter Due Date mm/dd/yyyy");

            toDo.DueDate = Console.ReadLine();


            toDo.Complete = false;
            toDos.Add(toDo);
        }

        public static void DeleteTask()
        {
            bool again = true;
            while (again)
            {
                Console.WriteLine("Which task would you like to delete? Enter a corresponding number.");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    

                    Console.WriteLine();
                    result = result - 1;
                    if (result < toDos.Count && result >= 0) 
                    {
                        Console.WriteLine($"{toDos[result].Name} | {toDos[result].Description} | {toDos[result].DueDate} | {toDos[result].Complete}");
                        Console.WriteLine("\nAre you sure you want to delete this task? y/n");
                        string deleteInput = Console.ReadLine();
                        

                        if (deleteInput == "y" || deleteInput == "Y")
                        {
                            Console.WriteLine();
                            toDos.RemoveAt(result);
                            again = false;
                        }
                        else if (deleteInput == "n" || deleteInput == "N")
                        {
                            Console.WriteLine();
                            again = false;
                        }
                        else
                        {
                            Console.WriteLine("Not a valid input. Please try again.");
                            again = true;
                        }
                    }
                    else
                        Console.WriteLine("That task number does not exist. Please try again.");
                }
                else
                {
                    Console.WriteLine("That is not a valid input. please try again.");
                }
            }
        }

        public static void MarkTaskComplete()
        {
            bool again = true;
            while (again)
            {
                Console.WriteLine("Which task would you like to mark complete? Enter a corresponding number.\nNOTE: Completed tasks are marked as True");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    Console.WriteLine();
                    result = result - 1;
                    if (result < toDos.Count && result >= 0)
                    {
                        Console.WriteLine($"{toDos[result].Name}, {toDos[result].Description}, {toDos[result].DueDate}, {toDos[result].Complete}");
                        Console.WriteLine("\nAre you sure you want to mark this task complete? y/n");
                        string completeInput = Console.ReadLine();

                        if (completeInput == "y" || completeInput == "Y")
                        {
                            toDos[result].Complete = true;
                            again = false;
                        }
                        else if (completeInput == "n" || completeInput == "Y")
                        {
                            again = false;
                        }
                    }
                    else
                        Console.WriteLine("That task number does not exist. Please try again.");
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please try again.");
                }
            }
        }

        public static bool Quit()
        {
            return false;
        }
    }
}
