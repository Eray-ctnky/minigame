// See https://aka.ms/new-console-template for more information
string inputPlayer, inputCPU;
int randomInt;
int scorePlayer = 0;
int scoreCPU = 0;
bool playAgain = true;

while (playAgain)
{

     scorePlayer = 0;
     scoreCPU = 0;


    while (scorePlayer < 3 && scoreCPU < 3)
    {
Console.Write("choose between ROCK,PAPER and SCISSORS: ");
        inputPlayer = Console.ReadLine();

        Random rnd = new Random();

        randomInt = rnd.Next(1, 4);

        switch (randomInt)
        {
            case 1:
                inputCPU = "ROCK";
                Console.WriteLine("computer choose ROCK");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("DRAW!!\n\n");
                }
                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("PLAYERS WIN!!\n\n");
                    scorePlayer++;
                }
                else if (inputPlayer == "SCISSORS")
                {
                    Console.WriteLine("CPU WINS!!\n\n");
                    scoreCPU++;
                }

                break;
            case 2:
                inputCPU = "PAPER";
                Console.WriteLine("computer choose PAPER");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("CPU WINS!!\n\n");
                    scoreCPU++;
                }
                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("DRAW!!\n\n");
                }
                else if (inputPlayer == "SCISSORS")
                {
                    Console.WriteLine("PLAYER WIN!!\n\n");
                    scorePlayer++;
                }
                break;
            case 3:
                inputCPU = "SCISSORS";
                Console.WriteLine("coumpter choose SCISSORS");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("PLAYER WINS!!\n\n");
                    scorePlayer++;
                }
                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("CPU WINS!!\n\n");
                    scoreCPU++;
                }
                else if (inputPlayer == "SCISSORS")
                {
                    Console.WriteLine("DRAW!!\n\n");
                }
                break;
            default:
                Console.WriteLine("Invalid entry!");

                break;
        }
        Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);

        if (scorePlayer == 3)
        {
            Console.WriteLine("Player WON");
        
        }
        else if (scoreCPU == 3)
        {
            Console.WriteLine("CPU WON");
        }
        
    }
        Console.WriteLine("Do you want to play again ?(y/n)");
        string loop = Console.ReadLine();
        if (loop == "y")
        {
            playAgain = true;
        }
        else if (loop == "n")
    {
        playAgain = false;
    }
    }

    








