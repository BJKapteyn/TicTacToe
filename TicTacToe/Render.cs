using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Render
    {
        public static void RenderBoard(Board board)
        {
            Console.WriteLine("\n                   -------------------" +
                             $"\n                   |  {board.TicBoard[0, 0]}  |  {board.TicBoard[0, 1]}  |  {board.TicBoard[0, 2]}  |" +
                              "\n                   -------------------" +
                             $"\n                   |  {board.TicBoard[1, 0]}  |  {board.TicBoard[1, 1]}  |  {board.TicBoard[1, 2]}  |" +
                              "\n                   -------------------" +
                             $"\n                   |  {board.TicBoard[2, 0]}  |  {board.TicBoard[2, 1]}  |  {board.TicBoard[2, 2]}  |" +
                              "\n                   -------------------");

        }
    }
}
