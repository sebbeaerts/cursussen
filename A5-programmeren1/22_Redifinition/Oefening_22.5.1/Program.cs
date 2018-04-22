using System;


namespace Oefening_22._5._1
{
    class Program
    {
        class Werknemer
        {
            //constructor
            public Werknemer(int maandloon)
            {
                this.Maandloon = maandloon;
            }

            //getters en setter als property
            private int Maandloon { get;  set; }

            //virtual maakt het mogelijk om deze methode te herdefiniëren
            public virtual int getJaarloon()
            {
                int result = Maandloon * 12;
                return result;
            }
        }

        class Manager : Werknemer
        {
            //constructor van manager met een verwijzing naar de base constructor (constructoren worden niet overgeërft)
            public Manager(int maandloon, int premie):base(maandloon)
            {
                this.Premie = premie;
            }

            private int Premie { get; set; }

            //de methode wordt hier verwijst naar getJaarloon in werknemer maar wordt geherdefinieërd
            public override int getJaarloon()
            {
                int result = base.getJaarloon() + Premie;
                return result;
            }
        }

        static void Main(string[] args)
        {
            //aanmaken van objecten werknemer en manager
            Werknemer w1 = new Werknemer(1500);
            Werknemer m1 = new Manager(1500, 200);
            Console.WriteLine(w1.getJaarloon());
            Console.WriteLine(m1.getJaarloon());
            //
            Console.ReadLine();
        }
    }
}
