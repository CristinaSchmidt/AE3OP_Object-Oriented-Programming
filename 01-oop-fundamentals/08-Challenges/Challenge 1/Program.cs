static void Main(string[] args)
{
    Teacher T1 = new Teacher("Cristina Schmidt", "Cello", 10);
    Teacher T2 = new Teacher("Victor Schmidt", "Piano", 5);

    Console.WriteLine(T1.ToString());
    Console.WriteLine(T2.ToString());

    Console.ReadKey(); //To prevent the console from closing immediately after the program is run.
}
