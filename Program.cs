using System;
using System.Security.Cryptography;
using System.Threading;

namespace SimonSays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring all the variables
            int miliseconds = 1000;
            int f = 2;
            int g = 0;
            int h = 0;
            int i = 0;
            int score = 0;
            bool gameOver = false;
            string off = "0";
            string randomColor;
            string[] randomColors = { "Green", "Blue", "Yellow", "Red" };
            string[] doneColors = new string[999999];
            Random random = new Random();
            

            //starting the game
            Console.WriteLine("This is a game of Simon Says.");
            Thread.Sleep(2000);
            Console.Clear();


            //counting down
            Console.Write("You're starting in: ");
            Console.Write("5 ");
            Thread.Sleep(1000);
            Console.Write("4 ");
            Thread.Sleep(1000);
            Console.Write("3 ");
            Thread.Sleep(1000);
            Console.Write("2 ");
            Thread.Sleep(1000);
            Console.Write("1 ");
            Thread.Sleep(1000);
            Console.Write("GO");
            Thread.Sleep(300);
            Console.Clear();


            //starting Simon Says
            while (!gameOver)
            {
                for (int a = 0; a < 1; a++)
                {
                    if (gameOver == true)
                    {
                        continue;
                    }

                    GetSimon(off, 1000);

                    //starting the color sequence and saving them into an array
                    for (int b = 0; b < 2; b++)
                    {
                        randomColor = randomColors[random.Next(0, 4)];
                        GetSimon(randomColor, miliseconds);
                        doneColors[h] = randomColor;
                        GetSimon(off, 500);

                        h++;
                    }
                    Console.WriteLine("That were the colors of this round!");

                    //checking if the user remembered the colors
                    for (int c = 0; c < 2; c++)
                    {
                        if (gameOver == true)
                        {
                            continue;
                        }

                        Console.Write("Enter color number " + (c + 1) + ", with a capital letter: ");
                        
                        //if the user forgot a color
                        if (Console.ReadLine() != doneColors[i])
                        {
                            Console.WriteLine();
                            Console.WriteLine("That wasn't right!");

                            gameOver = true;
                            continue;
                        }
                        i++;
                    }

                    //going to next round
                    if (!gameOver)
                    {
                        Console.WriteLine("Those colors were right!");
                        Console.WriteLine("Up to the next round!");


                        Thread.Sleep(2000);
                        Console.Clear();
                        score++;
                    }
                }
                

                //the next rounds
                if (!gameOver)
                {
                    while(!gameOver)
                    {
                        GetSimon(off, 1000);

                        //displaying all the previous colors
                        for (int d = 0; d < f; d++)
                        {
                            GetSimon(doneColors[d], miliseconds);
                            GetSimon(off, 500);
                        }

                        //displaying the new color and saving it into the array
                        randomColor = randomColors[random.Next(0, 4)];
                        GetSimon(randomColor, miliseconds);
                        doneColors[h] = randomColor;

                        //checking if the user remembered all the colors
                        for (int e = 0; e < (h + 1); e++)
                        {
                            if (gameOver == true)
                            {
                                continue;
                            }

                            Console.Write("Enter color number " + (e + 1) + ", with a capital letter: ");
                            
                            //if the user forgot a color
                            if (Console.ReadLine() != doneColors[g])
                            {
                                Console.WriteLine();
                                Console.WriteLine("That wasn't right!");

                                gameOver = true;
                                continue;
                            }
                            g++;
                        }

                        
                        //going to next round
                        if (!gameOver)
                        {
                            Console.WriteLine("Those colors were right!");
                            Console.WriteLine("Up to the next round!");

                            Thread.Sleep(2000);
                            Console.Clear();
                        }

                        h++;
                        f++;
                        g = 0;
                        score++;
                    }
                }
            }
            
           
            
            //if the user went Game Over
            if (gameOver)
            {
                Console.WriteLine("You are Game Over!");
                Console.WriteLine("You've got a score of " + score + "!");
            }

            

            //if the user broke the game
            else
            {
                Console.WriteLine("You broke the game");
            }
        }


        //making the Simon Says "buttons"
        static void GetSimon(string color, int miliseconds)
        {
            switch (color)
            {
                case "Blue":
                    Console.WriteLine("              * * * * *          ");

                    Console.Write("          ***");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***");

                    Console.Write("        **");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("      **");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("     **");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.WriteLine("    * * * * * * * * * * * * * * *");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("     **");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("      **");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("        **");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("          ***");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***");

                    Console.WriteLine("              * * * * *          ");

                    Console.ResetColor();
                    Thread.Sleep(miliseconds);
                    Console.Clear();
                    
                    break;

                

                case "Red":
                    Console.WriteLine("              * * * * *          ");

                    Console.Write("          ***");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***");

                    Console.Write("        **");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("      **");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("     **");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.WriteLine("    * * * * * * * * * * * * * * *");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("     **");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("      **");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("        **");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("          ***");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***");

                    Console.WriteLine("              * * * * *          ");

                    Console.ResetColor();
                    Thread.Sleep(miliseconds);
                    Console.Clear();

                    break;

                
                
                case "Green":
                    Console.WriteLine("              * * * * *          ");

                    Console.Write("          ***");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***");

                    Console.Write("        **");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("      **");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("     **");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.WriteLine("    * * * * * * * * * * * * * * *");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("     **");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("      **");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("        **");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("          ***");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***");

                    Console.WriteLine("              * * * * *          ");

                    Console.ResetColor();
                    Thread.Sleep(miliseconds);
                    Console.Clear();

                    break;

                
                
                case "Yellow":
                    Console.WriteLine("              * * * * *          ");

                    Console.Write("          ***");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***");

                    Console.Write("        **");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("      **");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("     **");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.WriteLine("    * * * * * * * * * * * * * * *");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("     **");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("      **");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("        **");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("          ***");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***");

                    Console.WriteLine("              * * * * *          ");

                    Console.ResetColor();
                    Thread.Sleep(miliseconds);
                    Console.Clear();

                    break;

                default:
                    Console.WriteLine("              * * * * *          ");

                    Console.Write("          ***");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***");

                    Console.Write("        **");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("      **");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("     **");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.WriteLine("    * * * * * * * * * * * * * * *");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("    *");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("0000000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*");

                    Console.Write("     **");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("00000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("      **");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("0000000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("        **");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("00000000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("**");

                    Console.Write("          ***");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("00000");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("***");

                    Console.WriteLine("              * * * * *          ");

                    Console.ResetColor();
                    Thread.Sleep(miliseconds);
                    Console.Clear();

                    break;
            }
        }
    }
}