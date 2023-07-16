using System;


namespace foundation2
{
    class Customer
    {
        public string customers { get; set; }
        public string dats { get; set; }
        public string products { get; set; }
    }

    class Orders
    {

        public void Display()
        {
            Console.WriteLine(orders);
 
        }

        public void Products()
        { 
         Console.WriteLine(products);
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
                        orders.Display();
                        break;
                    case "2":
                        orders.Date();
                        break;
                    case "3":
                        orders.Products();
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
