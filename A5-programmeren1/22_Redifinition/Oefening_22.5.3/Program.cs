using System;


namespace Oefening_22._5._3
{
    class Holiday
    {
        private int _Count = 0;

        private Flight[] _Items = new Flight[0];

        public Flight Items(int index)
        {
            return _Items[index];
        }

        public int GetCount()
        {
            return _Count;
        }

        public void Add(Flight flight)
        {
            _Count++;
            Array.Resize(ref _Items, GetCount());
            _Items[GetCount() - 1] = flight;
        }

        public override string ToString()
        {
            return ToString(); 
        }
    }

    class Flight
    {
        public Flight(object airport1, object airport2)
        {
            this.Airport1 = airport1;
            this.Airport2 = airport2;
        }

        public object Airport1 { get; set; }
        public object Airport2 { get; set; }
    }

    class Airport
    {
        public Airport(string initials, string stad)
        {
            this.Initials = initials;
            this.Stad = stad;
        }

        public string Initials { get; set; }
        public string Stad { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Airport airport1 = new Airport("ZAV", "Brussels");
            Airport airport2 = new Airport("NYK", "NewYorkKennedy");
            Console.WriteLine(airport1.Initials + " " + airport1.Stad);
            Console.WriteLine(airport2.Initials + " " + airport2.Stad);
            //
            Flight flight1 =new Flight(airport1, airport2);
            Flight flight2 =new Flight(airport2, airport1);
            Console.WriteLine(flight1.Airport1 + "-->" + flight1.Airport2);
            Console.WriteLine(flight1.Airport2 + "<--" + flight1.Airport1);
            //
            Holiday holiday1 = new Holiday();
            holiday1.Add(flight1);
            holiday1.Add(flight2);
            //
            
            for (int index = 0; index < (holiday1.GetCount() - 1); index++)
            {
                Console.WriteLine(holiday1.Items(index).ToString());
            }
            //
            Console.ReadLine();
        }
    }
}
