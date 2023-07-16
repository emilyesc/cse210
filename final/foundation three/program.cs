using System;


namespace foundation3
{
    class Events
    {
        public string events { get; set; }
        public string location { get; set; }
        public string time { get; set; }
    }

    class Schedule
    {

        public void Event()
        {
            Console.WriteLine(events);
 
        }

        public void Locations()
        { 
         Console.WriteLine(location);
        }

        public void Time()
        { 
        Console.WriteLine(time);
        }
        public void Plan()
        {   
          Console.WriteLine(plan);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Event Planning Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. View Available Events");
                Console.WriteLine("2. View Times");
                Console.WriteLine("3. View Locations");
                Console.WriteLine("4. View Planned Events");
                Console.WriteLine("5. Quit");

                Console.Write("What would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    
                    case "1":
                        schedule.Event();
                        break;
                    case "2":
                        schedule.Time();
                        break;
                    case "3":
                        schedule.Locations();
                        break;
                    case "4":
                        schedule.Plan();
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
