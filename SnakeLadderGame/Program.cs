using System;

namespace SnakeLadderGAME
{
    class Program
    {
        //uc1 - Single Player at Start Position
        //uc2 - Player Rolles dies to get Number Between 1-6;
        //uc3 - Player Checks for Option from "No Play", "Move Ahead", or "Move back"
        //uc4 - Repeat till Player Reached Winning Position i.e 100
        //uc5 - Insure player player should be in same place if he wins i.e 100
        //uc6 - Number of times dies Rolled to win game and Position after every dies Role 
        //uc7  - Play this game with 2 Player and find who wins

        static void Main(string[] args)
        {
            int player1_Position = 0; //uc1
            int player2_Position = 0;

            int diceCount1 = 0;
            int diceCount2 = 0;

            Random random = new Random();
            while (player1_Position != 100 || player2_Position != 100)
            {
                Console.WriteLine("Player 1 turn");


                int DieNumber1 = random.Next(1, 7);//uc2
                Console.WriteLine("Player rolled the Die ....");
                Console.WriteLine("Dies turns to, " + DieNumber1);
                int Option1 = random.Next(1, 4);

                switch (Option1)//uc3      
                {
                    case 1:

                        Console.WriteLine("you are at No Play option");
                        Console.WriteLine("Player1 Current Position: " + player1_Position);
                        break;

                    case 2:
                        Console.WriteLine("you Get Move Ahead option");
                        Console.WriteLine("Great! You get to Move Ahead, By " + DieNumber1);
                        player1_Position = player1_Position + DieNumber1;
                        Console.WriteLine("Player1 Current Position: " + player1_Position);

                        break;
                    case 3:
                        Console.WriteLine("But you get Move back option");
                        Console.WriteLine("Oops! you Need to Move Back, By " + DieNumber1);
                        player1_Position = player1_Position - DieNumber1;
                        Console.WriteLine("Player1 Current Position: " + player1_Position);
                        break;
                }
                if (player1_Position < 0)//uc4
                {
                    Console.WriteLine("Please Restart");
                    player1_Position = 0;
                    continue;
                }
                if (player1_Position == 100)// uc7
                {
                    Console.WriteLine("Player One wins");
                    break;
                }
                else if (Option1 == 3 && player1_Position > 100)
                {
                    Console.WriteLine("Player1 Current Position" + (player1_Position - DieNumber1));
                    continue;
                }
                else if (player1_Position > 100)//uc5
                {
                    player1_Position += player1_Position;
                    continue;
                }
                diceCount1 = diceCount1 + 1; //uc6



                Console.WriteLine("Player 2 turn");
                int DieNumber2 = random.Next(1, 7);
                Console.WriteLine("Player rolled the Die ....");
                Console.WriteLine("Dies turns to, " + DieNumber2);
                int Option2 = random.Next(1, 4);

                switch (Option2)
                {
                    case 1:

                        Console.WriteLine("you are at No Play option");
                        Console.WriteLine("Player2 Current Position: " + player2_Position);
                        break;

                    case 2:
                        Console.WriteLine("you Get Move Ahead option");
                        Console.WriteLine("Great! You get to Move Ahead, By " + DieNumber2);
                        player2_Position = player2_Position + DieNumber2;
                        Console.WriteLine("Player2 Current Position: " + player2_Position);
                        break;
                    case 3:
                        Console.WriteLine("But you get Move back option");
                        Console.WriteLine("Oops! you Need to Move Back, By " + DieNumber2);
                        player2_Position = player2_Position - DieNumber2;
                        Console.WriteLine("Player2 Current Position: " + player2_Position);
                        break;
                }

                if (player2_Position < 0)
                {
                    Console.WriteLine("Please Restart");
                    player2_Position = 0;
                    continue;
                }

                if (player2_Position == 100)
                {
                    Console.WriteLine("Player Two wins");
                    break;
                }
                else if (Option2 == 3 && player2_Position > 100)
                {
                    Console.WriteLine("Player2 Current position : " + (player2_Position - DieNumber2));
                    continue;
                }
                else if (player2_Position > 100)
                {
                    player2_Position += player2_Position;
                    continue;
                }
                diceCount2 = diceCount2 + 1;


            }
            Console.WriteLine("player1 Dice count {0} : ", diceCount1);
            Console.WriteLine("player2 Dice count {0} : ", diceCount2);
        }
    }
}

