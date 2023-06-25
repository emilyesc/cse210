using System;
using System.Collections.Generic;
using System.IO;

class Goal
{
    public string _type;
    public string _name;
    public string _description;
    public int _pointVal;
    public int _numEntries;
    public int _numTillDone;
    public bool _isComplete;
    public int _pointsEarned;
    public string check;

    public Goal()
    {

    }

    public Goal(string type, string name, string description, int pointVal, bool isComplete, int numEntries, int numTillDone)
    {
        _type = type;
        _name = name;
        _description = description;
        _pointVal = pointVal;
        _isComplete = isComplete;
        _numEntries = numEntries;
        _numTillDone = numTillDone;

    }


    public string promptName()
    {
        Console.WriteLine("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        _name = name;
        return _name;
    }


    public string promptDesc()
    {
        Console.WriteLine("\nWhat is a short description of your goal? ");
        string description = Console.ReadLine();
        _description = description;
        return _description;
    }


    public int promptPoints()
    {
        Console.WriteLine("\nHow many points will this goal be worth?");
        int points = Int32.Parse(Console.ReadLine());
        _pointVal = points;
        return _pointVal;
    }

    public string IsComplete(bool _isComplete)
    {
        if (_isComplete == true)
        {
            check = "X";
        }
        else if (_isComplete == false)
        {
            check = " ";
        }
        return check;
    }


}
