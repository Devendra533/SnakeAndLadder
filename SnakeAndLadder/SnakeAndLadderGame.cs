using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadderGame
    {
        public void PlayGame() 
        {
            int position = 0;
            Random number = new Random();
            Console.WriteLine( "your position Is At :" + position);
            int check = number.Next(1, 7);
            Console.WriteLine( "You Get :" + check);
            position += check;
            Console.WriteLine("Your Position Is At :" + position);

        }

       
    }
}
