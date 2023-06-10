using System;

class Listing : Activity
{
    public Listing()
    {

    }

    List<string> keepListing = new List<string>()
    {
        "> Who are people that you appreciate? \n",
        "> What are personal strengths of yours? \n",
        "> Who are people that you have helped this week? \n",
        "> When have you felt the Holy Ghost this month? \n",
        "> Who are some of your personal heroes? \n",
        "> What are some tender mercies from the Lord you've noticed? \n",
        "> How have your prayers been answered, big or small? \n",
        "> What are the little things you've taken time to do that have added to your days? \n",
        "> What would you like to say yes to in the future? \n",
        "> What would your Heavenly Father like you to remember? \n"
    };
    string _welcomeMessage = "\nThis activity will help you reflect on the good things in your life by having you list as many\nthings as you can in a certain area. \n";
    
    
    public void startListing()
    {
        Timer listTime = new Timer();
        listTime.activityTime();
        int seconds = listTime._timeSet;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(listTime._timeSet);
        var prompt = new Random();
        int listIndex = prompt.Next(keepListing.Count);
        string listPrompt = keepListing[listIndex];
        Console.WriteLine(listPrompt);
        Console.WriteLine("\nTake 5 seconds to consider, then start listing.\n");
        Thread.Sleep(5000);
        int lCount = 0;
        Console.WriteLine("Start Listing! \n");

        {
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string list = Console.ReadLine();
                lCount++;
            }
        }

