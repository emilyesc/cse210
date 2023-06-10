using System;

class Reflecting : Activity
{
    string _welcomeMessage = "\nThis activity will help you reflect on times in your life when you have shown \nstrength and resilience. This will help you recognize the power you have and how you can use it \nin other aspects of your life.\n \n";
     
    List<string> startQuestions = new List<string>()
    {
        "> Think of a time when you pushed yourself outside your comfort zone\n \n",
        "> Think of a time when you did something really difficult.\n \n",
        "> Think of a time when you helped someone in need.\n \n",
        "> Think of a time when you did something truly selfless.\n \n",
        "> Think of a time when you followed the promptings of the Holy Ghost.\n \n",
        "> Think of something amazing that happened recently that you want to remember.\n \n",
        "> Think of a time you made someone smile. \n \n",
        "> Think of a time when the work you were doing felt satisfying. \n \n"
    };

    List<string> refQuestions = new List<string>()
    {
        "> Why was this experience meaningful to you?\n \n",
        "> Have you ever done anything like this before?\n \n",
        "> How did you get started?\n \n",
        "> How did you feel when it was complete?\n \n",
        "> What is your favorite thing about this experience?\n \n",
        "> What did you learn from this experience that applies to other situations?\n \n",
        "> What did you learn about yourself from this experience?\n \n",
        "> How can you keep this experience in your mind in the future?\n \n",
        "> What surprised you the most about this experience? \n \n",
        "> What would your best friend say about this experience to encourage you? \n \n",
        "> If you could go back in time, what would you tell yourself about this experience? \n \n",
        "> What questions has this experience brought to your mind? \n \n",
        "> What is the most important thing to remember about this experience? \n \n",
        "> Is there anything you would do differently because of this experience? \n \n",
        "> What does this experience tell you about yourself? \n \n",
        "> Has this experience changed your relationships with anyone? If so, how? \n \n"
    };
    
    public Reflecting()
    {

    }
    
    
    List<string> startQuestions = new List<string>()
    {
        "> Think of a time when you stood up for someone.\n \n",
        "> Think of a time when you did something really difficult.\n \n",
        "> Think of a time when you helped someone in need.\n \n",
        "> Think of a time when you did something truly selfless.\n \n",
        "> Think of a time when you followed the promptings of the Holy Ghost.\n \n",
        "> Think of something amazing that happened recently that you want to remember.\n \n",
        "> Think of a time you made someone smile. \n \n",
        "> Think of a time when the work you were doing felt satisfying. \n \n"
    };

   public void startReflecting()
    {
        Console.WriteLine(_welcomeMessage);
        Timer refTime = new Timer();
        refTime.activityTime();
        int seconds = refTime._timeSet;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(refTime._timeSet);
        if (DateTime.Now < endTime)
        {
            var random = new Random();
            int index = random.Next(startQuestions.Count);
            string startQ = startQuestions[index];
            Console.WriteLine(startQ);
            Thread.Sleep(10000);
            while (DateTime.Now < endTime)
            {
                var random2 = new Random();
                int index2 = random.Next(refQuestions.Count);
                string refQ = refQuestions[index2];
                refQuestions.Remove(refQuestions[index2]);
                Console.WriteLine(refQ);
                Thread.Sleep(10000);

            }
        }
        
    Console.WriteLine($"Well done! You completed {seconds} seconds of the reflecting activity.\n");
        Thread.Sleep(5000);
    }

}
