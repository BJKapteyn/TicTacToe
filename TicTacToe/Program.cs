using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{

    class Program
    {
        static void Main(string[] args)
        {
            void Game()
            {
                Console.WriteLine("Welcome to Tic Tac Toe by Beerad");
                string player1Name;
                string player2Name;
                Console.Write("Please enter player 1's name (X)");
                player1Name = Console.ReadLine();
                Console.Clear();
                Console.Write("Please enter player 2's name (O)");
                player2Name = Console.ReadLine();
                Console.Clear();
                Players[] players = new Players[2] { new Players(player1Name, "X"), new Players(player2Name, "O") };
                Players currentPlayer = players[0];
                Console.WriteLine("Directions- Use the number pad to choose where you mark as follows:" +
                              "\n-------------------" +
                              "\n|  7  |  8  |  9  |" +
                              "\n-------------------" +
                              "\n|  4  |  5  |  6  |" +
                              "\n-------------------" +
                              "\n|  1  |  2  |  3  |" +
                              "\n-------------------" +
                              "\nPress any key to continue");
                Console.ReadKey();
                Board board = new Board();
                while(true)
                {
                    Console.Clear();
                    int playerSelection;
                    Render.RenderBoard(board);
                    Console.Write($"{currentPlayer.Name} is up, make your selection 1 - 9 ");
                    

                    while (true)
                    {
                        string selection = Console.ReadLine();
                        if (WinCheck.inputCheck(selection))
                        {
                            playerSelection = Convert.ToInt32(selection);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a whole number 1 - 9 ");
                            continue;
                        }
                    }
                    //update board
                    board.ChangeBoard(board, playerSelection, currentPlayer);

                    if (WinCheck.Winner(board))
                    {
                        Console.Clear();
                        Render.RenderBoard(board);
                        Console.WriteLine($"{currentPlayer.Name} has won the game! Press any key to quit.");
                        Console.ReadKey();
                        return;
                    }
                    else if (WinCheck.Tie(board))
                    {
                        Console.WriteLine("That's a tie, yall need practice, booooo both of you. I'm otta here.");
                        Console.ReadKey();
                        return;
                    }

                    if(currentPlayer == players[0])
                    {
                        currentPlayer = players[1];
                    }
                    else
                    {
                        currentPlayer = players[0];
                    }
                    continue;
                }
            }
            Game();

        }
    }
}
