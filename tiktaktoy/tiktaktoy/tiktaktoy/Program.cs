using System;
public class HelloWorld
{ 

    static char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1;
    static int choice;
    static int flag = 0; //game continus 
    static int step = 0; //
    public static void Main(string[] args)

    {

        do //at list 1 time run hunna lai do ko used hunx
        {
            Console.Clear();
            Console.WriteLine("player1: x," +
                " Player2: O");
            Console.WriteLine("\n");
            if (player == 2) // player value change condition 
            {
                Console.WriteLine("Player 2 Chance");
            }
            else
            {
                Console.WriteLine("Player 1 Chance");
            }
            Console.WriteLine("\n");
            Board(); //this is calling Function which is help to create a box
            choice = int.Parse(Console.ReadLine());// its is help to convert string to integer

            if (arr[choice] != 'X' && arr[choice] != 'O')
            {
                if (player % 2 == 0) //
                {
                    arr[choice] = 'O';
                    player = 1; //if player 1 then put O
                    step ++;
                }
                else
                {
                    arr[choice] = 'X';
                    player = 2; //if player 2 then put X
                    step++;
                }
            }
            else
            {
                Console.WriteLine("Sorry the row{O} is already marked with {1}", choice, arr[choice]);
                Console.WriteLine("\n");
                Console.WriteLine("Please wait a 2 second board is loading..."); //program lai 2 second hold garx
                Thread.Sleep(2000); //milisecond
            }
            flag = CheckWin(); //another function which is checked Won or Draw

            

        } while (flag != 1 && flag != -1);
        Console.Clear();
        Board();
        if (flag == 1)
        {
            if (player == 2)
                Console.WriteLine("Player 1 has won the game");
            else

                Console.WriteLine("Player 2 has won the game"); //check the condition which player is won the game


                else
            {
                Console.WriteLine("Game is draw");
            }
        }



    }
    private static void Board() //create a box
    {
        Console.WriteLine("    |    |    ");
        Console.WriteLine("  {O} | {1}  |  {2}", arr[1], arr[2], arr[3]);
        Console.WriteLine("____|____|____");
        Console.WriteLine("  {O} {1}  | {2}", arr[4], arr[5], arr[6]);
        Console.WriteLine("____|____|____|");
        Console.WriteLine("  {O} |  {1}");

    }
   public static    CheckWin()
    {
        if (arr[1] == arr[2] && arr[2] == arr[3])
        {
            return 1;
        }
        else if (arr[4] == arr[5] && arr[5] == arr[6])

        {
            return 1;
        }
        else if (arr[7] == arr[8] && arr[8] == arr[9])
        {
            return 1;
        }
        else if (arr[1] == arr[4] && arr[4] == arr[7])
        {
            return 1;
        }
        else if (arr[2] == arr[5] && arr[5] == arr[8])
        {
            return 1;

        }
        else if (arr[3] == arr[6] && arr[6] == arr[9])
        {
            return 1;
        }
        else if (arr[1] == arr[5] && arr[5] == arr[9])
        {
            return 1;

        }
        else if (arr[3] == arr[5] && arr[5] == arr[7])
        {
            return 1;
        }


    }