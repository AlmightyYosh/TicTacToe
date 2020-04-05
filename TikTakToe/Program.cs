using System;

namespace TikTakToe
{
    class Program
    {
        //Display 
        static string[,] fieldValues = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        
        //Game Function 
        static bool win;
        //static byte numberOfTry = 0;
        static String symbol = "X";
        static String symbol2 = "O";
        static bool resetGame = true;
        static int newPlayer;
        static int player = 1;
        static bool introCheck = false;
        static bool turn = false;
        static int counter = 1;

        static void Main(string[] args)
        {
            Intro();
 
            //while introcheck is ture
            while (introCheck)
            {
                StartGame();

         
                while(!win && counter != 9)
                {
                    //returns the win veriable or counter veraible
                    GameFunctions();

                }

                if(turn == true && counter != 9)
                {
                    Console.WriteLine("*********************congrats player 1*********************");
                    //need to change this break
                    Console.WriteLine("press any key to restart");
                    string pre = Console.ReadLine();
                    if (pre != "")
                    {
                        win = false;
                        
                    }
                    Console.Clear();
                    ResetGame();


                }
                else if (turn == false && counter != 9)
                {

                    Console.WriteLine("*********************congrats player 2*********************");
                    //need to change this break
                    Console.WriteLine("press any key to restart");
                    string pre = Console.ReadLine();
                    if (pre != "")
                    {
                        win = false;
                        
                    }
                    Console.Clear();
                    ResetGame();


                }
                //Draw check if counter is = to 9
                else if (counter == 9)
                {
                    Console.WriteLine("*********************Draw*********************");
                    //need to change this break
                    Console.WriteLine("press any key to restart");
                    string pre = Console.ReadLine();
                    if (pre != "")
                    {
                        win = false;

                    }

                    Console.Clear();
                    ResetGame();

                }
              

            }


        }

        //win condition
        public static bool CheckWinCombination()
        {
            // Provjera kombinacije
            //prvi red
            if (fieldValues[0, 0] == "X" && fieldValues[0, 1] == "X" && fieldValues[0, 2] == "X" || fieldValues[0, 0] == "O" && fieldValues[0, 1] == "O" && fieldValues[0, 2] == "O")
            {
                win = true;
                return win;
            }
            //drugi red
            else if (fieldValues[1, 0] == "X" && fieldValues[1, 1] == "X" && fieldValues[1, 2] == "X" || fieldValues[1, 0] == "O" && fieldValues[1, 1] == "O" && fieldValues[1, 2] == "O")
            {
                win = true;
                return win;
            }
            //treći red
            else if (fieldValues[2, 0] == "X" && fieldValues[2, 1] == "X" && fieldValues[2, 2] == "X" || fieldValues[2, 0] == "O" && fieldValues[2, 1] == "O" && fieldValues[2, 2] == "O")
            {
                win = true;
                return win;
            }
            //prvi stupac
            else if (fieldValues[0, 0] == "X" && fieldValues[1, 0] == "X" && fieldValues[2, 0] == "X" || fieldValues[0, 0] == "O" && fieldValues[1, 0] == "O" && fieldValues[2, 0] == "O")
            {
                win = true;
                return win;
            }
            //drugi stupac
            else if (fieldValues[0, 1] == "X" && fieldValues[1, 1] == "X" && fieldValues[2, 1] == "X" || fieldValues[0, 1] == "O" && fieldValues[1, 1] == "O" && fieldValues[2, 1] == "O")
            {
                win = true;
                return win;
            }
            //treći stupac
            else if (fieldValues[0, 2] == "X" && fieldValues[1, 2] == "X" && fieldValues[2, 2] == "X" || fieldValues[0, 2] == "O" && fieldValues[1, 2] == "O" && fieldValues[2, 2] == "O")
            {
                win = true;
                return win;
            }
            //dijagonalno \
            else if (fieldValues[0, 0] == "X" && fieldValues[1, 1] == "X" && fieldValues[2, 2] == "X" || fieldValues[0, 0] == "O" && fieldValues[1, 1] == "O" && fieldValues[2, 2] == "O")
            {
                win = true;
                return win;
            }
            //dijagonalno /
            else if (fieldValues[0, 2] == "X" && fieldValues[1, 1] == "X" && fieldValues[2, 0] == "X" || fieldValues[0, 2] == "O" && fieldValues[1, 1] == "O" && fieldValues[2, 0] == "O")
            {
                win = true;
                return win;
            }
            else
            {
                return win;
            }
        }

   

