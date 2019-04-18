using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Players
    {
        private string _name;

        public string Player { get; set; }
        
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value is string || value.Length > 20)
                {
                    _name = value;
                }
                else
                {
                    _name = "Player";
                }
            }
        }

        public Players(string name, string player)
        {
            Name = name;
            Player = player;
        }



    }
}
