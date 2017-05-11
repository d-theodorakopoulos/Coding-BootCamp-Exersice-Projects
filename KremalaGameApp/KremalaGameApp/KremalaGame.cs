using System;
using System.Collections.Generic;

namespace KremalaGameApp
{
    public class Player
    {
        public string Name { get; private set; }

        public Player (string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                Name = name;
        }
    }

    public class KremalaGame
    {
        private List<char> _selectedWord;
        public List<char> HiddenWord { get; private set; }
        public List<Player> Players { get; private set; }
        public int NumberOfTries { get; private set; }

        public KremalaGame (string selectedWord, List<Player> players)
        {
            Players = new List<Player>();
            NumberOfTries = 5;

            if (string.IsNullOrWhiteSpace(selectedWord) && players != null && players.Count > 0)
            {
                _selectedWord.AddRange(selectedWord);
                HiddenWord.AddRange(new string('*', selectedWord.Length));
                Players = players;
            }
            else
                throw new Exception("Wrong Arguments!");
        }


        public bool CheckLetter (char letter)
        {


            if (!_selectedWord.Contains(letter))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < _selectedWord.Count; i++)
                {
                    if (_selectedWord[i] == letter)
                        HiddenWord[i] = letter;
                }
                return true;
            }

        }


    }
}
