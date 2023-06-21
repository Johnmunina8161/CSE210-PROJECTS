using System;
using System.Collections.Generic;

namespace gamification 
{
        
    // Base class for all goals, This class will be the base class for all other goals in the system.
    public abstract class Goal
    {
        public string _Description ; //field stores the description of the goal.
        public bool _IsCompleted ; // field stores whether the goal has been completed.
        public int _Score ; //  field stores the score of the goal.

        public Goal(string description) // constructor initializes the goal with the given description
        {
            _Description = description;
            _IsCompleted = false;
            _Score = 0;
        }

        public abstract void Complete(); // abstract method that must be implemented by all subclasses of Goal. This method will be used to complete the goal.
    }
}
