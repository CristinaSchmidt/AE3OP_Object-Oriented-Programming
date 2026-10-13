using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _00_introduction
{
    internal class Program
    {
        static void Exercice1()
        {
            Console.WriteLine("Exercice 1 : Introduction");
            Console.WriteLine("Hello World !");
            Console.WriteLine("Student Task Manager");
            Console.WriteLine("====================");
            Console.WriteLine("Welcome to the application!");
            Console.WriteLine("This student is Cristina Schmidt");
            Console.Write("Her favorite programming language is : ");
            Console.WriteLine("C# !");
            Console.WriteLine("Theses writes have been realised with both Console.WriteLine and Console.Write.");
            Console.WriteLine("When there is a WriteLine you return to the line otherwise you continue on the same line.");
        }

        static void Exercice2()
        {
            Console.WriteLine("Exercise 2 : variables and inputs");

            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("How many tasks do you want to complete today? ");
            int taskGoal = int.Parse(Console.ReadLine());

            Console.Write("How many hours do you have available? ");
            double availableHours = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"Your goal is {taskGoal} tasks.");
            Console.WriteLine($"You have {availableHours} hours available.");*/

            #region Datatypes

            /*There are different date types : 

            string studentName = "Alex";
            int taskCount = 5;
            double studyHours = 2.5;
            decimal budget = 100.50m;
            bool isCompleted = false;
            char grade = 'A';
            

            var courseName = ".NET Development"; //The program selects the best data type alone
            var maxTasks = 10;
            */
            const int MaxDailyTasks = 10; //Those are constants, values that connot be changed during the execution of the program.
            const string AppName = "Student Task Manager";
            
            #endregion

            #region String Interpolation and Prevention of errors with Parse

            Console.WriteLine($"Application: {AppName}");
            Console.WriteLine($"Maximum recommended daily tasks: {MaxDailyTasks}");
            //$ is used for string interpolation "............ {.................} ......................" Tout ce qui est dans les accolades est une variable qui sera remplacé par sa valeur



            /*This code can crash:
            int number = int.Parse(Console.ReadLine());

            //A safer alternative is:
            Console.Write("Enter a number: ");
            bool valid = int.TryParse(Console.ReadLine(), out int number2);

            Console.WriteLine($"Valid number: {valid}");
            Console.WriteLine($"Number: {number2}");*/
            #endregion


            Console.WriteLine("Hi, please answer theses questions before starting :");
            Console.WriteLine("What is your name ?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is the name of your course ?");
            string studentCourseName = Console.ReadLine();
            Console.WriteLine("Do you already know C# ? (true/false)");
            bool knowsCSharp = bool.Parse(Console.ReadLine());
            const int LimitDailyTasks = 10;


            Console.WriteLine($"Hello {userName} ! You are studying the class {studentCourseName}.");
            if (knowsCSharp == true) Console.WriteLine("You already know some C#!"); else Console.WriteLine("You don't know C# yet, but you will learn it soon !");

            Console.WriteLine($"You can complete a maximum of {LimitDailyTasks} tasks per day.");

            Console.WriteLine("When using int.Parse, it throws an exception : System.FormatException : 'Le format de la chaîne d'entrée est incorrect.'");
            Console.WriteLine("int.TryParse() returns a true or false depending on whether the conversion was successful or not, and it does not throw an exception.");
            Console.WriteLine("double takes 8 bytes in memory while decimal takes 16 bytes in memory.");
        }

        static void Exercice3()
        {
            Console.WriteLine("Exercise 3 : Conditions and switch");

            /*Console.Write("How many tasks have you completed today? ");
            int completedTasks = int.Parse(Console.ReadLine());

            if (completedTasks == 0)
            {
                Console.WriteLine("Time to get started!");
            }
            else if (completedTasks < 3)
            {
                Console.WriteLine("Good start. Keep going!");
            }
            else
            {
                Console.WriteLine("Great progress!");
            }
            */
            #region Memo
            /*
                    Comparison operators
                    ==   equal
                    !=   not equal
                    >    greater than
                    <    less than
                    >=   greater than or equal
                    <=   less than or equal

                    Logical operators
                    &&   AND
                    ||   OR
                    !    NOT

            */
            #endregion


            Console.WriteLine("Here is the menu :\n1. Add task\n2. View tasks\n3. Complete task\n4. Remove task\n0. Exit\nWhat do you want to do ? ");
            int choice= int.Parse(Console.ReadLine());// or Convert.ToInt32(Console.ReadLine()) but nor secured 

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Adding a task...");
                    break;

                case 2:
                    Console.WriteLine("Showing tasks...");
                    break;

                case 3:
                    Console.WriteLine("Marking task as completed...");
                    break;

                case 4:
                    Console.WriteLine("Removing task...");
                    break;

                case 0:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }


        }

        static void Exercice4()
        {
            Console.WriteLine("Exercise 4 : Loops and lists");
        
            #region List
            
            List<string> tasks = new List<string>();
            tasks.Add("Review C# variables");
            tasks.Add("Practice loops");
            tasks.Add("Create a Console application");
            Console.WriteLine($"Number of tasks: {tasks.Count}");
            Console.Write("Enter a new task: ");
            string newTask = Console.ReadLine();

            tasks.Add(newTask);

            Console.WriteLine("Task added.");
            
            #endregion

            #region Boucles
            
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
            /*
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }

            while ()
            { }

            do
            {

            }while (); 
            */

            #endregion

            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("1. Add task");
                Console.WriteLine("2. View tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("0. Exit");

                Console.Write("Choose: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter task: ");
                        string task = Console.ReadLine();
                        tasks.Add(task);
                        break;

                    case 2:
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                        }
                        break;
                    case 3:
                        Console.Write("Enter task number to remove: ");
                        int taskNumber = int.Parse(Console.ReadLine());
                        tasks.RemoveAt(taskNumber - 1);
                        break;
                    case 0:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }

            Console.WriteLine("List<T>.RemoveAt(int index) removes an element at a specific index while List<T>.Remove(T item) removes the first occurrence of a specific object from the list.");
            Console.WriteLine("In our case, it is best to use List<T>.RemoveAt(int index) because we are asking the user to enter the number of the task they want to remove, which corresponds to the index of the task in the list.");
            Console.WriteLine("The index is -1 because the list is zero-based, meaning the first element has an index of 0, the second element has an index of 1, and so on. Therefore, when the user enters a task number, we need to subtract 1 to get the correct index in the list.");

        }

        static void Exercice5()
        {
            Console.WriteLine("Exercise 5 : Methods and Refactoring");

            #region Memo
            /*
            void ShowTitle() //this is a method
            {
                Console.WriteLine();
                Console.WriteLine("Student Task Manager");
                Console.WriteLine("====================");
            }

            ShowTitle(); //I'm calling the method

            void ShowMessage(string message)
            {
                Console.WriteLine($"[INFO] {message}");
            }

            ShowMessage("Application started.");
            ShowMessage("Task added.");

            */
            #endregion

            List<string> tasks = new List<string>();
            tasks.Add("Review C# variables");
            tasks.Add("Practice loops");
            tasks.Add("Create a Console application");
            Console.WriteLine($"Number of tasks: {tasks.Count}");
            Console.Write("Enter a new task: ");
            string newTask = Console.ReadLine();

            tasks.Add(newTask);

            Console.WriteLine("Task added.");


            int GetTaskCount(List<string> taskslist) //This is a function
            {
                return taskslist.Count;
            }
            int count = GetTaskCount(tasks);
            Console.WriteLine($"You currently have {count} tasks.");

            void ShowTasks(List<string> taskslist)
            {
                if (tasks.Count == 0)
                {
                    Console.WriteLine("No tasks available.");
                    return;
                }

                for (int i = 0; i < taskslist.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {taskslist[i]}");
                }
            }

            void AddTask(List<string> taskslist)
            {
                Console.Write("Enter the description for the new task: ");
                string tasksname = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(tasksname))
                {
                    taskslist.Add(tasksname);
                    Console.WriteLine("Task added");
                }
                else Console.WriteLine("You need to enter a value");

            }

            void RemoveTask(List<string> taskslist)
            {
                Console.Write("Enter the number of the task to remove: ");
                if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= taskslist.Count)
                {
                    taskslist.RemoveAt(taskNumber - 1);
                    Console.WriteLine("Task removed.");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }

            int ShowMenu()
            {
                Console.WriteLine();
                Console.WriteLine("1. Add task");
                Console.WriteLine("2. View tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("0. Exit");

                Console.Write("Choose your option : ");
                int optionread = int.Parse(Console.ReadLine());
                return optionread;

            }

            int option = 0;
           
            bool running = true;

            while (running)
            {
                option = ShowMenu();

                switch (option)
                {
                    case 1:
                        AddTask(tasks);
                        break;

                    case 2:
                        ShowTasks(tasks);
                        break;

                    case 3:
                        RemoveTask(tasks);
                        break;
                    case 0:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }

            Console.WriteLine("Variable scope defines the accessibility and visibility of a variable within the code. It determines which parts of the program are allowed to read or modify that variable.");
            Console.WriteLine("A variable declared inside one method cannot be accessed directly from another method.");
        }

        static void Exercice6()
        {
            Console.WriteLine("Exercise 6 : Enums, Constants and Final Integration");

            TaskPriority priority = TaskPriority.High;
            //Console.WriteLine(priority);

            switch (priority)
            {
                case TaskPriority.Low:
                    Console.WriteLine("This task can wait.");
                    break;

                case TaskPriority.Medium:
                    Console.WriteLine("Try to finish this task today.");
                    break;

                case TaskPriority.High:
                    Console.WriteLine("Prioritize this task.");
                    break;
            }

            const int MaxTasks = 10;

            List<string> tasks = new List<string>();
            tasks.Add("Review C# variables");
            tasks.Add("Practice loops");
            tasks.Add("Create a Console application");
            Console.WriteLine($"Number of tasks: {tasks.Count}");


            void ShowTasks(List<string> taskslist)
            {
                if (tasks.Count == 0)
                {
                    Console.WriteLine("No tasks available.");
                    return;
                }

                for (int i = 0; i < taskslist.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {taskslist[i]}");
                }
            }

            void AddTask(List<string> taskslist)
            {
                Console.Write("Enter the description for the new task: ");
                string tasksname = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(tasksname))
                {
                    taskslist.Add(tasksname);
                    Console.WriteLine("Task added");
                }
                else Console.WriteLine("You need to enter a value");

            }

            void RemoveTask(List<string> taskslist)
            {
                Console.Write("Enter the number of the task to remove: ");
                if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= taskslist.Count)
                {
                    taskslist.RemoveAt(taskNumber - 1);
                    Console.WriteLine("Task removed.");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }

            int ShowMenu()
            {
                Console.WriteLine();
                Console.WriteLine("1. Add task");
                Console.WriteLine("2. View tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Show task count");
                Console.WriteLine("0. Exit");

                Console.Write("Choose your option : ");
                int optionread = int.Parse(Console.ReadLine());
                return optionread;

            }

            void ShowTaskCount()
            {
                int currentCount = tasks.Count;
                int remainingCapacity = MaxTasks - currentCount;

                Console.WriteLine($"\nYou currently have {currentCount} tasks.");
                Console.WriteLine($"Maximum allowed: {MaxTasks}");
                Console.WriteLine($"Remaining capacity: {remainingCapacity}");
            }

            int option = 0;

            bool running = true;

            while (running)
            {
                option = ShowMenu();

                switch (option)
                {
                    case 1:
                        AddTask(tasks);
                        break;

                    case 2:
                        ShowTasks(tasks);
                        break;

                    case 3:
                        RemoveTask(tasks);
                        break;

                    case 4:
                        ShowTaskCount();
                        break;

                    case 0:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }

            #region Memo

            if (tasks.Count >= MaxTasks)
            {
                Console.WriteLine("Maximum number of tasks reached.");
            }
            else
            {
                // add task
            }
            #endregion
        }

        static void Exercice7()
        {
            Console.WriteLine("Exercise 7 : Independent Challenges");

            #region 1 - Input validation

            Console.WriteLine("1 - Input validation");
            Console.Write("Select a number : ");
            int number = 0;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid data.");
                Console.Write("Select a number : ");
            }
            Console.WriteLine($"You selected {number}...");

            #endregion

            #region 2 - Prevent empty tasks

            Console.WriteLine("2 - Prevent empty tasks");
            Console.Write("What's your name : ");
            string name= Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid data.");
                Console.Write("What's your name : ");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Your name is {name}...");

            #endregion

            #region 3 - Search tasks

            Console.WriteLine("3 - Search tasks");

            List<string> tasks = new List<string>();
            tasks.Add("Review C# variables");
            tasks.Add("Practice loops");
            tasks.Add("Create a Console application");
            Console.WriteLine($"Number of tasks: {tasks.Count}");

            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks to search.");
                return;
            }
            Console.Write("What keyword are you searching ? : ");
            string keyword = Console.ReadLine();
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Contains(keyword))
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }

            #endregion

            #region 4 - LINQ //Not done yet

            Console.WriteLine("4 - LINQ");

            #endregion

            #region 5 - Persist the tasks //Not done yet

            Console.WriteLine("5 - Persist the tasks");

            #endregion


        }

        static void Fin()
        {
            Console.ReadKey(); //To prevent the console from closing immediately after the program is run.
        }

        static void Main(string[] args)
        {
            string continuer = "Y";
            do
            {
                Console.WriteLine("This code is made of 10 exercices. Indiquez le numéro correspondant à ce que vous souhaitez exécuter :");
                Console.WriteLine("0 : Do not run anything");
                Console.WriteLine("1 : Exercice 1 : Introduction");
                Console.WriteLine("2 : Exercice 2 : Variables and inputs");
                Console.WriteLine("3 : Exercice 3 : Conditions and switch");
                Console.WriteLine("4 : Exercice 4 : Loops and lists");
                Console.WriteLine("5 : Exercice 5 : Methods and Refactoring");
                Console.WriteLine("6 : Exercice 6 : Enums, Constants and Final Integration");
                Console.WriteLine("7 : Exercice 7 : Independent Challenges");
                Console.WriteLine("8 : Execution of everything in order");
                SwitchTD();
                Console.WriteLine("Execution done, do you want to run something else ? (Y/N)");
                continuer = Console.ReadLine();
            }
            while ((continuer == "Y") || (continuer == "y"));
            Console.WriteLine("End of program, tap any key to close this window.");
            Fin();

            void SwitchTD()
            {
                int choix = 9;

                while (8 < choix)
                {
                    choix = Convert.ToInt32(Console.ReadLine());
                    switch (choix)
                    {
                        case 0:
                            Console.WriteLine("You choose to run nothing");
                            Console.WriteLine("End of program, tap any key to close this window.");
                            Fin();
                            break;
                        case 1:
                            Console.WriteLine("Exercice 1 : Introduction");
                            Exercice1();
                            break;
                        case 2:
                            Console.WriteLine("Exercice 2 : Variables and inputs");
                            Exercice2();
                            break;
                        case 3:
                            Console.WriteLine("Exercice 3 : Conditions and switch");
                            Exercice3();
                            break;
                        case 4:
                            Console.WriteLine("Exercice 4 : Loops and lists");
                            Exercice4();
                            break;
                        case 5:
                            Console.WriteLine("Exercice 5 : Methods and Refactoring");
                            Exercice5();
                            break;
                        case 6:
                            Console.WriteLine("Exercice 6 : Enums, Constants and Final Integration");
                            Exercice6();
                            break;
                        case 7:
                            Console.WriteLine("Exercice 7 : Independent Challenges");
                            Exercice7();
                            break;
                        case 8:
                            Console.WriteLine("Execution of everything");
                            Exercice1();
                            Exercice2();
                            Exercice3();
                            Exercice4();
                            Exercice5();
                            Exercice6();
                            Exercice7();
                            break;
                        default:
                            Console.WriteLine("This option does not exist.");
                            break;
                    }
                }
            }
        }

    }

    enum TaskPriority
    {
        Low,
        Medium,
        High
    }
}