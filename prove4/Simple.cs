using System;
using System.Collections.Generic;
using System.IO;

class Simple : Goal
{
    bool _isComplete = false;

    public Simple()
    {
        _type = "S";
    }

    public Simple(string name, string description, int pointVal, bool isComplete)
    {
        _type = "S";
        _name = name;
        _description = description;
        _pointVal = pointVal;
        _isComplete = isComplete;
    }
    
    public string getName()
    {
        Console.WriteLine("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        _name = name;
        return _name;
    }

    public string getDesc()
    {
        Console.WriteLine("\nWhat is a short description of your goal? ");
        string desc = Console.ReadLine();
        _description = desc;
        return _description;
    }


    public int getPoints()
    {
        Console.WriteLine("\nHow many points is this goal worth? ");
        int points = Int32.Parse(Console.ReadLine());
        _pointVal = points;
        return _pointVal;
    }


}
