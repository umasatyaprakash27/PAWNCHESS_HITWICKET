using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWNCHESS
{
    internal class Control
    {
        public static string controlcom;

        public static int move(string player,string inp)
        {
            string[] temp = inp.Split(':');

            if(player == "Player1")
            {
                for(int i = 0; i<5; i++)
                {
                    for(int j = 0;j<5;j++)
                    {
                        if(Program.matrix[i,j] == temp[0])
                        {
                            switch(temp[1])
                            {
                                case "L":
                                    Program.matrix[i, j - 1] = Program.matrix[i, j];
                                    Program.matrix[i,j] = " ";
                                    if (PlayerInput.whitecoins.Contains(Program.matrix[i, j - 1]))
                                    {
                                        Program.a2points = Program.a2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "R":
                                    Program.matrix[i,j + 1] = Program.matrix[i, j];
                                    Program.matrix[i,j] = " ";
                                    if (PlayerInput.whitecoins.Contains(Program.matrix[i, j + 1]))
                                    {
                                        Program.a2points = Program.a2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "F":
                                    Program.matrix[i - 1, j] = Program.matrix[i, j];
                                    Program.matrix[i,j] = " ";
                                    if (PlayerInput.whitecoins.Contains(Program.matrix[i - 1, j]))
                                    {
                                        Program.a2points = Program.a2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "B":
                                    Program.matrix[i + 1, j] = Program.matrix[i, j];
                                    Program.matrix[i,j] = " ";
                                    if (PlayerInput.whitecoins.Contains(Program.matrix[i + 1, j]))
                                    {
                                        Program.a2points = Program.a2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                
                            }
                            return 0;
                            //switch case
                            //move coin
                        }

                    }

                }

            }
            return 0;
        }

        public static int move2(string player, string inp)
        {
            string[] temp1 = inp.Split(':');

            if (player == "Player2")
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        //Console.WriteLine(k);
                        //Console.WriteLine(l);
                        //Console.WriteLine(Program.matrix[k, l]);
                        //Console.WriteLine(temp1[0]);
                        //Console.ReadKey();
                        if(Program.matrix[k, l] == temp1[0])
                        {
                            //switch case
                            switch (temp1[1])
                            {
                                case "L":
                                    Program.matrix[k, l - 1] = Program.matrix[k, l];
                                    Program.matrix[k, l] = " ";
                                    if (PlayerInput.blackcoins.Contains(Program.matrix[k, l - 1]))
                                    {
                                        Program.a1points = Program.a2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "R":
                                    Program.matrix[k, l + 1] = Program.matrix[k, l];
                                    Program.matrix[k, l] = " ";
                                    if (PlayerInput.blackcoins.Contains(Program.matrix[k, l + 1]))
                                    {
                                        Program.a1points = Program.a2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "F":
                                    Program.matrix[k + 1, l] = Program.matrix[k, l];
                                    Program.matrix[k, l] = " ";
                                    if (PlayerInput.blackcoins.Contains(Program.matrix[k + 1, l]))
                                    {
                                        Program.a1points = Program.a2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "B":
                                    Program.matrix[k - 1, l] = Program.matrix[k, l];
                                    Program.matrix[k, l] = " ";
                                    if (PlayerInput.blackcoins.Contains(Program.matrix[k - 1, l]))
                                    {
                                        Program.a1points = Program.a2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                            }

                        }
                    }
                }
            }
            return 0;
        }
    }
}
