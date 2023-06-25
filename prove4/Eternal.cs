using System;
using System.Collections.Generic;
using System.IO;

class Eternal : Goal
{
    bool _isComplete = false;
    public Eternal()
    {
        _type = "E";

    }

    public Eternal(string name, string desc, int points)
    {
        _type = "E";
        _name = name;
        _description = desc;
        _pointVal = points;
    }

  
}
