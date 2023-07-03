using System.IO;
using System;


namespace cardgame
{
    class Program
    {


        static void Main(string[] args)
        {

            bool restart = true;
            while (restart)
            {

                char[] charArray = new char[9];
                int[] colorArray = new int[9];
                // Variables R, b, g represent the numbers of colors in the random array to be generated. And the variable test is used to prevent generating extra letters.
                int r = 0, b = 0, g = 0, test = 0;


                Console.Write("Randomly generated array =  ");
                for (int d = 0; d < charArray.Length; d++)
                {
                    // generating random color
                    Random rndcolor = new Random();
                    int randomColor = rndcolor.Next(1, 4);
                    // 1 = red ,2 = blue, 3= green
                    if (randomColor == 1)
                    {
                        r++;
                        if (r <= 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            colorArray[d] = randomColor;
                        }
                        else
                        {
                            d = d - 1;
                            test++;
                        }
                    }
                    else if (randomColor == 2)
                    {
                        b++;
                        if (b <= 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            colorArray[d] = randomColor;
                        }
                        else
                        {
                            d = d - 1;
                            test++;
                        }
                    }
                    else if (randomColor == 3)
                    {
                        g++;
                        if (g <= 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            colorArray[d] = randomColor;
                        }
                        else
                        {
                            d = d - 1;
                            test++;

                        }


                    }
                    Random rnd = new Random();

                    if (test == 0)
                    {
                        char randomChar = (char)rnd.Next('A', 'E');
                        charArray[d] = randomChar;
                        Console.Write(charArray[d] + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        test = test - 1;
                    }


                }
                Console.WriteLine();
                int point = 0;
                for (int m = 0; m < 7; m++)
                {
                    //Checks that if all 3 letters are the same or not
                    if (charArray[m] == charArray[m + 1] && charArray[m] == charArray[m + 2])
                    {
                        if (colorArray[m] == colorArray[m + 1] && colorArray[m + 1] == colorArray[m + 2])
                        {
                            point = point + 33;
                            Color(colorArray[m]);
                            Console.Write(charArray[m] + " ");
                            Color(colorArray[m + 1]);
                            Console.Write(charArray[m + 1] + " ");
                            Color(colorArray[m + 2]);
                            Console.Write(charArray[m + 2] + " ");
                            Console.ResetColor();
                            Console.WriteLine("   33 points ");


                        }
                        else if (colorArray[m] != colorArray[m + 1] && colorArray[m] != colorArray[m + 2] && colorArray[m + 1] != colorArray[m + 2])
                        {
                            point = point + 28;
                            Color(colorArray[m]);
                            Console.Write(charArray[m] + " ");
                            Color(colorArray[m + 1]);
                            Console.Write(charArray[m + 1] + " ");
                            Color(colorArray[m + 2]);
                            Console.Write(charArray[m + 2] + " ");
                            Console.ResetColor();
                            Console.WriteLine("   28 points ");

                        }
                        else if (((colorArray[m] == colorArray[m + 1]) && colorArray[m] != colorArray[m + 2]) || ((colorArray[m + 1] == colorArray[m + 2]) && colorArray[m] != colorArray[m + 2]) || ((colorArray[m] == colorArray[m + 2]) && colorArray[m] != colorArray[m + 1]))
                        {
                            point = point + 22;
                            Color(colorArray[m]);
                            Console.Write(charArray[m] + " ");
                            Color(colorArray[m + 1]);
                            Console.Write(charArray[m + 1] + " ");
                            Color(colorArray[m + 2]);
                            Console.Write(charArray[m + 2] + " ");
                            Console.ResetColor();
                            Console.WriteLine("   22 points ");

                        }
                    }

                    // This code checks if the consecutive three slots show consecutive letters and permutations of those letters. (ABC BCA ACB etc.)
                    else if ((Convert.ToInt32(charArray[m]) + 1 == Convert.ToInt32(charArray[m + 1]) && Convert.ToInt32(charArray[m]) + 2 == Convert.ToInt32(charArray[m + 2])) ||
                             (Convert.ToInt32(charArray[m]) + 1 == Convert.ToInt32(charArray[m + 1]) && Convert.ToInt32(charArray[m]) - 1 == Convert.ToInt32(charArray[m + 2])) ||
                             (Convert.ToInt32(charArray[m]) - 2 == Convert.ToInt32(charArray[m + 1]) && Convert.ToInt32(charArray[m]) - 1 == Convert.ToInt32(charArray[m + 2])) ||
                             (Convert.ToInt32(charArray[m]) - 1 == Convert.ToInt32(charArray[m + 1]) && Convert.ToInt32(charArray[m]) - 2 == Convert.ToInt32(charArray[m + 2])) ||
                             (Convert.ToInt32(charArray[m]) - 1 == Convert.ToInt32(charArray[m + 1]) && Convert.ToInt32(charArray[m]) + 1 == Convert.ToInt32(charArray[m + 2])) ||
                             (Convert.ToInt32(charArray[m]) + 2 == Convert.ToInt32(charArray[m + 1]) && Convert.ToInt32(charArray[m]) + 1 == Convert.ToInt32(charArray[m + 2]))) 

                        {
                      
                        if (colorArray[m] == colorArray[m + 1] && colorArray[m + 1] == colorArray[m + 2])
                        {
                            point = point + 18;
                            Color(colorArray[m]);
                            Console.Write(charArray[m] + " ");
                            Color(colorArray[m + 1]);
                            Console.Write(charArray[m + 1] + " ");
                            Color(colorArray[m + 2]);
                            Console.Write(charArray[m + 2] + " ");
                            Console.ResetColor();
                            Console.WriteLine("   18 points ");

                        }
                        else if (colorArray[m] != colorArray[m + 1] && colorArray[m] != colorArray[m + 2] && colorArray[m + 1] != colorArray[m + 2])
                        {
                            point = point + 16;
                            Color(colorArray[m]);
                            Console.Write(charArray[m] + " ");
                            Color(colorArray[m + 1]);
                            Console.Write(charArray[m + 1] + " ");
                            Color(colorArray[m + 2]);
                            Console.Write(charArray[m + 2] + " ");
                            Console.ResetColor();
                            Console.WriteLine("   16 points ");

                        }
                        else if (((colorArray[m] == colorArray[m + 1]) && colorArray[m] != colorArray[m + 2]) || ((colorArray[m + 1] == colorArray[m + 2]) && colorArray[m] != colorArray[m + 2]) || ((colorArray[m] == colorArray[m + 2]) && colorArray[m] != colorArray[m + 1]))
                        {
                            point = point + 14;
                            Color(colorArray[m]);
                            Console.Write(charArray[m] + " ");
                            Color(colorArray[m + 1]);
                            Console.Write(charArray[m + 1] + " ");
                            Color(colorArray[m + 2]);
                            Console.Write(charArray[m + 2] + " ");
                            Console.ResetColor();
                            Console.WriteLine("   14 points ");

                        }


                    }

                    // This code checks if the consecutive three slots show the same color, but not all the same letter and not consecutive,
                    else if (colorArray[m] == colorArray[m + 1] && colorArray[m + 1] == colorArray[m + 2])
                    {
                        point = point + 12;
                        Color(colorArray[m]);
                        Console.Write(charArray[m] + " ");
                        Color(colorArray[m + 1]);
                        Console.Write(charArray[m + 1] + " ");
                        Color(colorArray[m + 2]);
                        Console.Write(charArray[m + 2] + " ");
                        Console.ResetColor();
                        Console.WriteLine("   12 points ");

                    }
                    // This code checks if the consecutive three slots show different colors.
                    else if (colorArray[m] != colorArray[m + 1] && colorArray[m] != colorArray[m + 2] && colorArray[m + 1] != colorArray[m + 2])
                    {
                        point = point + 10;
                        Color(colorArray[m]);
                        Console.Write(charArray[m] + " ");
                        Color(colorArray[m + 1]);
                        Console.Write(charArray[m + 1] + " ");
                        Color(colorArray[m + 2]);
                        Console.Write(charArray[m + 2] + " ");
                        Console.ResetColor();
                        Console.WriteLine("   10 points ");

                    }
                    else
                    {
                        Color(colorArray[m]);
                        Console.Write(charArray[m] + " ");
                        Color(colorArray[m + 1]);
                        Console.Write(charArray[m + 1] + " ");
                        Color(colorArray[m + 2]);
                        Console.Write(charArray[m + 2] + " ");
                        Console.ResetColor();
                        Console.WriteLine("   0 points  ");
                    }


                }
                Console.WriteLine("\nYou get {0} points !", point);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("\nPlease enter your name to save your score!");

                Console.Write("Your name : ");
                Console.ForegroundColor = ConsoleColor.Green;
                string player_name = Console.ReadLine();
                Console.ResetColor();

                StreamWriter string_writer = File.AppendText(@"d:\\HighScoreTable.txt");
                string_writer.WriteLine(player_name + ";" + point);
                string_writer.Close();

                int[] scores = new int[12];
                int[] sortedscores = new int[12]; // If you want to save not only the top 10 scores but also other scores, text_cleaner and rewriter can be deleted and saved up to required amount of scores.
                string[] names = new string[12];
                int i = 0, j = 0, k = 0;

                
              
                StreamReader strrdr = new StreamReader("HighScoreTable.txt");
                
                    string lines;

                    // Reading lines from the file 
                    // Until the end of the file is reached.
                    while (!((lines = strrdr.ReadLine()) == null))
                    {
                        // Splitting total line into score and names arrays
                        string[] scoretable = lines.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

                        // Converting string into integers
                        scores[i] = Convert.ToInt32(scoretable[1]);
                        sortedscores[i] = scores[i];
                        names[i] = scoretable[0];
                        i++;
                    }
                strrdr.Close();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHIGH SCORE LIST");
                Console.WriteLine("----------------------------------------");
                Console.ResetColor();



                StreamWriter text_cleaner = File.CreateText("HighScoreTable.txt");
                text_cleaner.Close();
                StreamWriter rewriter = File.AppendText("HighScoreTable.txt");

                int top10_counter = 0;
                while (j < i)
                {
                    if (top10_counter < 10)
                    {

                        int temp_int;
                        string temp_str;
                        for (k = j + 1; k < i; k++)
                        {
                            // Keeping score into descending order.
                            if (sortedscores[j] < sortedscores[k])
                            {
                                temp_int = sortedscores[j];
                                sortedscores[j] = sortedscores[k];
                                sortedscores[k] = temp_int;
                                temp_str = names[j];
                                names[j] = names[k];
                                names[k] = temp_str;
                            }

                        }

                        //Displaying highscore in descending order with names               
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(j + 1 + ".");
                        Console.ResetColor();
                        Console.Write(" " + names[j]+"-");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" " + sortedscores[j]);
                        Console.ResetColor();
                        
                        
                        rewriter.WriteLine(names[j] + ";" + sortedscores[j]);
                        
                        j++;
                        top10_counter++;
                    }
                    else
                    {
                        break;
                    }


                }
                rewriter.Close();
                Console.WriteLine();
                string restart_choice;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Do you want to play again?(");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Y");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("N");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(")");
                Console.ResetColor();
                Console.WriteLine();
                restart_choice = Console.ReadLine();
                if (restart_choice == "Y" || restart_choice == "y")
                {
                    restart = true;

                    Console.Clear();
                }
                else if (restart_choice == "N" || restart_choice == "n")
                {
                    restart = false;
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nYou made an invalid choice. By default, the program will be stopped.");
                    Console.ResetColor();
                    restart = false;
                    Console.ReadKey();
                }
            }


            }



        private static void Color(int randomColor)
        {
            if (randomColor == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;

            }
            else if (randomColor == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }
        }




    }
}
