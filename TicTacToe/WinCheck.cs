using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class WinCheck 
    {
        public static bool inputCheck(string input)
        {
            int playerInput;
            if (!Int32.TryParse(input, out int value))
            {
                return false;
            }
            else
            {
                playerInput = Convert.ToInt32(input);
            }
            if (playerInput < 0 || playerInput > 9)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static bool Winner(Board board)
        {
            //loops through the board rows, columns, and diagonals to check for a win

            //horizontal
            for (int x = 0; x < 3; x++)
            {
                for(int y = 1; y < 4; y++)
                {
                    if (y > 2)
                    {
                        return true;
                    }
                    else if (board.TicBoard[x, y] == " ")
                    {
                        break;
                    }
                    
                    else if (board.TicBoard[x, y - 1] == board.TicBoard[x, y])
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int y = 0; y < 3; y++)
            {
                for (int x = 1; x < 4; x++)
                {
                    if (x > 2)
                    {
                        return true;
                    }
                    else if (board.TicBoard[x, y] == " ")
                    {
                        break;
                    }
                    else if (board.TicBoard[x - 1, y] == board.TicBoard[x, y])
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int z = 1; z < 3; z++)
                {
                    if (board.TicBoard[z, i] == " ")
                    {
                        break;
                    }
                    else if (z > 2)
                    {
                        return true;
                    }
                    else if (board.TicBoard[z - 1, i] == board.TicBoard[i, z])
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 1; i < 4; i++)
            {
                if (i > 2)
                {
                    return true;
                }
                else if (board.TicBoard[i, i] == " ")
                {
                    break;
                }
                
                else if (board.TicBoard[i, i] == board.TicBoard[i-1, i-1])
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            for (int i = 2; i > 0 + 1; i--)
            {
                if (board.TicBoard[i, i] == " ")
                {
                    break;
                }
                else if (i > 2)
                {
                    return true;
                }
                else if (board.TicBoard[i, i] == board.TicBoard[i - 1, i - 1])
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            return false;
        }

        public static bool Tie(Board board)
        {
            for(int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (board.TicBoard[i, z] != " ")
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
