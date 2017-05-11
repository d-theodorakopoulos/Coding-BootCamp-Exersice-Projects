using System;

namespace DiceDemo
{
    public class Dice
    {
        private int _maxValue;
        private static Random generator = new Random();
        public static DiceStatistics diceStatistics { get; private set; }

        public int MaxValue {
            get { return _maxValue; }
            set
            {
                if (value >= 4)
                {
                    diceStatistics.ExtendList(value - _maxValue);
                    _maxValue = value;
                }
                else
                    throw new Exception("Dice Max value too short!");
            }
        }
        public int NextRoll { get { return RollDice(); } }

        public Dice ()
        {
            _maxValue = 6;
            if (diceStatistics == null)
            {
                diceStatistics = new DiceStatistics(6);
            }

            if (diceStatistics.ListLength < 6)
            {
                diceStatistics.ExtendList(6 - diceStatistics.ListLength);
            }
        }

        public Dice (int diceMaxValue)
        {
            if (diceMaxValue >= 4)
            {
                _maxValue = diceMaxValue;
            }
            else
                throw new Exception("Dice Max Value too short!");

            if (diceStatistics == null)
            {
                diceStatistics = new DiceStatistics(diceMaxValue);
            }

            if (diceStatistics.ListLength < diceMaxValue)
            {
                diceStatistics.ExtendList(diceMaxValue - diceStatistics.ListLength);
            }
        }

        private int RollDice()
        {
            return generator.Next(1, MaxValue + 1);
        }

        public int RollHigh()
        {
            return generator.Next(MaxValue - 2, MaxValue + 1);
        }
    }
}
