using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_Programming_Paradigms
{
    internal class Program
    {
        static void Fin()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Teacher T1 = new Teacher("Cristina Schmidt", "Cello", 10);
            Teacher T2 = new Teacher("Victor Schmidt", "Piano", 5);
            Console.WriteLine("Two new teachers were created");
            Console.WriteLine(T1.Name + " and " + T2.Name + " here are their infos: ");

            Console.WriteLine(T1.ToString());
            Console.WriteLine(T2.ToString());

            Console.WriteLine("Printing teacher's info using ShowProfile method");
            T1.ShowProfile();
            T2.ShowProfile();

            List<Teacher> teachers = new List<Teacher>();

            teachers.Add(new Teacher("Jack Junior", "Violin", 2));
            teachers.Add(new Teacher("Bernardo Mantoni", "Flute", 9));
            teachers.Add(new Teacher("Clara Garcia", "Triangle", 3));

            foreach (Teacher teacher in teachers)
            {
                teacher.ShowProfile();
                Console.WriteLine();
            }

            Console.WriteLine("5-Final Challenge");

            string name = "";
            string subject = "";
            int yearsOfExperience = 0;
            Teacher TX = new Teacher("name", "subject", 0);
            double average = 0;


            Console.WriteLine("This code was made by : Cristina Schmidt");
            string continuer = "Y";
            do
            {
                Console.WriteLine("What do you want to execute ? :");
                Console.WriteLine("0 : Do not run anything");
                Console.WriteLine("1 : Add teachers");
                Console.WriteLine("2 : Show teachers");
                Console.WriteLine("3 : Count teachers");
                Console.WriteLine("4 : Average experience of teachers");
                SwitchTD();
                Console.WriteLine("Execution done, do you want to run something else ? (Y/N)");
                continuer = Console.ReadLine();
            }
            while ((continuer == "Y") || (continuer == "y"));
            Console.WriteLine("End of program, tap any key to close this window.");
            Fin();

            void SwitchTD()
            {
                int choix = 6;

                while (5 < choix)
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

                            Console.WriteLine("What is the teacher's name ?");
                            name = Console.ReadLine();
                            Console.WriteLine("What is the teacher's subject ?");
                            subject = Console.ReadLine();
                            Console.WriteLine("What is the teacher's years of experience ?");
                            yearsOfExperience = Convert.ToInt32(Console.ReadLine());

                            TX = new Teacher(name,subject, yearsOfExperience);
                            teachers.Add(TX);

                            break;
                        case 2:
                            for(int i =0;i< teachers.Count; i++)
                            {
                                teachers[i].ShowProfile();
                            }
                            break;
                        case 3:
                            Console.WriteLine("There are " + teachers.Count + " teachers in the list.");
                            break;
                        case 4:
                            average = 0;
                            for (int i = 0; i < teachers.Count; i++)
                            {
                                average+=teachers[i].YearsOfExperience;
                            }
                            average = average / teachers.Count;
                            Console.WriteLine("The average experience of the teachers is " + average + " years.");
                            break;
                        default:
                            Console.WriteLine("This option does not exist.");
                            break;
                    }
                }
            }

            Console.ReadKey(); //To prevent the console from closing immediately after the program is run.
        }
    }
}
