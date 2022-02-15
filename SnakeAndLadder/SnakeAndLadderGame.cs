﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadderGame
    {
        public const int NO_PLAY = 1;
        public const int LADDER = 2;
        public const int SNAKE = 3;
       
        public int TOTAL_DICE_ROLL = 0;
        public int position = 0;
        Random number = new Random();
        public void PlayGame() 
        {
           
            Console.WriteLine( "your position Is At :" + position);
            int check1 = number.Next(1, 7);
            TOTAL_DICE_ROLL++;
            int check2 = number.Next(1, 4);
            switch (check2)
            {
                case 1:
                    Console.WriteLine("Your Position Is Same");
                    Console.WriteLine("Your Position IS :" + position);
                    break;
                case 2:
                    Console.WriteLine("Congrats It's A Ladder");
                    if (position > 100)
                    {
                        position -= check1;
                        Console.WriteLine("Your Position Is :" + position);
                    }
                    else
                      
                        Console.WriteLine("Your Position Is :" + position);
                    break;
                case 3:
                    position -= check1;
                    Console.WriteLine("Sorry It's A Snake");
                    if (position < 0) 
                    { 
                        position = 0;
                       Console.WriteLine("You Return TO :" + position);
                    }
                    else
                        Console.WriteLine("You Return TO :" + position);
                    break;
            }
          
           

        }
        public void TillPosition100() 
        {
            while (position < 100)
             PlayGame();
            Console.WriteLine(" YOU WIN ");
            Console.WriteLine("Total Dice Roll : " + TOTAL_DICE_ROLL);
        }

    }
}
