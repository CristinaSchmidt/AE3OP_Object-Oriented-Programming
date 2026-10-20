static void Main(string[] args)
{
    Teacher T1 = new Teacher("Cristina Schmidt", "Cello", 10);
    Teacher T2 = new Teacher("Victor Schmidt", "Piano", 5);
    COnsole.WriteLine("Two new teachers were created");
    Console.WriteLine(T1.Name + " and "+ T2.Name+" here are their infos: ");  
    Console.WriteLine(T1.ToString());
    Console.WriteLine(T2.ToString());

    Console.ReadKey(); //To prevent the console from closing immediately after the program is run.
}
