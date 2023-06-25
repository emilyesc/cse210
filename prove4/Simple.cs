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
    

}
