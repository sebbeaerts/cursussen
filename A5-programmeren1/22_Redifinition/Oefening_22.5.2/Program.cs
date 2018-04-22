using System;


namespace Oefening_22._5._2
{
    class Addition
    {
        public Addition(int operand1, int operand2)
        {
            this.Operand1 = operand1;
            this.Operand2 = operand2;
        }

        public int Operand1 { get; set; }
        public int Operand2 { get; set; }

        public int GetSum()
        {
            return (Operand1 + Operand2);
        }

        public override string ToString()
        {
            return Operand1 + " + " + Operand2 + " = " + GetSum();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Addition addition1 = new Addition(3, 4);
            Console.WriteLine(addition1.GetSum());
            Console.WriteLine(addition1.ToString());
            //
            addition1.Operand1 = 5;
            addition1.Operand2 = 6;
            Console.WriteLine(addition1.GetSum());
            Console.WriteLine(addition1.ToString());
            //
            Console.ReadLine();
        }
    }
}
