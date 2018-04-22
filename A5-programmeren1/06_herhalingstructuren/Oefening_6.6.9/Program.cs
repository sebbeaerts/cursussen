using System;


namespace Oefening_6._6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int temp = input;
            int rest = 0;

            string result = "";
            string karakter = "";

            while (temp > 0)
            {
                rest = temp % 16;
                temp = temp / 16;
                switch (rest)
                {
                    case 10: karakter = "A"; break;
                    case 11: karakter = "B"; break;
                    case 12: karakter = "C"; break;
                    case 13: karakter = "D"; break;
                    case 14: karakter = "E"; break;
                    case 15: karakter = "F"; break;
                    default: karakter = rest.ToString(); break;
                }
                result = karakter + result;

            }
            Console.WriteLine(result);
            //
            Console.ReadLine();
        }
    }
}
