using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loteria.Classes
{
    public class Score
    {
        [AutoIncrement, PrimaryKey] 
        public int Id { get; set; }
        public DateTime LotteryDate { get; set; }
        public string WinningNumbers { get; set; }
        public int NumberOfWins { get; set; }

        public Score(int id, DateTime lotteryDate, string winningNumbers, int numberOfWins)
        {
            Id = id;
            LotteryDate = lotteryDate;
            WinningNumbers = winningNumbers;
            NumberOfWins = numberOfWins;
        }

        public Score(DateTime lotteryDate, string winningNumbers, int numberOfWins)
        {
            LotteryDate = lotteryDate;
            WinningNumbers = winningNumbers;
            NumberOfWins = numberOfWins;
        }

        public Score() 
        {

        }
    }
}
