using System;

public class Menu
{
    protected List<string> menuOpts = new List<string>()
    {
        "1. Breathing Activity",
        "2. Reflection Activity",
        "3. Listing Activity",
        "4. Quit"
    }
    
    public void DisplayMenu()
    {
         for (int x = 0; x < menuOpts.Count; x++)
        {
            Console.WriteLine(menuOpts[x]);
        }
    }
 }
