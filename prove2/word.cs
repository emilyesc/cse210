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
   
    private Word(string text, string visible)
    {
    }
    
    private void GetRenderedText(Scripture scripture)
    {
        var _words = scripture._scriptureText;
        _result = _words.Split(" ");
        _hidden = new List<int>();
    }
    
    private void GetRenderedRef(Scripture scripture)
    {
    }
    
    private void Show(string ref1)
    {
        _ref = ref1;
        Console.Clear();
        Console.Write("\n**** Press spacebar or enter to hide words ****");
        Console.Write("\n**** Press Q to Quit ****\n");
        Console.WriteLine($"{_ref}");
        for (var i = 0; i < _result.Length; i++)
        {
            var str = _result[i];
            int len = str.Length;
            string dashedLine = new String('_', len);
            if (_hidden.Contains(i))
            {
                Console.Write($"{dashedLine} ");
            }
            else
            {
                Console.Write($"{str} ");
            }
        }
    }

    private void GetReadKey()
    {
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
        {
            GetNewHiddenWord();
        }
        else if (input.Key == ConsoleKey.Q)
        {
            Environment.Exit(0);
        }
    }
    
    private void GetNewHiddenWord()
    {
        
        var random = new Random();
        var index1 = random.Next(_result.Length);
        var index2 = random.Next(_result.Length);
        if (_hidden.Contains(index1) || _hidden.Contains(index2))
        {
            GetNewHiddenWord();
        }
        else
        {
            _hidden.Add(index1);
            _hidden.Add(index2);

        }
    }


}
