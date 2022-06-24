using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRollApp
{
    internal class DieRollTest
    {
        static public void Main(string[] args)
        {
            int[] DieArray = Roll(10);
            for (int i = 0; i < DieArray.Length; i++)
            {
                Console.WriteLine( DieArray[i]);   
            }
            Console.ReadKey();
            

        }

        static int[] Roll(int n)
        {
            int[] Occurance = { 0, 0, 0, 0, 0, 0 };
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int num = rnd.Next(1,7);
                Occurance[num - 1] += 1;
                
            }
            return Occurance;
           

        }
    }
}
