using System;


namespace Oefening1
{
    class Punt
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Driehoek
    {
        private int _Count = 0;

        private Punt[] _Items = new Punt[0];

        public Punt this[int index]
        {
            get { return _Items[index]; }
        }

        public int GetCount()
        {
            return _Count;
        }

        public void Add(Punt punt)
        {
            _Count++;
            Array.Resize(ref _Items, GetCount());
            _Items[GetCount() - 1] = punt;
        }

        public double GetOmtrek()
        {
            double c = 0;
            double a = 0;
            double b = 0;

            if ((_Items[0].X > _Items[1].X) || (_Items[0].Y > _Items[1].Y))
            {
                a = _Items[0].X - _Items[1].X;
                b = _Items[0].Y - _Items[1].Y;
            }
            else
            {
                a = _Items[1].X - _Items[0].X;
                b = _Items[1].Y - _Items[0].Y;
            }
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Driehoek driehoek1 = new Driehoek();
            Punt punt1 = new Punt();
            punt1.X = 1;
            punt1.Y = 2;
            //
            Console.WriteLine(punt1.X == 1);
            Console.WriteLine(punt1.Y == 2);
            //
            Punt punt2 = new Punt();
            punt2.X = 5;
            punt2.Y = 5;
            //
            Console.WriteLine(punt2.X == 5);
            Console.WriteLine(punt2.Y == 5);
            //
            Punt punt3 = new Punt();
            punt3.X = 2;
            punt3.Y = 6;
            //
            Console.WriteLine(punt3.X == 2);
            Console.WriteLine(punt3.Y == 6);
            //

            driehoek1.Add(punt1);
            driehoek1.Add(punt2);
            driehoek1.Add(punt3);

            //
            driehoek1.GetOmtrek();
        
            //
            Console.ReadLine();
        }
    }
}
