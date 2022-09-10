using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWNCHESS
{
    internal class PlayerInput
    {
        public static string[] whitecoins = new string[5];
        public static string[] blackcoins = new string[5];
        public static void input()
        {

            Console.WriteLine("Input the Player1 Character Names one by one");
            for(int i = 0; i < 5; i++)
            {
                string temp = Console.ReadLine();
                whitecoins[i] = temp;
                //whitecoins.Append(temp);
            }

            Console.WriteLine("Input the Player2 Character Names one by one");
            for (int i = 0; i < 5; i++)
            {
                string temp1 = Console.ReadLine();
                blackcoins[i] = temp1;
                //blackcoins.Append(temp);
            }

        }

        public static void initialarrange(string str)
        {
            if (str == "blackcoins")
            {
                for(int i = 0; i < 5; i++)
                {
                    Program.matrix[0,i] = blackcoins[i];
                }
            }
            if (str == "whitecoins")
            {
                for(int A = 0; A < 5; A++)
                {
                    Program.matrix[4, A] = whitecoins[A];
                }
            }
        }
    }
}
