using System;

public class word
{
    public string _words = "";
    public string _ref = "";
    public string[] _result;
    public List<int> _hidden;
  
    public Word()
    {
    }
   
    public Word(string text, string visible)
    {
    }
    
    public void GetRenderedText(Scripture scripture)
    {
        var _words = scripture._scriptureText;
        _result = _words.Split(" ");
        _hidden = new List<int>();
    }
