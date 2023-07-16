using System;


namespace foundation4
{
    class Timing
    {
        public string exercises { get; set; }
        public string timer { get; set; }
        public string activities { get; set; }
    }

    class Exercise
    {

        public void Exercises()
        {
            Console.WriteLine(exercises);
 
        }

        public void Timer()
        { 
         Console.WriteLine(timer);
        }

        public void Activities()
        { 
        Console.WriteLine(activities);
        }
        public void Past()
        {   
          Console.WriteLine(activities);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Exercise Activity tracking Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Display Exercises");
                Console.WriteLine("2. Time an exercise");
                Console.WriteLine("3. Add new exercises ");
                Console.WriteLine("4. View past exercises");
                Console.WriteLine("5. Quit");

                Console.Write("What would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    
                    case "1":
                        exercise.Exercises();
                        break;
                    case "2":
                        exercise.Timer();
                        break;
                    case "3":
                        exercise.Activities();
                        break;
                    case "4":
                        exercise.Past();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
