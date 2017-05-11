using System;
using System.Collections.Generic;

namespace KremalaGameApp
{
    public class Word
    {
        public List<char> GuessWord { get; private set; }
        public int FindedLetters { get; private set; }

        public bool WordRevealed
        {
            get
            {
                if (FindedLetters == GuessWord.Count)
                    return true;

                return false;
            }
        }

        public Word (string word)
        {
            FindedLetters = 0;

            if (String.IsNullOrWhiteSpace(word))
                throw new Exception("Wrong Word!");

            for (int i = 0; i < word.Length; i++)
            {
                GuessWord.Add(word[i]);
            }
        }

    }
}
