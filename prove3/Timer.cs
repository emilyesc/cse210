using System;

class Timer
{
   //after experimenting, i found it was better to seperate the timer like this
    public Timer()
    {

    }
    public int _timeSet;
    protected string _timeRequested = "How long in seconds would you like to do this activity? ";
    protected string _getReady = "Prepare to begin. . . ";
        
    public int getTime()
    {
        Console.WriteLine(_timeRequested);
        _timeSet = Int32.Parse(Console.ReadLine());
        return _timeSet;
    }

    public void prepTime()
    {
        Console.WriteLine(_getReady);
        for (int x = 0; x < 5; x++)
        {
            Console.Write("|");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Thread.Sleep(150);
        }
    }
  
    public int activityTime()
    {
        Console.WriteLine("How long in seconds would you like this activity to last? ");
        _timeSet = Int32.Parse(Console.ReadLine());
        return _timeSet;

    }

}
