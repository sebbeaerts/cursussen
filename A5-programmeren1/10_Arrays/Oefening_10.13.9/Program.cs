using System;

namespace Oefening_10._13._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 5;
            int column = 9;
            int startValue = 11;

            int[,] array = new int[row, column];


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = (startValue + j);
                }
            }

            //print
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }


            Console.ReadLine();
        }
    }
}
