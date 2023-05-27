using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Store the scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("John", 3, 16, "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life."),
            new Scripture("Proverbs", 3, 5, 6, "Trust in the LORD with all your heart, and do not lean on your own understanding. In all your ways acknowledge him, and he will make straight your paths.")
            // Add more scriptures if desired
        };

        foreach (var scripture in scriptures)
        {
            HideWordsInScripture(scripture);
        }
    }

    static void HideWordsInScripture(Scripture scripture)
    {
        List<Word> words = GetWords(scripture.Text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.Reference}:");
            Console.WriteLine();

            foreach (Word word in words)
            {
                if (word.Hidden)
                    Console.Write(word.Words + " ");
                else
                    Console.Write("______ ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            int count = CountHiddenWords(words);

            if (count == 0)
                break;

            HideRandomWord(words);
        }
    }

    static List<Word> GetWords(string text)
    {
        string[] wordArray = text.Split(' ');

        List<Word> words = new List<Word>();

        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }

        return words;
    }

    static int CountHiddenWords(List<Word> words)
    {
        int count = 0;

        foreach (Word word in words)
        {
            if (word.Hidden)
                count++;
        }

        return count;
    }

    static void HideRandomWord(List<Word> words)
    {
        Random random = new Random();

        while (true)
        {
            int randomIndex = random.Next(0, words.Count);
            Word randomWord = words[randomIndex];

            if (!randomWord.Hidden)
            {
                randomWord.Hidden = true;
                break;
            }
        }
    }
}

class Scripture
{
    public string Reference { get; }
    public string Text { get; }

    public Scripture(string book, int chapter, int verseStart, string text)
    {
        Reference = $"{book} {chapter}:{verseStart}";
        Text = text;
    }

    public Scripture(string book, int chapter, int verseStart, int verseEnd, string text)
    {
        Reference = $"{book} {chapter}:{verseStart}-{verseEnd}";
        Text = text;
    }
}

class Word
{
    public string Words;
    public bool Hidden;

    public Word(string word)
    {
        Words = word;
        Hidden = false;
    }    
}