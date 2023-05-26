using System;

namespace ScriptureHider

{      
    class Word
    {
        public string Text;
        public bool IsHidden ;

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public void Hide()
        {
                IsHidden = true;
        }
    }
}