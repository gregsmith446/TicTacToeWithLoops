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

            // use the callClass variable to access on the ticTac function
            // callClass.ticTac();

            string[] input = { "x", "o", "x", "o", "x", "x", " ", "x", "x" };

            // use callClass var to access the importBoard function
            callClass.importBoard(input);
        }
    }

    class MakeBoard
    {
        public string importBoard(string[] input)
        {
            char[] line1 = { '|', '|', ' '};
            string line2 = "-+-+-";

            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    foreach (char item in line1)
                    {
                        for (int k = 0; k < input.Length; k++)
                        {
                            Console.Write(input[k] + item);
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(line2 + "\n");
                }
            }
            return "data";
        }
    }
}

        // accepts 9 comma separated characters/strings
        // data will be either '' 'x' 'o'

        // the indexes of the array
        // 0 1 2
        // 3 4 5
        // 6 7 8
  