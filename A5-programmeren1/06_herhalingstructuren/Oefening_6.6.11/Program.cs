using System;

namespace Oefening_6._6._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string temp = input;

            for(int i = 0; i<=temp.Length; i++)
            {
                temp = temp.ToLower();
            }

            Console.WriteLine(temp);
            //
            Console.ReadLine();
        }
    }
}
