using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartiniGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            int n;

            while(true)
            {
                try
                {
                    Console.Write("Please enter an integer greater than 0 to print a martini glass: ");
                    num = Console.ReadLine();
                    n = Int32.Parse(num);

                    if(n>0)
                        break;
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Try again - you didn't enter an integer");
                    Console.WriteLine();
                }
            }

            
            Program prog =  new Program();
            prog.printMartiniGlass(n);
            Console.ReadLine();
        }

        private void printMartiniGlass(int num)
        {

            int numOfZeroes = (num * 2) - 1; 
            int numOfEquals = numOfZeroes; 
            int numOfSpaces = 0;

            for (int a = 0; a < num; a++)
            {
                for (int b = 0; b < numOfSpaces; b++)
                {
                    Console.Write(" ");
                }

                for (int c = 0; c < numOfZeroes; c++)
                {
                    Console.Write("0");
                }

                numOfSpaces++;
                numOfZeroes = numOfZeroes - 2; Console.WriteLine();
            }

            numOfSpaces--;
            for (int x = 0; x < num; x++)
            {
                for (int y = 0; y < numOfSpaces; y++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("|");
            }

            for (int z = 0; z < numOfEquals; z++)
            {
                Console.Write("=");
            }

            Console.ReadLine();
        }

    }
}
