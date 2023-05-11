using System;
using System.Collections.Generic;
using System.IO;

/*class Program
{
    static void Main(string[] args)
    {
     person p1 = new person();
        p1._firstName = "John";
        p1._lastName = "Munina";
        p1._age = 34;

        person p2 = new person();
        p2._firstName="Jacky";
        p2._lastName ="Ngalula";
        p2._age = 20;

        List<person> people = new List<person>();
        people.Add(p1);
        people.Add(p2);
        
        foreach (person p in people)
        
        {
            Console.WriteLine(p1._firstName);
        }

        SaveToFile(people); 
       //---------------------------------------------// 

 */
/*
        List<person> = newPeople = ReadFromFile();
        
        foreach (person p in newPeopl)
        {
            
          Console.WriteLine(p._age_lastName); 

    }
    public static void SaveToFile(List<person> people)
    {

        Console.WriteLine("Saving to file...");
        
        string filename="people.txt";
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (person p in people)
            {
               outputFile.WriteLine(p._firstName);
            }

    // or   outputFile.WriteLine(${p._firstName}~~{p._lastName}~~{p._age});
               
        }
    }
    public static List<Peron>ReadFromFile()
    {
       Console.WriteLine("Reading this from file...");
       List<person> people = new List<person>();
       string filename = "people.txt";

       string [] lines = System.IO.File.ReadAllLines(filename);

       foreach (string line in lines)
       {
          // Console.WriteLine();
          // line will have somthing like this : "Mary~~Smith~~25"
          string [] parts = line.Split("~~");

          // parts [0] = Mary
          // parts [0] = Smith
          // parts [0] = 25

          
          person  newPerson = new person();
          newPerson._firstName = parts [0]; 
          newPerson._lastName = parts [1]; 
          newPerson._age = int.Parse(parts[2]);
          
          people.Add(newPerson);
          
        }

       return people;
    }
}  
   */ 

    