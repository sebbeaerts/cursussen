using System;


namespace Oefening_19._1._1
{
    class Counter
    {
        public int Value { get; protected set; }
        public void Raise()
        {
            Value++;
        }
        public void Lower()
        {
            Value--;
        }
    }

    class SpecialCounter : Counter
    {
        public void SetValue(int value)
        {
            Value = value;
        }

        public void Raise(int stepvalue)
        {
            Value = Value + stepvalue;
        }
        public void Lower(int stepvalue)
        {
            Value = Value - stepvalue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter();
            Console.WriteLine(counter1.Value == 0);
            //
            counter1.Raise();
            counter1.Raise();
            Console.WriteLine(counter1.Value == 2);
            //
            counter1.Lower();
            counter1.Raise();
            counter1.Raise();
            Console.WriteLine(counter1.Value == 3);
            //
            SpecialCounter sc1 = new SpecialCounter();
            Console.WriteLine(sc1.Value == 0);
            //
            sc1.Raise();
            sc1.Raise();
            Console.WriteLine(sc1.Value == 2);
            //
            sc1.Lower();
            sc1.Raise();
            sc1.Raise();
            Console.WriteLine(sc1.Value == 3);
            //
            sc1.SetValue(1000);
            Console.WriteLine(sc1.Value == 1000);
            sc1.Lower();
            sc1.Lower(100);

            counter1.Lower();

            Console.ReadLine();
        }
    }
}
