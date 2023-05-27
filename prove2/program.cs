using System;

class Program
{
  static void Main(string[] args)
    {
      Console.Clear();
        Reference reference = new Reference();
        reference.LoadReference();
        Scripture scripture = new Scripture();
        scripture.LoadScriptures();
        Word word = new Word();
        
     Console.Write("\n**** Welcome to the Scripture Memorizer Program ****\n");
     
     
    static int UserChoice()
    // Method to display choices to user
    {
        Reference reference = new Reference();

        string choices = $@"
===========================================
Please select one of the following choices:
1. Display all availble scriptures references
2. Randomly select scripture to work on
Q. Quit
===========================================
What would you like to do?  ";

        Console.Write(choices);

        string userInput = Console.ReadLine();
        userInput.ToLower();
        int userChoice = 0;
        // This block catches any non integer values that are entered
        try
        {
            if (userInput == "q")
            {
                userInput = "3";
            }
            userChoice = int.Parse(userInput);
        }
        catch (FormatException)
        {
            userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return userChoice;
    }


}
