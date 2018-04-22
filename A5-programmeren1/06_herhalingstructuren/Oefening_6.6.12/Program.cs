using System;


namespace Oefening_6._6._12
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string temp = input;

            for (int i = 0; i <= temp.Length; i++)
            {
                if (temp == " ")
                {
                    temp = "_";
                }
                else
                {
                    temp = temp;
                }
            }

            Console.WriteLine(temp);
            //
            Console.ReadLine();
        }
    }
}
