using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {

        public string[,] TicBoard { get; set; } = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };

        public void ChangeBoard(Board board, int selection, Players player)
        {
            while (true)
            {
                switch (selection)
                {
                    //move this logic to another method but keep the player.Player line
                    //you have to make the check before the switch is even run.
                    case 1:
                        if (board.TicBoard[2, 0] != "X" && board.TicBoard[2, 0] != "O")
                        {
                            board.TicBoard[2, 0] = player.Player;
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken");
                        }
                        break;
                    case 2:
                        if (board.TicBoard[2, 1] != "X" && board.TicBoard[2, 1] != "O")
                        {
                            board.TicBoard[2, 1] = player.Player;
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken");
                        }
                        break;
                    case 3:
                        if (board.TicBoard[2, 2] != "X" && board.TicBoard[2, 2] != "O")
                        {
                            board.TicBoard[2, 2] = player.Player;
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken");
                        }
                        break;
                    case 4:
                        if (board.TicBoard[1, 0] != "X" && board.TicBoard[1, 0] != "O")
                        {
                            board.TicBoard[1, 0] = player.Player;
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken");
                        }
                        break;
                    case 5:
                        if (board.TicBoard[1, 1] != "X" && board.TicBoard[1, 1] != "O")
                        {
                            board.TicBoard[1, 1] = player.Player;
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken");
                        }
                        break;
                    case 6:
                        if (board.TicBoard[1, 2] != "X" && board.TicBoard[1, 2] != "O")
                        {
                            board.TicBoard[1, 2] = player.Player;
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken");
                        }
                        break;
                    case 7:
                        if (board.TicBoard[0, 0] != "X" && board.TicBoard[0, 0] != "O")
                        {
                            board.TicBoard[0, 0] = player.Player;
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken");
                        }
                        break;
                    case 8:
                        if (board.TicBoard[0, 1] != "X" && board.TicBoard[0, 1] != "O")
                        {
                            board.TicBoard[0, 1] = player.Player;
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken");
                        }
                        break;
                    case 9:
                        if (board.TicBoard[0, 2] != "X" && board.TicBoard[0, 2] != "O")
                        {
                            board.TicBoard[0, 2] = player.Player;
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken");
                        }
                        break;
                    default:
                        break;
                }
                break;
            }
        }

        public Board()
        {
        }
        
        
    }
}
