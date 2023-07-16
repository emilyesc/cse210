using System;


namespace foundation1
{
    class Video
    {
        public string videoName { get; set; }
        public string comments { get; set; }
        public string views { get; set; }
    }

    class Comments
    {

        public void Display()
        {
            Console.WriteLine(comments);
 
        }

        public void Content()
        { 
         Console.WriteLine(content);
        }

        public void Date()
        { 
        Console.WriteLine(date);
        }
        public void Analyze()
        {   
          Console.WriteLine(analyze);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Video Analysis Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Display Comments");
                Console.WriteLine("2. Date");
                Console.WriteLine("3. Analysis");
                Console.WriteLine("4. Content");
                Console.WriteLine("5. Quit");

                Console.Write("What would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    
                    case "1":
                        comments.Display();
                        break;
                    case "2":
                        comments.Date();
                        break;
                    case "3":
                        comments.Analyze();
                        break;
                    case "4":
                        comments.Content();
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
