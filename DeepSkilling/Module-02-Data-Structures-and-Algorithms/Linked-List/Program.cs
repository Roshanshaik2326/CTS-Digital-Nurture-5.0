using System;

// Node
public class Coach
{
    public string CoachName;
    public Coach? Next;   // Nullable because the last node points to null

    public Coach(string coachName)
    {
        CoachName = coachName;
        Next = null;
    }
}

// Linked List
public class Train
{
    private Coach? head;   // Nullable because the list is initially empty

    public void AddCoach(string coachName)
    {
        Coach newCoach = new Coach(coachName);

        if (head == null)
        {
            head = newCoach;
            return;
        }

        Coach temp = head;

        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = newCoach;
    }

    public void DisplayTrain()
    {
        Coach? temp = head;

        Console.WriteLine("Train Coaches:");

        while (temp != null)
        {
            Console.Write(temp.CoachName);

            if (temp.Next != null)
            {
                Console.Write(" -> ");
            }

            temp = temp.Next;
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Train train = new Train();

        train.AddCoach("Engine");
        train.AddCoach("Coach A");
        train.AddCoach("Coach B");
        train.AddCoach("Coach C");

        train.DisplayTrain();
    }
}