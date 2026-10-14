using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Programming_Paradigms
{
    internal class Program
    {
        static void Exercice1()
        {

            Console.WriteLine("Exercise 1 : Rolling a dice");

            Random random = new Random();
            int studentRoll = 1;
            int computerRoll = 0;

            do
            {
                Console.WriteLine("Rolling the dice for the student...");
                studentRoll = random.Next(1, 7);
                Console.WriteLine("Rolling the dice for the computer...");
                computerRoll = random.Next(1, 7);
                Console.WriteLine("The student rolled a " + studentRoll);
                Console.WriteLine("The computer rolled a " + computerRoll);

                if (studentRoll > computerRoll)
                {
                    Console.WriteLine("The student wins!");
                }
                else if (studentRoll < computerRoll)
                {
                    Console.WriteLine("The computer wins!");
                }
                else
                {
                    Console.WriteLine("It's a tie ! Let's try again");
                }
            } while (studentRoll == computerRoll);
        }

        static void Exercice2() 
        {
            Console.WriteLine("Exercise 2 : Student Information");

            List<double> grades = new List<double>();

            for(int i=0; i < 5; i++)
            {
                Console.WriteLine("Please enter the grade n° " + (i + 1) + " :");
                double grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);
            }

            Console.WriteLine("Your best grade is " + grades.Max());
            Console.WriteLine("Your worst grade is " + grades.Min());
            Console.WriteLine("Your average grade is " + grades.Average());

        }

        static void Fin()
        {
            Console.ReadKey(); //To prevent the console from closing immediately after the program is run.
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This code was made by : Cristina Schmidt");
            string continuer = "Y";
            do
            {
                Console.WriteLine("This code is made of 2 exercises. What do you want to execute ? :");
                Console.WriteLine("0 : Do not run anything");
                Console.WriteLine("1 : Exercice 1 : Rolling a dice");
                Console.WriteLine("2 : Exercice 2 : Student Information");
                Console.WriteLine("3 : Execute everything");
                SwitchTD();
                Console.WriteLine("Execution done, do you want to run something else ? (Y/N)");
                continuer = Console.ReadLine();
            }
            while ((continuer == "Y") || (continuer == "y"));
            Console.WriteLine("End of program, tap any key to close this window.");
            Fin();

            void SwitchTD()
            {
                int choix = 4;

                while (3 < choix)
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
                            Console.WriteLine("Exercice 1 : Rolling a dice");
                            Exercice1();
                            break;
                        case 2:
                            Console.WriteLine("Exercice 2 : Student Information");
                            Exercice2();
                            break;
                        case 3:
                            Console.WriteLine("Execution of everything");
                            Exercice1();
                            Exercice2();
                            break;
                        default:
                            Console.WriteLine("This option does not exist.");
                            break;
                    }
                }
            }
        }




    }
}
