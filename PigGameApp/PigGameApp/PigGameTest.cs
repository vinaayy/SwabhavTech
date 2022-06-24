using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGameApp
{
    internal class PigGameTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play PIG Game!");

            

            int i = 1;
            int score = 0;
    
            Random rnd = new Random();
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Turn " + i);
                int Flag = 0;
                int turnscore = 0;
                do
                {
                    Console.WriteLine("Roll or Hold ? r/h ");
                    string rh = Console.ReadLine();
                    if (rh == "r")
                    {
                        Flag = 0;
                        int Die = rnd.Next(1, 7);
                        Console.WriteLine("Die: " + Die);

                        if (Die == 1)
                        {
                            turnscore = 0;
                            Console.WriteLine("Turn Over .No score ");
                            break;
                        }
                        else
                        {
                            
                            turnscore = turnscore + Die;
                            score = turnscore + score;
                            if (score >= 20)
                            {
                                break;
                            }
                        
                        }
                    }
                    else
                    {
                        Flag = 1;
                        
                    }
                } while (Flag == 0);
                i += 1;
                Console.WriteLine("Turnscore : " + turnscore);
                Console.WriteLine("Final score: " + score);
            } while (score <20);
            
            
            Console.WriteLine("You finished in " + i + " Turns");

            
        }

    }
}
