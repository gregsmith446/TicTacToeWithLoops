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
            callClass.ticTac();
        }
    }

    class MakeBoard
    {
        public string ticTac()
        {
            string line1 = "x|x|x";
            string line2 = "-+-+-";

            for (int i = 0; i < 5; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write(line1 + "\n");
                }
                else
                {
                    Console.Write(line2 + "\n");
                }
            }

            return "yes, you have made a tic tac toe board";

        }
    }
}

/* 
Create the following function/method:
drawBoard()
 | |
-+-+-
 | |
-+-+-
 | |
*/

  