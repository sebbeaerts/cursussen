using System;


namespace sub6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef startwaarde: ");
            int startwaarde = 20; //Convert.ToInt32(Console.ReadLine());
            int temp = startwaarde;

            Console.WriteLine("Geef eindwaarde: ");
            int eindwaarde = 10; //Convert.ToInt32(Console.ReadLine());

            while (temp >= eindwaarde)
            {
                Console.WriteLine(temp);
                temp--;
            }
            //
            Console.ReadLine();
        }
    }
}
