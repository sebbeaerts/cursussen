using System;


namespace Oefening_17._3._1
{
    class Rechthoeken
    {
        private int _Count = 0;

        private Rechthoek[] _Items = new Rechthoek[0];
        public Rechthoek this[int index]
        {
            get { return _Items[index]; }
        }

        public int GetCount()
        {
            return _Count;
        }

        public void Add(Rechthoek rechthoek)
        {
            _Count++;
            Array.Resize(ref _Items, GetCount());
            _Items[GetCount() - 1] = rechthoek;
        }

        //public void Remove(Rechthoek rechthoek)
        //{
            
        //}
    }

    class Rechthoek
    {
        public Rechthoeken Rechthoeken { get; set; } = new Rechthoeken();

        public int Hoogte { get; set; } = 0;
        public int Breedte { get; set; } = 0;

        public int GetOppervlakte()
        {
            int opp = 0;
            opp = Hoogte * Breedte;
            return opp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek1 = new Rechthoek();
            rechthoek1.Breedte = 5;
            rechthoek1.Hoogte = 10;
            Rechthoeken.Add(rechthoek1);
            Rechthoek rechthoek2 = new Rechthoek();
            rechthoek2.Breedte = 3;
            rechthoek2.Hoogte = 6;
            Rechthoek rechthoek3 = new Rechthoek();
            rechthoek1.Breedte = 4;
            rechthoek1.Hoogte = 2;

            Console.WriteLine(rechthoek1.Breedte == 5);
            Console.WriteLine(rechthoek1.Hoogte == 10);

            Console.WriteLine(rechthoek2.Breedte == 3);
            Console.WriteLine(rechthoek2.Hoogte == 6);

            Console.WriteLine(rechthoek3.Breedte == 4);
            Console.WriteLine(rechthoek3.Hoogte == 2);
            //
            Console.ReadLine();
        }
    }
}
