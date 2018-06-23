
//Miguel Pastor

using System;
using System.Collections.Generic;
using System.IO;

class TypingTutor
{

    public static void typingtutor()
    {
        if (!File.Exists("execise0101.dat"))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            try
            {
                StreamWriter asdf = File.CreateText("execise0101.dat");
                asdf.Write("asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg" +
                "asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg" +
                "asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg");

                FileStream asd = File.OpenRead("execise0101.dat");

                Console.Write(asd);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                string input = Console.ReadLine();
                if (input != "asdfg")
                {
                    if(input.StartsWith("a"))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }

                    if(input.EndsWith("g"))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

class exercise
{
    string[] array = new string[5];

    string n = "";

    public void GetLine(string n)
    {
         
    }

    public string AmountofLines()
    {
        string name = "Exercise0101.dat";
        int lines = 5;

        Convert.ToString(lines);

        return name + lines;
    }
}