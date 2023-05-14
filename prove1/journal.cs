using System;
using System.IO;
using System.Text;

namespace DailyJournal
{
    class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }

        public Entry(string prompt, string response, string date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

    }

    class Journal
    {
        public List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(string prompt)
        {
            Console.Write(prompt + " ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            entries.Add(new Entry(prompt, response, date));
        }

        public void DisplayEntries()
        {
            Console.WriteLine(entries);
 
        }

        public void SaveToFile()
        {
            Console.WriteLine("Journal saved to file.");
        }

        public void LoadFromFile()
        {
            Console.WriteLine("Journal loaded from file.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

 
            List<string> prompts = new List<string>
            {
                "Did anything unexpected happen today? ",
                "How did you see God's hand in your life today?",
                "Is there anything you wish you did differently today?",
                "What blessings happened today?",
                "What's something you learned today?",
            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Journal Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display Journal Entries");
                Console.WriteLine("3. Save Journal");
                Console.WriteLine("4. Load Journal");
                Console.WriteLine("5. Quit");

                Console.Write("What would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        journal.AddEntry(prompts[new Random().Next(prompts.Count)]);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
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
