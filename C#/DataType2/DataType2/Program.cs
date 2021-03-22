using System;

namespace DataType2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int? items = 3;
            if (items.HasValue) { total cost = items.Value * price}

            int? nullableScore = null;
            int score = nullableScore ?? -9999;
            int score1 = nullableScore.GetValueOrDefault(-1);
            int score2 = nullableScore.GetValueOrDefault()
        }
    }
}
