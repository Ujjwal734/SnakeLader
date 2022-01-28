using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLader
{
    public class SnakeLadder
    {
        int playerposition = 0;
        int Start_Position = 0;
        int Current_Position = 0;
        int Winning_Position = 100;
        int Dice_Count = 0;
        public int DiceRoll()
        {
            Random random = new Random();
            return random.Next(1,7);
        }
        public void play()
        {
            {
                Console.WriteLine("Welcome to snake ladder Game");
                Random random = new Random();
                while (Current_Position != 100)
                {
                    Dice_Count++;
                    int Dice_No = random.Next(1, 7);
                    int Player_Choice = random.Next(1, 4);
                    Console.WriteLine("Player roll dice and dice no is :  " + "   " + Dice_No);

                    switch (Player_Choice)
                    {
                        case 1:
                            Console.WriteLine("Player is not playing ");
                            Current_Position += 0;
                            Console.WriteLine("Current position of player is :" + "  " + Current_Position);
                            break;
                        case 2:
                    Console.WriteLine("player is go for ladder");
                    Current_Position = Current_Position + Dice_No;
                    if (Current_Position > 100)
                    {
                        Console.WriteLine("current position of player go above 100 so we can not go for next position");
                        Current_Position -= Dice_No;
                    }
                    Console.WriteLine("Current position of player is :" + "  " + Current_Position);
                    break;
                case 3:
                    Console.WriteLine("Player go for Snake point ");
                    Current_Position = Current_Position - Dice_No;
                    if (Current_Position < 0)
                    {
                        Console.WriteLine("your position going below  0  ");
                        Current_Position = 0;
                        Console.WriteLine("Current position default set as 0 :" + "  " + Current_Position);
                    }
                    Console.WriteLine("Current position of player is :" + "  " + Current_Position);
                    break;
                    }
                 Console.WriteLine("player roll dice " + "  " + Dice_Count + "  " + "th time  till now");

                }
                Console.WriteLine("player roll dice " + "  " + Dice_Count + "  " + "time for winning");
            }
        }
    }
}
