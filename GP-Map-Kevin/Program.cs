using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_Map_Kevin
{
    internal class Program
    {
        static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
    };
        static int mapX = map.GetLength(0);
        static int mapY = map.GetLength(1);


        static void Main(string[] args)
        {

            DisplayMap();
            Console.ReadKey();
            Console.Clear();
            DisplayMap(2);
            Console.ReadKey();
            Console.Clear();
            







        }
        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees
        static void DisplayMap()
        {
            
            Console.WriteLine("^ = mountain");
            Console.WriteLine("` = grass");
            Console.WriteLine("~ = water");
            Console.WriteLine("* = trees");
            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    Console.SetCursorPosition(j + 8, i + 5);
                    if (map[i,j] == '^')
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                    }
                    else if (map[i, j] == '`')
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (map[i, j] == '~')
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (map[i, j] == '*')
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                    }
                    Console.Write(map[i, j]);
                    Console.BackgroundColor = ConsoleColor.Black;

                    if (i == 0)
                    {
                        Console.SetCursorPosition(j + 8, i + 4);
                        Console.Write("-");
                        if (j == 0)
                        {
                            Console.SetCursorPosition(j + 7, i + 4);
                            Console.Write("+");
                        }
                        if (j == mapY - 1)
                        {
                            Console.SetCursorPosition(j + 9, i + 4);
                            Console.Write("+");
                        }
                    }
                    if (j == 0)
                    {
                        Console.SetCursorPosition(j + 7, i + 5);
                        Console.Write("|");
                    }
                    if (i == mapX - 1)
                    {
                        Console.SetCursorPosition(j + 8, i + 6);
                        Console.Write("-");
                        if (j == mapY - 1)
                        {
                            Console.SetCursorPosition(j + 9, i + 6);
                            Console.Write("+");
                        }
                        if (j == 0)
                        {
                            Console.SetCursorPosition(j + 7, i + 6);
                            Console.Write("+");
                        }
                    }
                    if (j == mapY - 1)
                    {
                        Console.SetCursorPosition(j + 9, i + 5);
                        Console.Write("|");
                    }

                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            
        }
        static void DisplayMap(int scale)
        {
            Console.WriteLine("^ = mountain");
            Console.WriteLine("` = grass");
            Console.WriteLine("~ = water");
            Console.WriteLine("* = trees");
            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    for (int k = 0; k < scale; k++)
                    {
                        for (int l = 0; l < scale; l++)
                        {
                            Console.SetCursorPosition((j*scale) + 15 + l, (i*scale) + 1 + k);
                            if (map[i, j] == '^')
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                            }
                            else if (map[i, j] == '`')
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                            }
                            else if (map[i, j] == '~')
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                            }
                            else if (map[i, j] == '*')
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                            }
                            Console.Write(map[i, j]);
                        }
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (i == 0)
                    {
                        for (int k = 0; k < scale; k++)
                        {
                            Console.SetCursorPosition((j * scale) + 15+k, (i * scale));
                            Console.Write("-");
                        }
                        if (j == 0)
                        {
                            Console.SetCursorPosition((j * scale) + 14, (i * scale) );
                            Console.Write("+");
                        }
                        if (j == mapY - 1)
                        {
                            Console.SetCursorPosition((j * scale) + 15+scale, (i * scale) );
                            Console.Write("+");
                        }
                    }
                    if (j == 0)
                    {
                        for (int k = 0; k < scale; k++)
                        {
                            Console.SetCursorPosition((j * scale) + 14, (i * scale) + 1 + k);
                            Console.Write("|");
                        }
                        
                    }
                    if (i == mapX - 1)
                    {
                        for (int k = 0; k < scale; k++)
                        {
                            Console.SetCursorPosition((j * scale) + 15 + k, (i * scale) + 1 + scale);
                            Console.Write("-");
                        }
                        
                        if (j == mapY - 1)
                        {
                            Console.SetCursorPosition((j * scale) + 15+scale, (i * scale) + 1 + scale);
                            Console.Write("+");
                        }
                        if (j == 0)
                        {
                            Console.SetCursorPosition((j * scale) + 14, (i * scale) + 1 + scale);
                            Console.Write("+");
                        }
                    }
                    if (j == mapY - 1)
                    {
                        for (int k = 0; k < scale; k++)
                        {
                            Console.SetCursorPosition((j * scale) + 15 + scale, (i * scale) + 1 + k);
                            Console.Write("|");
                        }
                        
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            
        }
    }
}
