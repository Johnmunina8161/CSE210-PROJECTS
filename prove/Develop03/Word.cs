class Word
    {
        private string _word;
        private bool _hidden;

        public Word(string word)
        {
            _word = word;
            _hidden = false;
        }

        public bool IsHidden
        {
            get { return _hidden; }
        }

        public void Hide()
        {
            _hidden = true;
        }

        public override string ToString()
        {
            if (_hidden)
                return "___";
            else
                return _word;
        }
    }