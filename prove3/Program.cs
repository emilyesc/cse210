using System;

class Program
{
    static void Main(string[] args)
    {
          bool runProg = true;

          while (runProg == true)
          {
            Menu menu = new Menu();
            Console.WriteLine("\nWelcome to the Mindfulness Program. Each activity is designed to help you \nslow down from the fast-paced world, and to think and feel deeply.\nPlease select from the following activities, or select 4 to quit.\n");
            menu.DisplayMenu();
            int activity = Int32.Parse(Console.ReadLine());

          }
    }
}
