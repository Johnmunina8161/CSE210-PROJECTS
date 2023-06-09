using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected int duration;
    protected string name;
    protected string description;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        DisplayStartingMessage();
        Pause(2);
        PerformActivity();
        Pause(2);
        DisplayEndingMessage();
        Pause(2);
    }

    protected virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Activity: {name}");
        Console.WriteLine(description);
        Console.Write("Enter duration (in seconds): ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
    }

    protected virtual void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {name} activity.");
        Console.WriteLine($"Duration: {duration} seconds");
    }

    protected virtual void PerformActivity()
    {
        // Implemented in derived classes
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        int counter = 0;
        for (int i = 0; i < seconds; i++)
        {
            switch (counter % 4)
            {
                case 0:
                    Console.Write("/");
                    break;
                case 1:
                    Console.Write("-");
                    break;
                case 2:
                    Console.Write("\\");
                    break;
                case 3:
                    Console.Write("|");
                    break;
            }
            counter++;
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }
}