using System;
using System.Collections.Generic;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        List<Goal> goalsList = new List<Goal>();
        int points = 0;
        bool startGoals = true;
        Console.WriteLine($"\nYou have earned {points} points.");
        Console.WriteLine("\nWelcome to the Eternal Goals program. Please select from the following menu options: \n");

        while (startGoals == true)
        {
            Menu menu = new Menu();
            menu.displayMenu();
            Console.Write("\nEnter your selection: ");
            int choice = Int32.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Menu menu1 = new Menu();
                Console.WriteLine("\nWhat type of goal would you like to create? ");
                menu.displayGoalTypes();
                Console.Write("\nEnter your selection: ");
                int type = Int32.Parse(Console.ReadLine());

                if (type == 1)
                {
                    Simple goal1 = new Simple();
                    string name = goal1.promptName();
                    string desc = goal1.promptDesc();
                    int pointVal = goal1.promptPoints();
                    goalsList.Add(goal1);

                }
                if (type == 2)
                {
                    Checklist goal2 = new Checklist();
                    string name = goal2.promptName();
                    string desc = goal2.promptDesc();
                    int pointVal = goal2.promptPoints();
                    int numEntries = goal2.promptEntries();
                    int numTillDone = numEntries;
                    goalsList.Add(goal2);
                }
                if (type == 3)
                {
                    Eternal goal3 = new Eternal();
                    string name = goal3.promptName();
                    string desc = goal3.promptDesc();
                    int pointVal = goal3.promptPoints();
                    goalsList.Add(goal3);
                }
                
                 if (type == 4)
                {
                    Eternal goal3 = new Negative();
                    string name = goal4.promptName();
                    string desc = goal4.promptDesc();
                    int pointVal = goal4.promptPoints();
                    goalsList.Add(goal4);
                }
                Console.WriteLine("\nMake another selection: ");
                startGoals = true;
            }

            if (choice == 2)
            {
                int x = 1;
                foreach (Goal Goal in goalsList)
                {
                    Goal glist = new Goal();
                    string name = Goal._name;
                    string type = Goal._type;
                    string desc = Goal._description;
                    int pworth = Goal._pointVal;
                    int numEntries = Goal._numEntries;
                    int numTillDone = Goal._numTillDone;
                    bool isComplete = Goal._isComplete;


                    if (Goal._type == "S")
                    {
                        Console.WriteLine($"{x++}. [ ] {name}, {desc}, worth {pworth} points.");
                    }
                    else if (Goal._type == "C")
                    {
                        Console.WriteLine($"{x++}. [ ] {name}, {desc}, worth {pworth} points, {numEntries} / {numTillDone} completed.");
                    }
                    else if (Goal._type == "E")
                    {
                        Console.WriteLine($"{x++}. [ ] {name}, {desc}, worth {pworth} points. *Eternal*");
                    }
                    else if (Goal._type == "N")
                    {
                        Console.WriteLine($"{x++}. [ ] {name}, {desc}, subtracts {pworth} points, Negative");
                    }
                }
                startGoals = true;
            }

            if (choice == 3)
            {
                Console.WriteLine("\nWhat filename should this save to? ");
                string fileName = (Console.ReadLine());
                int i = 1;
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Goal goal in goalsList)
                    {
                        if (goal._type == "S")
                        {
                            outputFile.WriteLine($"{i++}. |[ ] | {goal._name}, | {goal._description}, | worth {goal._pointVal} points | {goal._type}");
                        }
                        else if (goal._type == "C")
                        {
                            outputFile.WriteLine($"{i++}. |[ ] | {goal._name}, | {goal._description}, | worth {goal._pointVal} points | {goal._type} | {goal._numEntries} / {goal._numTillDone} completed.");
                        }
                        else if (goal._type == "E")
                        {
                            outputFile.WriteLine($"{i++}. |[ ] | {goal._name}, | {goal._description}, | worth {goal._pointVal} points | {goal._type}");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                    }
                }

                startGoals = true;
            }

            if (choice == 4)
            {
                Goal goal = new Goal();
                Console.WriteLine("Enter the filename to be opened: ");
                string filename = (Console.ReadLine());
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");
                    goal._name = parts[0];
                    goal._description = parts[1];
                    goal._pointVal = Int32.Parse(parts[2]);
                    goal._isComplete = bool.Parse(parts[3]);
                    goal._type = parts[4];
                    goal._numEntries = Int32.Parse(parts[5]);
                    goal._numTillDone = Int32.Parse(parts[6]);
                }
                goalsList.Add(goal);

            }

            if (choice == 5)
            {
                Console.WriteLine("Which goal are you recording?");
                int goalNum = Int32.Parse(Console.ReadLine());
                int i = 1;
                foreach (Goal goal in goalsList)
                {
                    if (i == goalNum)
                    {
                        if (goal._type == "S")
                        {
                            goalsList[i]._isComplete = true;
                            points += goal._pointVal;
                        }
                        if (goal._type == "C")
                        {
                            goal._numTillDone += 1;
                            points += goal._pointVal;
                        }
                       if (goal._type == "N")
                        {
                            points -= goal._pointVal;
                        }
                         if (goal._type == "E")
                        {
                            points += goal._pointVal;
                        }
                        else
                        {

                        }
                    }
                }
                Console.WriteLine($"Well done! You've earned {points} points! ");
                startGoals = true;
            }

            if (choice == 6)
            {
                Console.WriteLine("Well done for working on your goals!");
                startGoals = false;
                
            }
             else
            {
               Console.WriteLine("\nPlease make a valid selection from the list. \n");
            startGoals = true;
             }

        }
    }
}
