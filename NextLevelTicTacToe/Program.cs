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

            // example move number for isValidMove function
            int move = 1;

            // use callClass var to access the makeBoard function + validate Move
            callClass.makeBoard(input);

            callClass.isValidMove(move);


        }
    }

    class MakeBoard
    {
        public string makeBoard(char[] input)
        {
            char[] line1 = { ' ', '|', ' ', '|', ' ' };
            string line2 = "-+-+-";
            int boardSize = 5;
            int k = 0;

            for (int i = 0; i < boardSize; i++)
            {
                if (i % 2 == 0)
                    for (int j = 0; j < line1.Length; j++)
                    {
                        Console.Write(line1[j]);
                        if (j % 2 == 0)
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

        public bool isValidMove(int move)
        {
            bool result = true;

            Console.WriteLine("insert move index number between 1 and 9, inclusive.");

            move = Convert.ToInt32(Console.ReadLine());

            if (move >= 1 && move <= 9)
            {
                Console.WriteLine("valid");
                return result;
            }
            else
            {
                result = false;
                Console.WriteLine("invalid move");
                return result;
            }
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


