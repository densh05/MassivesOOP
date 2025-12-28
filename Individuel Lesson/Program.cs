using System;
using System.Text;

namespace Individuel_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string[,] checks = new string[8, 8];

            checks[0, 0] = checks [0, 7] = checks[7, 0] = checks[7, 7] = "Ладья";
            checks[0, 1] = checks [0, 6] = checks[7, 1] = checks[7, 6] =  "Кінь";
            checks[0, 2] = checks [0, 5] = checks[7, 2] = checks[7, 5] = "Слон";
            checks[0, 3] = checks[7, 3] = "Король";
            checks[0, 4] = checks[7, 4] = "Ферзь";

            for(int i = 0; i < 8; i++)
            {
                checks[1, i] = checks[6, i] = "Пішак";
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine(checks[i, j]);
                }
            }


        }
    }
}
