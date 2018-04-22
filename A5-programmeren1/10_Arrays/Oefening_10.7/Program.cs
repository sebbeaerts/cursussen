using System;


namespace Oefening_10._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCount = 10;
            int colCount = 10;

            int[,] matrix = new int[rowCount, colCount];

            /*
            foreach (int element in matrix)
            {
                Console.Write(element + " ");
            }
            */

            int temp = 101;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = temp;
                    temp = temp + 1;
                }
            }

            for (int i = 0; i < rowCount; i++)
            {
                for(int j = 0; j < colCount; j++)
                {
                    Console.Write(matrix[i, j]+ " ");
                }
                Console.WriteLine();
            }
            //
            Console.ReadLine();
        }
    }
}
