
//Miguel Pastor

using System;
using System.IO;

class TypingTutor
{

    public static void Main()
    {
        typingtutor();
    }

    public static void typingtutor()
    {
        string namefile = Console.ReadLine();

        Console.WriteLine("Write Directory Path from Local Disc C/ : ");
        string path = Console.ReadLine();
        String directory = @"c:/" + path + namefile;

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
                StreamReader read = new StreamReader(directory);
                
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
        string name = input;
        int lines = 5;

        Convert.ToString(lines);

        return name + lines;
    }
}

class ScreenKeyBoard
{
    static void Display()
    {
        string[] alphab = new string { "Q", "W", "E", "R", "T", "Y", "U", "I",
            "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L",  "Z",
            "X", "C", "V", "B", "N", "M"};

        int r = 0;

        Console.SetCursorPosition(0, -50);

        for (int l = 9; l > 0; l--)
        {
            for (int i = 9; i > 0; i--)
            {
                for (int j = 9; j > 0; j--)
                {
                    for (int k = 9; k > 0; k--)
                    {
                        Console.Write("___");
                        if (k == 0)
                        {
                            Console.WriteLine();
                        }
                    }

                    Console.Write("| ");
                    Mark();
                    Console.Write(alphab[r]);
                    Unmark();
                    Console.Write(" |");
                    r++;

                    if (j == 0)
                    {
                        Console.WriteLine();
                    }
                }
                Console.Write("___");
                if (i == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }

    static void Mark()
    {
        if(ConsoleKey.Q = true)
        {
            Console.ForegroundColor = green;
        }
        else if(ConsoleKey.W = true)
        {
            Console.ForegroundColor = green;
        }
        else if(ConsoleKey.E = true)
        {
            Console.ForegroundColor = green;
        }
        else if(ConsoleKey.R = true)
        {
            Console.ForegroundColor = green;
        }
        else if(ConsoleKey.T = true)
        {
            Console.ForegroundColor = green;
        }
        else if(ConsoleKey.Y = true)
        {
            Console.ForegroundColor = green;
        }
        else if(ConsoleKey.U = true)
        {
            Console.ForegroundColor = green;
        }
        else if(ConsoleKey.I = true)
        {
            Console.ForegroundColor = green;
        }
        else if(ConsoleKey.O = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.P = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.A = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.S = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.D = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.F = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.G = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.H = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.J = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.K = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.L = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.Z = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.X = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.C = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.V = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.B = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.N = true)
        {
            Console.ForegroundColor = green;
        }
        else if (ConsoleKey.M = true)
        {
            Console.ForegroundColor = green;
        }
    }

    void Unmark()
    {
        Console.ResetColor;
    }
}