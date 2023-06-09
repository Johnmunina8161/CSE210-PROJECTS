/*

                                        +-----------------------------------+
                                        |       Mindfulness App             |
                                        +-----------------------------------+
                                        |        - Menu                     |       
                                        +-----------------------------------+                        
                                        |   + startMenu()                   |
                                        |   + breathingActivity()           |
                                        |   + reflectionActivity()          |
                                        |   + listingActivity()             |        
                                        |                                   |   
                                        |                                   | 
                                        +-----------------------------------+
                                        |       Class Menu:                 |
                                        +-----------------------------------+
                                        |  - activities: list of Activity   |
                                        +-----------------------------------+  
                                        |       Class Activity:             |   
                                        +-----------------------------------+
                                        |  - name: str                      |
                                        |  - description: str               |
                                        |  - duration: int                  |
                                        |                                   | 
                                        |  + start(): None                  |   
                                        |  + end(): None                    |   
                                        +-----------------------------------+
                                                           ^
                                                           |
                                                           |
                  +----------------------------------------+-----------------------------------+
                  |                                        |                                   |   
                  |                                        |                                   |    
+-----------------------------+      +----------------------------------+       +-----------------------------+      
| Class BreathingActivity     |      |   Class ReflectionActivity       |       | Class ListingActivity       | 
|       (Activity):           |      |          (Activity):             |       |        (Activity):          |                                
+-----------------------------+      +----------------------------------+       +-----------------------------+
|                             |      | - starting_message()             |       | - starting_message()        |    
| - starting_message()        |      | - prompt_duration: str           |       | - prompt_duration: str      |    
| - prompt_dration: str       |      | - description_activity()         |       | - description_activity: str | 
| - description activity():   |      | - questions: list of str         |       | - items: list of str        | 
|                             |      |                                  |       |                             |  
| - Finishing_message         |      | - Fnishing message               |       | + Finishing message():      | 
| + displayAnimation(): None  |      | + displayAnimation(): None       |       | + displayAnimation(): None  |                                             
+-----------------------------+      +----------------------------------+       +-----------------------------+








*/ /*

List<string>AnimationStrings = new List<string>();
AnimationStrings.Add(" |");
AnimationStrings.Add(" /");
AnimationStrings.Add(" -");
AnimationStrings.Add("\\ ");
AnimationStrings.Add(" |");
AnimationStrings.Add(" /");
AnimationStrings.Add(" \\");

//foreach (string s in AnimationStrings ) 
//{
//    Console.Write(s);
//    Thread.Sleep(1000);
//}   Console.Write("\b \b");

DateTime startTime = DateTime.Now;
DateTime endTime = startTime.AddSeconds(10);

int i = 0;

while (DateTime.Now > endTime)
{
    string s = AnimationStrings[i];
    Console.Write(s);
    Thread.Sleep(1000);
    Console.Write("\b \b");

    i++;

    if (i >= AnimationStrings.Count)
    {
        i = 0;
    }
}
Console.WriteLine("Done");
*/


