using System;

namespace Oefening_17._3._1_verbetering
{
    class Rechthoeken
    {
        private int _Count = 0;
        private Rechthoek[]_Items = new Rechthoek[0];
        public Rechthoek this[int index]
        {
            get {return _Items[index];}
        }
        public int GetCount() {return _Count;}
        public void Add(Rechthoek rechthoek)
        {
            _Count++;Array.Resize(ref _Items,GetCount());
            _Items[GetCount() - 1] = rechthoek;
        }

        public int GetTotaleOppervlakte()
        {
            int totaalOppervlakte = 0;
            foreach (Rechthoek element in _Items)
            {
                totaalOppervlakte += element.GetOppervlakte();
            }
            return totaalOppervlakte;
        }
    }

    class Rechthoek
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }
        public int GetOppervlakte()
        {
            int result = Hoogte * Breedte;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Rechthoek r1 = new Rechthoek();

            Console.WriteLine(r1.Hoogte == 0);
            Console.WriteLine(r1.Breedte == 0);
            Console.WriteLine(r1.GetOppervlakte() == 0);
            //
            r1.Hoogte = 10;
            Console.WriteLine(r1.Hoogte == 10);
            Console.WriteLine(r1.Breedte == 0);
            Console.WriteLine(r1.GetOppervlakte() == 0);
            //
            r1.Breedte = 20;
            Console.WriteLine(r1.Hoogte == 10);
            Console.WriteLine(r1.Breedte == 20);
            Console.WriteLine(r1.GetOppervlakte() == 200);
            //
            Rechthoek r2 = new Rechthoek();
            r2.Hoogte = 20;
            r2.Breedte = 30;
            Console.WriteLine(r2.Hoogte == 20);
            Console.WriteLine(r2.Breedte == 30);
            Console.WriteLine(r2.GetOppervlakte() == 600);
            //
            Rechthoek r3 = new Rechthoek();
            r3.Hoogte = 10;
            r3.Breedte = 30;
            Console.WriteLine(r3.Hoogte == 10);
            Console.WriteLine(r3.Breedte == 30);
            Console.WriteLine(r3.GetOppervlakte() == 300);
            //
            Rechthoeken rechthoeken1 = new Rechthoeken();
            Console.WriteLine(rechthoeken1.GetCount() == 0);
            rechthoeken1.Add(r1);
            rechthoeken1.Add(r2);
            rechthoeken1.Add(r3);
            rechthoeken1.Add(r1);
            Console.WriteLine(rechthoeken1.GetCount() == 4);
            //

            Console.WriteLine(rechthoeken1.GetTotaleOppervlakte() == 1300);

            //
            Console.ReadLine();
        }
    }
}
