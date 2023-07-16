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

        public void Products()
        { 
         Console.WriteLine(content);
        }

        public void Date()
        { 
        Console.WriteLine(date);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Customer Order Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Select Customer");
                Console.WriteLine("2. View order dates");
                Console.WriteLine("3. View products");
                Console.WriteLine("4. Quit");

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
                        comments.Products();
                        break;
                    case "4":
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
