using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParameterApp
{
    internal class ParameterTest
    {
        static public void Main()
        {
            int score = 100;
            Console.WriteLine("Hash Code: " +score.GetHashCode());
            UpdateScoreToZero(score);
            Console.WriteLine("After calling: "+score);

            int[] scores = { 10, 20, 30 };
            Console.WriteLine("Hash Code: " +scores.GetHashCode());
            UpdateAllScoresToZero(scores);
            foreach(int s in scores)
            {
                Console.WriteLine(s);
            }

        }
        static void UpdateScoreToZero(int pscore)
        {
            pscore = 0;
        }

        static void UpdateAllScoresToZero(int[] pscores)
        {
            for (int i =0;i<pscores.Length; i++)
            {
                pscores[i] = 0;
            }
        }

    }
}
