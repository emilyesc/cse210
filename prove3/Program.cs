using System;

class Program
{
    static void Main(string[] args)
    {
          bool runProg = true;

          while (runProg == true)
          {
            Menu menu = new Menu();
            Console.WriteLine("\nWelcome to the Mindfulness Program. Each activity is designed to help you \nslow down from the fast-paced world, and to think and feel deeply.\nPlease select from the following activities, or select 5 to quit.\n");
            menu.DisplayMenu();
            var activity = 0;
            
            //used this to catch any non-integer answers
            while (!int.TryParse(Console.ReadLine(), out activity))
            {
                Console.WriteLine("Sorry, only numerical options are accepted. Please try again.");
            }

                
              
             if (activity == 1)
            {
                Timer startTime = new Timer();
                startTime.prepTime();
                Breathing breathing = new Breathing();
                breathing.startBreathing();

            }
              
            else if (activity == 2)
            {
                Timer startTime = new Timer();
                startTime.prepTime();
                Reflecting reflecting = new Reflecting();
                reflecting.startReflecting();

            }
              
            else if (activity == 3)
            {
                Timer startTime = new Timer();
                startTime.prepTime();
                Listing listing = new Listing();
                listing.startListing();
            }
              //A little journal activity
            else if (activity == 4)
                {
                Console.WriteLine("Write one or two sentences about your day");
                Console.ReadLine();
            }
                
              //little easter egg
            else if (activity == 911)
            {
                Console.WriteLine("If suffering from serious injury or pain, please use a phone to dial 911.");
            }
              
            else if (activity == 5)
            {
            runProg = false;
            }
            
              // this catches integer inputs that don't match the options
            else
            {
                Console.WriteLine("Sorry, you did not input a valid option. Please try again.");
                
            }


          }
    }
}
