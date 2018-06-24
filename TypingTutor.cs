
//Miguel Pastor

using System;
using System.IO;

class TypingTutor
{

    public void Main()
    {
        typingtutor();
    }

    public static void typingtutor()
    {
        string namefile = Console.ReadLine();

        string path = @"c:\typo\" + namefile;

        if (!File.Exists(namefile))
        {
            Console.WriteLine("File not found!");

            StreamWriter write = File.CreateText(namefile + ".dat");
            write.Write("asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg" +
            "asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg" +
            "asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg asdfg");

            write.Close();
        }
        else
        {
            try
            {
                StreamReader read = new StreamReader(path);
                
                Console.Write(read.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                read.Close();

                char input;

                do
                {
                    input = Convert.ToChar(Console.ReadLine());
                    if (input != 'a')
                    {
                        if (input != 's')
                        {
                            if (input != 'd')
                            {
                                if (input != 'f')
                                {
                                    if (input != 'g')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                    }
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                }
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            }
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }
                while (input != ' ');
            }
            catch (PathTooLongException a)
            {
                throw a;
            }
            catch (IOException b)
            {
                throw b;
            }
            catch (Exception c)
            {
                throw c;
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