using System;

namespace ScriptureHider

{
    

    class Scripture
    {
        private Reference reference;
        private List<Word> words;

        public Scripture(string book, int chapter, int verse, string text)
        {
            reference = new Reference(book, chapter, verse);
            words = new List<Word>();

            string[] splitText = text.Split(' ');
            foreach (string word in splitText)
            {
                words.Add(new Word(word));
            }
        }

        public void Display()
        {
            Console.WriteLine($"{reference}:");
            foreach (Word word in words)
            {
                Console.Write(word.IsHidden ? "***** " : word.Text + " ");
            }
        }

        public void HideRandomWord()
        {
            List<Word> visibleWords = GetVisibleWords();
                if (visibleWords.Count == 0)
                    return;

                Random random = new Random();
                int randomIndex = random.Next(visibleWords.Count);
                visibleWords[randomIndex].Hide();
        }

        private List<Word> GetVisibleWords()
        {
            List<Word> visibleWords = new List<Word>();
            foreach (Word word in words)
            {
                if (!word.IsHidden)
                    visibleWords.Add(word);
            }
                return visibleWords;
        }
    }
}