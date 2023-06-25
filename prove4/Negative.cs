using System;
using System.Collections.Generic;
using System.IO;

class Negative : Goal
{
    bool _isComplete = false;

    public Negative()
    {
        _type = "N";

    }

    public Negative(string name, string description, int pointVal, bool isComplete)
    {
        _type = "S";
        _name = name;
        _description = description;
        _pointVal = pointVal;
        _isComplete = isComplete;

    }
}
