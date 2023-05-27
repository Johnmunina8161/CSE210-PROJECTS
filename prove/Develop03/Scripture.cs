class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            // Split the scripture text into individual words
            string[] wordArray = text.Split(' ');

            // Create Word objects for each word in the scripture text
            foreach (string word in wordArray)
            {
                _words.Add(new Word(word));
            }
        }

        public void Display()
        {
            Console.WriteLine($"{_reference.ToString()}:");
            foreach (Word word in _words)
            {
                Console.Write(word.ToString() + " ");
            }
            Console.WriteLine();
        }

        public void HideRandomWord()
        {
            Random random = new Random();
            int index = random.Next(0, _words.Count);

            // Hide the word if it's not already hidden
            if (!_words[index].IsHidden)
            {
                _words[index].Hide();
            }
        }

        public bool AllWordsHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden)
                    return false;
            }
            return true;
        }
    }