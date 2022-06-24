using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessApp
{
    internal class NumberGessTest
    {
        static public void Main(string[] args)
        {
            int option = 1;
            while (option == 1)
            {
                Random rnd = new Random();
                int num = rnd.Next(1, 100);


                Console.WriteLine("Random no.: " + num);
                int count = 0;
                int Flag = 0;
                

                while (Flag == 0)
                {
                    Console.WriteLine("Guess the no. ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n < num)
                    {
                        Console.WriteLine("Sorry, Too Low ");
                        count += 1;
                    }
                    else if (n > num)
                    {
                        Console.WriteLine("Sorry, Too High");
                        count += 1;
                    }
                    else if (n == num)
                    {
                        count += 1;
                        Flag = 1;
                    }
                }
                Console.WriteLine("No. of tries: " + count);
                Console.WriteLine("Do you want to play again? y/n");
                string yn = Console.ReadLine();
                if (yn == "y")
                {
                    option = 1;
                }
                else
                {
                    option = 0;
                }

            }
        }
        
       
    }
}
