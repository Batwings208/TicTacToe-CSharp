using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;



namespace TicTacToe
{

    class MainProgram
    {

        public static void Main(string[] args)
        {
            char player = 'X'; // Making the player
            char[,] board = new char[3, 3]; // Constructing a 3 by 3 board in characters

            Intialize(board); // calling method

            Output(board); // prints out the board

            int runtime = 0; // total amount of plays made

            bool RUN = true; 

            while (RUN == true)
            {
                Console.Write("Enter Row    : ");
                int UserRow = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Column : ");
                int UserCol = Convert.ToInt32(Console.ReadLine());
                UserRow -= 1; //To adjust for board's formatting so row 1 from user would be row 0
                UserCol -= 1; 


                board[UserRow, UserCol] = player; // apply player to user chosen row/column

                if (player == 'X')
                {
                    player = 'O';
                }
                else
                {
                    player = 'X';
                }

                Output(board); // calling method
                runtime += 1;
                

                // Changing user and checking all possible combinations of victory
                char usernum = 'X';
                boardchecker(board, usernum, 0, 0, 1, 0, 2, 0);
                boardchecker(board, usernum, 0, 1, 1, 1, 2, 1);
                boardchecker(board, usernum, 0, 2, 1, 2, 2, 2);
                boardchecker(board, usernum, 0, 0, 0, 1, 0, 2);
                boardchecker(board, usernum, 1, 0, 1, 1, 1, 2);
                boardchecker(board, usernum, 2, 0, 2, 1, 2, 2);
                boardchecker(board, usernum, 0, 0, 1, 1, 2, 2);
                boardchecker(board, usernum, 0, 2, 1, 1, 2, 0);
                char user = 'O';
                boardchecker(board, user, 0, 0, 1, 0, 2, 0);
                boardchecker(board, user, 0, 1, 1, 1, 2, 1);
                boardchecker(board, user, 0, 2, 1, 2, 2, 2);
                boardchecker(board, user, 0, 0, 0, 1, 0, 2);
                boardchecker(board, user, 1, 0, 1, 1, 1, 2);
                boardchecker(board, user, 2, 0, 2, 1, 2, 2);
                boardchecker(board, user, 0, 0, 1, 1, 2, 2);
                boardchecker(board, user, 0, 2, 1, 1, 2, 0);
            }



        }

        static void boardchecker(char[,] board, char playerhand, int b1, int b2, int b3, int b4, int b5, int b6)
        {
            // Possible combination of victory
            if (board[b1, b2] == playerhand && board[b3, b4] == playerhand && board[b5, b6] == playerhand)
            {

                Console.WriteLine($"Player {playerhand} is the winner!");
                Environment.Exit(0); // Quit entire program
            }
            else { }

        }

        static void Intialize(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    board[row, column] = ' ';
                }
            }
        }
        static void Output(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                Console.Write("| ");
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(board[row, column]);
                    Console.Write(" | ");
                }
                Console.WriteLine("");
            }
        }
    }
}
