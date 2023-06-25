using System;
using System.Collections.Generic;
using System.IO;

class Checklist : Goal
{
    bool _isComplete = false;
    int _numEntries = 0;
    int _numTillDone = 0;

    public Checklist()
    {
        _type = "C";
    }
    public Checklist(string name, string desc, int points, int numTillDone, int numEntries)
    {
        _type = "C";
        _name = name;
        _description = desc;
        _pointVal = points;
        _numTillDone = numTillDone;
        _numEntries = numEntries;
    }


    public int promptEntries()
    {
        Console.WriteLine("\nHow many times until this goal is complete? ");
        int numTillDone = Int32.Parse(Console.ReadLine());
        _numTillDone = numTillDone;
        return _numTillDone;
    }

}
