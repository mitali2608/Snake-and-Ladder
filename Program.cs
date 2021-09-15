using System;
using System.Collections.Generic;
using System.Threading;
namespace snake_ladder
{
    class Program
    {



 public static int Main(String[] args)
   {

            BoardGame b = new BoardGame(); 
            Players player1 = new Players();
            Players player2 = new Players();

            Console.WriteLine("Snakes and Ladder");

            Console.WriteLine(" Enter Player1 name");
            player1.name = Console.ReadLine();
            Console.WriteLine(" Enter Player2 name");
            player2.name = Console.ReadLine();

            int score;
            while (true)
            {
              
                player1.PreviousPlace = player1.CurrentPlace;
                score = player1.DiceRoll();   

                player1.CurrentPlace = b.nextposition(score, player1.PreviousPlace);
                if (player1.CurrentPlace > 100)
                   player1.CurrentPlace = player1.PreviousPlace;
                Console.WriteLine(" Player1 : "+player1.name);
                Console.WriteLine("Previous Position :\t" + player1.PreviousPlace);
                Console.WriteLine(  "\nDice score     :\t"+score  );
                Console.WriteLine("\nCurrent Position :\t" + player1.CurrentPlace);
                Console.WriteLine("***************************************************");

                if (player1.CurrentPlace == 100)
                {
                    Console.WriteLine(" Player1 won the Game :"+player1.name );
                    break;
                }

                
                player2.PreviousPlace = player2.CurrentPlace;
                score = player2.DiceRoll();   

                player2.CurrentPlace = b.nextposition(score, player2.PreviousPlace);
                if (player2.CurrentPlace > 100)
                    player2.CurrentPlace = player1.PreviousPlace;
                Console.WriteLine(" Player2 : "+player2.name);
                Console.WriteLine("Previous Place :\t" + player2.PreviousPlace);
                Console.WriteLine("\nDice score     :\t" + score);
                Console.WriteLine("\nCurrent Place :\t" + player2.CurrentPlace);

                if (player2.CurrentPlace == 100)
                {
                    Console.WriteLine(" Player2 won the Game :"+player2.name);
                    break;
                }

            }
            Thread.Sleep(2000);
            return 1;
        }


    }

    }

