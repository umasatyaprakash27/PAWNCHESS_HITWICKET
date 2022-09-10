using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWNCHESS
{
    internal class Program
    {
        public static string[,] matrix = new string[5, 5];
        public static bool gamestatus = true;
        public static int a1points = 5;
        public static int a2points = 5;

        static void Main(string[] args)
        {
            
            PlayerInput.input();
            PlayerInput.initialarrange("blackcoins");
            PlayerInput.initialarrange("whitecoins");

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(matrix[i, j] == null || matrix[i,j] == " ")
                    {
                        Console.Write("-"+ "   ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "  ");
                    }
                    
                }
                Console.WriteLine();
            }
            startgane();
            Console.ReadKey();
        }


        public static void startgane()
        {
            while(gamestatus)
            {
                Console.WriteLine("Player1 Input");
                string inp1 = Console.ReadLine();
                Control.move("Player1", inp1);

                Console.WriteLine("Player2 Input");
                string inp2 = Console.ReadLine();
                Control.move2("Player2",inp2);

                Console.WriteLine();

            }
        }

        public static void printboard()
        {
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == null || matrix[i, j] == " ")
                    {
                        Console.Write("-" + "   ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "  ");
                    }

                }
                
                Console.WriteLine();
            }
            if(a1points <=0)
            {
                Console.WriteLine("Congrats Player 2 Won The Game");
                
            }

            if(a2points <= 0)
            {
                Console.WriteLine("Congrats Player 1 Won The Game");
            }

        }
        
    }
}
