using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLevelTicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of the MakeBoard class
            var callClass = new MakeBoard();

            char[] input = { 'x','o','o','x', 'x', 'o', 'o', 'x', 'x' };

            // use callClass var to access the importBoard function

            callClass.makeBoard(input);
        }
    }

    class MakeBoard
    {
        public string makeBoard(char[] input)
        {
            char[] line1 = { ' ', '|', ' ', '|', ' '};
            string line2 = "-+-+-";
            int boardSize = 5;
            int k = 0;

            for (int i = 0; i < boardSize; i++)
            {
                if (i % 2 == 0)
                    for (int j = 0; j < line1.Length; j++)
                    {
                        Console.Write(line1[j]);
                        if (j % 2 ==  0)
                        {
                                Console.Write(input[k]);
                                k++;
                                if (k == input.Length)
                                {
                                break;
                                }
                        }
                    }
                else
                {
                    Console.Write(line2);
                }
                Console.WriteLine();
            }
            return "data";
        } 
    }
}

/*
          
*/


// accepts 9 comma separated characters/strings
// data will be either '' 'x' 'o'

// the indexes of the array
// 0 1 2
// 3 4 5
// 6 7 8


