static void Main(string[] args)
{
    Teacher T1 = new Teacher("Cristina Schmidt", "Cello", 10);
    Teacher T2 = new Teacher("Victor Schmidt", "Piano", 5);
    Console.WriteLine("Two new teachers were created");
    Console.WriteLine(T1.Name + " and "+ T2.Name+" here are their infos: "); 
    
    Console.WriteLine(T1.ToString());
    Console.WriteLine(T2.ToString());

    Console.WriteLine("Printing teacher's info using ShowProfile method");
    T1.ShowProfile();
    T2.ShowProfile();

    Console.ReadKey(); //To prevent the console from closing immediately after the program is run.
}