        static void GameFunctions()
        {
        
            //user input
            string playerInput = Console.ReadLine();

            //check all inputs for user 1 
            while (playerInput != "" && turn == false && CheckWinCombination() == false && counter != 9)
            {
                if (playerInput == "1" )
                {
                   
                    //checks will the feild does not already have a symbol as a value
                    if (fieldValues[0, 0] != symbol2 && fieldValues[0, 0] != symbol)
                    {
                        //array location = symbol
                        fieldValues[0, 0] = symbol;
                        Console.Clear();

                        //breaks loop
                        turn = true;
                        Console.WriteLine("player 2 turn");

                        //refress screen
                        StartGame();

                        //user input = null a;so breaks loop
                        playerInput = null;

                        //can also break loop
                        counter++;

                    }
                    else
                    {
                        //else user tries to pick a feild that already has a symbol in it.
                        Console.WriteLine("please choose a number thats not already taken");
                    }
                    
           
                    break;
                    

                }
                if (playerInput == "2")
                {
                    

                    if (fieldValues[0, 1] != symbol2 && fieldValues[0, 1] != symbol)
                    {
                        fieldValues[0, 1] = symbol;
                        Console.Clear();
                        
                        turn = true;
                        Console.WriteLine("player 2 turn");
                        StartGame();
                        playerInput = null;
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;

                }
                if (playerInput == "3")
                {
                    

                    if (fieldValues[0, 2] != symbol2 && fieldValues[0, 2] != symbol)
                    {
                        fieldValues[0, 2] = symbol;
                        Console.Clear();
                        
                        turn = true;
                        Console.WriteLine("player 2 turn");
                        StartGame();
                        playerInput = null;
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;

                }
                if (playerInput == "4")
                {
                    

                    if (fieldValues[1, 0] != symbol2 && fieldValues[1, 0] != symbol)
                    {
                        fieldValues[1, 0] = symbol;
                        Console.Clear();
                        
                        turn = true;
                        Console.WriteLine("player 2 turn");
                        StartGame();
                        playerInput = null;
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;

                }
                if (playerInput == "5")
                {
                    

                    if (fieldValues[1, 1] != symbol2 && fieldValues[1, 1] != symbol)
                    {
                        fieldValues[1, 1] = symbol;
                        Console.Clear();
                        
                        turn = true;
                        Console.WriteLine("player 2 turn");
                        StartGame();
                        playerInput = null;
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;

                }
                if (playerInput == "6")
                {
                    

                    if (fieldValues[1, 2] != symbol2 && fieldValues[1, 2] != symbol)
                    {
                        fieldValues[1, 2] = symbol;
                        Console.Clear();
                        
                        turn = true;
                        Console.WriteLine("player 2 turn");
                        StartGame();
                        playerInput = null;
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;

                }
                if (playerInput == "7")
                {
                    

                    if (fieldValues[2, 0] != symbol2 && fieldValues[2, 0] != symbol)
                    {
                        fieldValues[2, 0] = symbol;
                        Console.Clear();
                        
                        turn = true;
                        Console.WriteLine("player 2 turn");
                        StartGame();
                        playerInput = null;
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;

                }
                if (playerInput == "8")
                {
                    

                    if (fieldValues[2, 1] != symbol2 && fieldValues[2, 1] != symbol)
                    {
                        fieldValues[2, 1] = symbol;
                        Console.Clear();
                        
                        turn = true;
                        Console.WriteLine("player 2 turn");
                        StartGame();
                        playerInput = null;
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;

                }
                if (playerInput == "9")
                {
                    
                    if (fieldValues[2, 2] != symbol2 && fieldValues[2, 2] != symbol)
                    {
                        fieldValues[2, 2] = symbol;
                        Console.Clear();
                        
                        turn = true;
                        Console.WriteLine("player 2 turn");
                        StartGame();
                        playerInput = null;
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;

                }
                else
                {
                    Console.WriteLine("please write a useable number");
                    playerInput = Console.ReadLine();

                }
            }

            //check all inputs for user 2
            while (playerInput != "" && turn == true && CheckWinCombination() == false && counter != 9)
            {
                if (playerInput == "1")
                {
                    
                   if (fieldValues[0, 0] != symbol && fieldValues[0, 0] != symbol2)
                    {
                        
                        fieldValues[0, 0] = symbol2;
                        Console.Clear();

                        turn = false;
                        Console.WriteLine("player 1 turn");
                        StartGame();
                        playerInput = null;
                        counter++;
                    }
                   else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }
                    
                    


                    break;


                }
                if (playerInput == "2")
                {
                    
                    if (fieldValues[0, 1] != symbol && fieldValues[0, 1] != symbol2)
                    {

                        fieldValues[0, 1] = symbol2;
                        Console.Clear();

                        turn = false;
                        Console.WriteLine("player 1 turn");
                        StartGame();
                        playerInput = null;
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }


                    break;

                }
                if (playerInput == "3")
                {
                    

                    if (fieldValues[0, 2] != symbol && fieldValues[0, 2] != symbol2)
                    {

                        fieldValues[0, 2] = symbol2;
                        Console.Clear();

                        turn = false;
                        Console.WriteLine("player 1 turn");
                        StartGame();
                        playerInput = null;
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }


                    break;

                }
                if (playerInput == "4")
                {

                    if (fieldValues[1, 0] != symbol && fieldValues[1, 0] != symbol2)
                    {

                        fieldValues[1, 0] = symbol2;
                        Console.Clear();

                        turn = false;
                        Console.WriteLine("player 1 turn");
                        StartGame();
                        playerInput = null;
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;

                }
                if (playerInput == "5")
                {
                  

                    if (fieldValues[1, 1] != symbol && fieldValues[1, 1] != symbol2)
                    {

                        fieldValues[1, 1] = symbol2;
                        Console.Clear();

                        turn = false;
                        Console.WriteLine("player 1 turn");
                        StartGame();
                        playerInput = null;
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;

                }
                if (playerInput == "6")
                {
                 
                    if (fieldValues[1, 2] != symbol && fieldValues[1, 2] != symbol2)
                    {

                        fieldValues[1, 2] = symbol2;
                        Console.Clear();

                        turn = false;
                        Console.WriteLine("player 1 turn");
                        StartGame();
                        playerInput = null;
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;

                }
                if (playerInput == "7")
                {
                    

                    if (fieldValues[2, 0] != symbol && fieldValues[2, 0] != symbol2)
                    {
                        fieldValues[2, 0] = symbol2;
                        Console.Clear();
                        
                        turn = false;
                        Console.WriteLine("player 1 turn");
                        StartGame();
                        playerInput = null;
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;
                }
                if (playerInput == "8")
                {
                    

                    if (fieldValues[2, 1] != symbol && fieldValues[2, 1] != symbol2)
                    {
                        fieldValues[2, 1] = symbol2;
                        Console.Clear();
                        
                        turn = false;
                        Console.WriteLine("player 1 turn");
                        StartGame();
                        playerInput = null;
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }

                    break;

                }
                if (playerInput == "9")
                {
                    

                    if (fieldValues[2, 2] != symbol && fieldValues[2, 2] != symbol2)
                    {
                        fieldValues[2, 2] = symbol2;
                        Console.Clear();
                        
                        turn = false;
                        Console.WriteLine("player 1 turn");
                        StartGame();
                        counter++;

                    }
                    else
                    {
                        Console.WriteLine("please choose a number thats not already taken");
                    }


                    break;

                }
                else
                {
                    Console.WriteLine("please write a useable number");
                    playerInput = Console.ReadLine();

                }

            }

        }

        //feild data at the start
        static void StartGame()
        {
            Field
                (
                fieldValues[0, 0], fieldValues[0, 1], fieldValues[0, 2],
                fieldValues[1, 0], fieldValues[1, 1], fieldValues[1, 2],
                fieldValues[2, 0], fieldValues[2, 1], fieldValues[2, 2]
                );
        }

        //intro only played once 
        public static void Intro()
        {
            if (!introCheck)
            {

                Console.WriteLine("welcome to my TicTacToe game");
                Console.WriteLine("rules are simple:");
                Console.WriteLine("1* This is a two player game");
                Console.WriteLine("2* Plays exactly like TicTacToe");
                Console.WriteLine("3* Input the number into the console where you would want to go");
                Console.WriteLine("Press enter to start the game");

                string pressedEntered = Console.ReadLine();

                if (pressedEntered != null)
                {
                    introCheck = true;
                    Console.Clear();

                }
            }
          
            

        }

        //resets all veriables to default
        static void ResetGame()
        {
         
            //resets array to default value
            var rowLength = fieldValues.GetLength(0);
            var colLength = fieldValues.GetLength(1);
            int newValuesForFields = 1;
            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < colLength; col++)
                {
                    fieldValues[row, col] = newValuesForFields.ToString();
                    newValuesForFields++;
                }
                win = false;
                newPlayer = 0;
                player = 0;
                counter = 1;
              
            }
            
        }

        //display feild 
        public static void Field(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9)
        {
            Console.WriteLine("Tic Tac Toe");
            Console.WriteLine("");
            // prvi red
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", p1, p2, p3);
            Console.WriteLine("_____|_____|_____");

            // drugi red
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", p4, p5, p6);
            Console.WriteLine("_____|_____|_____");

            // treći red
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", p7, p8, p9);
            Console.WriteLine("     |     |     ");
            Console.WriteLine("");
        }
    }
}
