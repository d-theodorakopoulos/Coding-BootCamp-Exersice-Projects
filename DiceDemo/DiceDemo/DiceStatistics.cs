using System.Collections.Generic;

namespace DiceDemo
{
    public class DiceStatistics
    {
        private readonly List<int> _thrownNumbers;
        public int ListLength { get { return _thrownNumbers.Count; } }

        public DiceStatistics (int diceMaxValue)
        {
            _thrownNumbers = new List<int>();
            initList(diceMaxValue);
        } 

        private void initList(int diceMaxValue)
        {
            for (int i = 0; i < diceMaxValue; i++)
                _thrownNumbers.Add(0);
        }

        public void ExtendList(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                _thrownNumbers.Add(0);
            }
        }

        public void IncrenentTimesOfDrop(int DroppedNumber)
        {
            _thrownNumbers[DroppedNumber-1]++;
        }

        public string ShowDiceStatistics()
        {
            string results = "--Dice Statistics--\n";
            for (int i = 0; i < _thrownNumbers.Count; i++)
                results +=i+1 + "|"+new string('*',_thrownNumbers[i]) + _thrownNumbers[i] + "\n";

            return results;
        }
    }
}
