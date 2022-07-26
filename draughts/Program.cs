using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draughts
{
    class Board
    {
        public int Black = 1;
        public int White = 2;
        public int Center = 0;
        public int[,] desk = new int[8, 8]
        {
                          {1,0,1,0,1,0,1,0},
                          {0,1,0,1,0,1,0,1},
                          {1,0,1,0,1,0,1,0},
                          {0,0,0,0,0,0,0,0},
                          {0,0,0,0,0,0,0,0},
                          {0,2,0,2,0,2,0,2},
                          {2,0,2,0,2,0,2,0},
                          {0,2,0,2,0,2,0,2}
        };

        //console output

        public void Draw()
        {
            Console.WriteLine("    01234567");
            Console.WriteLine("    ________");
            for (int i = 0; i < desk.GetLength(0); i++)
            {
                Console.Write($"{ i }  |");
                for(int j = 0; j < desk.GetLength(1); j++)
                {                  
                    Console.Write(desk[i,j]);
                }
               Console.WriteLine();
            }         
            Console.WriteLine("\n");
            

            CreateNewPosition();



        }

        public void CreateNewPosition()        
        {
            WhiteDraught();
           
            BlackDraught();
            
        }

        //the logic of the checkers move

        public void WhiteDraught()
        {
            int y = 0, x = 0, k = 0, n = 0;
            Console.WriteLine("\nХод белого");
            Console.Write("Enter the line of the checkers you want to go with: \t");
            y = int.Parse(Console.ReadLine());
            Console.Write("Enter the column of the checkers you want to go to: \t");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter the line where you want to go with a checker: \t");
            k = int.Parse(Console.ReadLine());
            Console.Write("Enter the column where you want to go with a checker: \t");
            n = int.Parse(Console.ReadLine());
            
                if (desk[y, x] == White && desk[k, n] == Black && desk[y-1, x+1] == Black && desk[y - 2, x + 2] == Center)
                {
                    desk[k, n] = White;
                    desk[y, x] = Center;
                    desk[y - 1, x + 1] = Center;
                }
                else if (desk[y, x] == White && desk[k, n] == Black &&  desk[y - 1, x - 1] == Black && desk[y - 2, x - 2] == Center)
                {
                    desk[k, n] = White;
                    desk[y, x] = Center;
                    desk[y - 1, x - 1] = Center;
                }
                else if (desk[y, x] == White && desk[k, n] == Black && desk[y + 1, x - 1] == Black && desk[y + 2, x - 2] == Center)
                {
                    desk[k, n] = White;
                    desk[y, x] = Center;
                    desk[y + 1, x - 1] = Center;
                }
                else if (desk[y, x] == White && desk[k, n] == Black && desk[y + 1, x + 1] == Black && desk[y + 2, x + 2] == Center)
                {
                    desk[k, n] = White;
                    desk[y, x] = Center;
                    desk[y + 1, x + 1] = Center;
                }
                
                else
                {
                    desk[k, n] = White;
                    desk[y, x] = Center;
                }
            
        }
        public void BlackDraught()
        {
            int y = 0, x = 0, k = 0, n = 0;

            Console.WriteLine("\nХод черного");
            Console.Write("Enter the line of the checkers you want to go with: \t");
            y = int.Parse(Console.ReadLine());
            Console.Write("Enter the column of the checkers you want to go to: \t");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter the line where you want to go with a checker: \t");
            k = int.Parse(Console.ReadLine());
            Console.Write("Enter the column where you want to go with a checker: \t");
            n = int.Parse(Console.ReadLine());

            if (desk[y, x] == Black && desk[k, n] == White && desk[y - 1, x + 1] == White && desk[y - 2, x + 2] == Center)
            {
                desk[k, n] = Black;
                desk[y, x] = Center;
                desk[y - 1, x + 1] = Center;
            }
            else if (desk[y, x] == Black && desk[k, n] == White && desk[y - 1, x - 1] == White && desk[y - 2, x - 2] == Center)
            {
                desk[k, n] = Black;
                desk[y, x] = Center;
                desk[y - 1, x - 1] = Center;
            }
            else if (desk[y, x] == Black && desk[k, n] == White && desk[y + 1, x - 1] == White && desk[y + 2, x - 2] == Center)
            {
                desk[k, n] = Black;
                desk[y, x] = Center;
                desk[y + 1, x - 1] = Center;
            }
            else if (desk[y, x] == Black && desk[k, n] == White && desk[y + 1, x + 1] == White && desk[y + 2, x + 2] == Center)
            {
                desk[k, n] = Black;
                desk[y, x] = Center;
                desk[y + 1, x + 1] = Center;
            }

            else
            {
                desk[k, n] = Black;
                desk[y, x] = Center;
            }

        }
    }

    internal class Program
    {
        Board board = new Board();

        static void Main(string[] args)
        {

            Board board = new Board();

            while (true)
            {
                Console.Clear();

                board.Draw();
                
            }
        }
    }
}
