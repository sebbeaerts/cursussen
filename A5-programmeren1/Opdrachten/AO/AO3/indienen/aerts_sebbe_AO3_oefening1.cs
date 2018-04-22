using System;


namespace aerts_sebbe_AO3_oefening1
{
    enum Richting
    {
        Boven,
        Rechts,
        Beneden,
        Links
    }

    class Spoor
    {
        private Positie[] _Items = new Positie[0];
        public Positie this[int index]
        {
            get { return _Items[index]; }
        }

        public int Count { get; private set; }
        public void Add(Positie positie)
        {
            Count = Count + 1;
            Array.Resize(ref _Items, Count);
            _Items[(Count - 1)] = positie;
        }
        public void ToonSpoor()
        {
            Console.Write(_Items[0]);

            for (int index = 1; index < Count; index++)
            {
                Console.Write(" -> " + _Items[index]);
            }

            Console.WriteLine();
        }
    }

    class Robots
    {
        private Robot[] _Items = new Robot[0];

        public Robot this[int index]
        {
            get { return _Items[index]; }
        }

        //return item uit de collectie door een string mee te geven in de default property.
        public Robot this[string naam]
        {
            get
            {
                int index = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (_Items[i].Naam == naam)
                    {
                        index = i;
                    }
                }
                return _Items[index];
            }
            
        }

        public int Count { get; private set; }

        public void Add(Robot robot)
        {
            Count = Count + 1;
            Array.Resize(ref _Items, Count);
            _Items[(Count - 1)] = robot;
        }

        //methods
        public void StapAllemaal()
        {
            foreach(Robot item in _Items)
            {
                item.Stap();
            }
        }

        public void DraaiAllemaal()
        {
            foreach(Robot item in _Items)
            {
                item.Draai();
            }
        }

        public Robot VerstOpX()
        {
            int index = 0;
            for(int i = 1; i < Count; i++)
            {
                if(_Items[i].Positie.X > _Items[i - 1].Positie.X)
                {
                    index = i;
                }
            }
            return _Items[index];
        }

        public Robot VerstOpY()
        {
            int index = 0;
            for (int i = 1; i < Count; i++)
            {
                if (_Items[i].Positie.Y > _Items[i - 1].Positie.Y)
                {
                    index = i;
                }
            }
            return _Items[index];
        }

        public Robot MeesteStappen()
        {
            int index = 0;
            for (int i = 1; i < Count; i++)
            {
                if (_Items[i].Spoor.Count > _Items[i].Spoor.Count)
                {
                    index = i;
                }
            }
            return _Items[index];
        }

        public void RobotsOpPunt(int x, int y)
        {
            int aantalRobots = 0;
            for(int i = 0; i < Count; i++)
            {
                if((_Items[i].Positie.X == x) && (_Items[i].Positie.Y == y))
                {
                    Console.WriteLine(_Items[i].Naam);
                    aantalRobots++;
                }
            }
            if(aantalRobots == 0)
            {
                Console.WriteLine("Op dit punt staan er geen robots.");
            }
        }

        public void PrintRobots()
        {
            foreach(Robot item in _Items)
            {
                Console.WriteLine(item.Naam + " : " + item.Positie.X + "-" + item.Positie.Y + " , " + item.Richting);
            }
        }
    }

    class SpecialeRobot : Robot
    {
        public SpecialeRobot(string naam) : base(naam) { }
        public SpecialeRobot(string naam, Positie positie) : base(naam, positie) { }

        //herdefiniëren van stap() methoden.
        public override void Stap()
        {
            switch (Richting)
            {
                case Richting.Boven: Positie.Y = Positie.Y + 2; break;
                case Richting.Rechts: Positie.X = Positie.X + 2; break;
                case Richting.Beneden: Positie.Y = Positie.Y - 2; break;
                case Richting.Links: Positie.X = Positie.X - 2; break;
            }
            this.Spoor.Add(new Positie(this.Positie.X, this.Positie.Y));
        }

        public override void Stap(int aantalStappen)
        {
            for (int i = 0; i < (aantalStappen/2); i++)
            {
                Stap();
            }
        }
    }

    class Robot
    {
        public Robot(string naam)
        {
            this.Naam = naam;
            this.Positie = new Positie(0, 0);
            this.Spoor = new Spoor();
        }

        public Robot(string naam, Positie positie):this(naam)
        {
            this.Positie = positie;
            this.Spoor.Add(new Positie(this.Positie.X, this.Positie.Y));
        }

        public string Naam { get; private set; }
        public Positie Positie { get; private set; }
        public Richting Richting { get; private set; } = Richting.Boven;
        public Spoor Spoor { get; private set; }

        //methoden
        public virtual void Stap()
        {
            switch(Richting)
            {
                case Richting.Boven: Positie.Y++; break;
                case Richting.Rechts: Positie.X++; break;
                case Richting.Beneden: Positie.Y--; break;
                case Richting.Links: Positie.X--; break;
            }
            //positie wordt toegevoegd aan het spoor.
            this.Spoor.Add(new Positie(this.Positie.X, this.Positie.Y));
        }

        //overload stap()
        public virtual void Stap(int aantalStappen)
        {
            for(int i= 0; i < aantalStappen; i++)
            {
                Stap();
            }
        }

        public void Draai()
        {
            if(Richting == Richting.Links)
            {
                Richting = Richting.Boven;
            }
            else
            {
                Richting = Richting + 1;
            } 
        }
    }

    class Positie
    {
        public Positie()
        {
            this.X = 0;
            this.Y = 0;
        }
        public Positie(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return this.X + " - " + this.Y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Aanmaken van een positie-object
            Positie positie1 = new Positie(2, 3);

            // Aanmaken van een robot
            Console.WriteLine("1 ------------------------------------------");
            Robot robot1 = new Robot("Bart", positie1);
            // ----controles uitvoeren
            Console.WriteLine(robot1.Naam == "Bart");
            Console.WriteLine(robot1.Positie.X == 2);
            Console.WriteLine(robot1.Positie.Y == 3);
            Console.WriteLine(robot1.Richting == Richting.Boven);
            
            // Aanmaken van een robot
            Console.WriteLine("2 ------------------------------------------");
            Robot robot2 = new Robot("Pieter");
            // ----controles uitvoeren
            Console.WriteLine(robot2.Naam == "Pieter");
            Console.WriteLine(robot2.Positie.X == 0);
            Console.WriteLine(robot2.Positie.Y == 0);
            Console.WriteLine(robot2.Richting == Richting.Boven);
            
            // Aanmaken van een robot
            Console.WriteLine("3 ------------------------------------------");
            Robot robot3 = new Robot("Tom", new Positie(4, 6));
            // ----controles uitvoeren
            Console.WriteLine(robot3.Naam == "Tom");
            Console.WriteLine(robot3.Positie.X == 4);
            Console.WriteLine(robot3.Positie.Y == 6);
            Console.WriteLine(robot3.Richting == Richting.Boven);
            
            Console.WriteLine("4 ------------------------------------------");
            robot1.Stap();
            robot1.Stap();
            // ----controles uitvoeren
            Console.WriteLine(robot1.Naam == "Bart");
            Console.WriteLine(robot1.Positie.X == 2);
            Console.WriteLine(robot1.Positie.Y == 5);
            Console.WriteLine(robot1.Richting == Richting.Boven);
            
            Console.WriteLine("5 ------------------------------------------");
            robot2.Stap();
            robot2.Stap();
            robot2.Draai();
            robot2.Draai();
            robot2.Draai();
            // ----controles uitvoeren
            Console.WriteLine(robot2.Naam == "Pieter");
            Console.WriteLine(robot2.Positie.X == 0);
            Console.WriteLine(robot2.Positie.Y == 2);
            Console.WriteLine(robot2.Richting == Richting.Links);
            
            Console.WriteLine("6 ------------------------------------------");
            robot3.Stap();
            robot3.Stap();
            robot3.Draai();
            robot3.Stap();
            // ----controles uitvoeren
            Console.WriteLine(robot3.Naam == "Tom");
            Console.WriteLine(robot3.Positie.X == 5);
            Console.WriteLine(robot3.Positie.Y == 8);
            Console.WriteLine(robot3.Richting == Richting.Rechts);
            
            Console.WriteLine("7 ------------------------------------------");
            Robot robot4 = new SpecialeRobot("Lieven");
            // ----controles uitvoeren
            Console.WriteLine(robot4.Naam == "Lieven");
            Console.WriteLine(robot4.Positie.X == 0);
            Console.WriteLine(robot4.Positie.Y == 0);
            Console.WriteLine(robot4.Richting == Richting.Boven);
            
            Console.WriteLine("8 ------------------------------------------");
            Robot robot5 = new SpecialeRobot("Marleen", new Positie(4, 6));
            // ----controles uitvoeren
            Console.WriteLine(robot5.Naam == "Marleen");
            Console.WriteLine(robot5.Positie.X == 4);
            Console.WriteLine(robot5.Positie.Y == 6);
            Console.WriteLine(robot5.Richting == Richting.Boven);
            
            Console.WriteLine("9 ------------------------------------------");
            robot4.Stap(); //2 stappen zetten
                           // ----controles uitvoeren
            Console.WriteLine(robot4.Naam == "Lieven");
            Console.WriteLine(robot4.Positie.X == 0);
            Console.WriteLine(robot4.Positie.Y == 2);
            Console.WriteLine(robot4.Richting == Richting.Boven);
            
            Console.WriteLine("10 ------------------------------------------");
            robot5.Stap(); //2 stappen zetten
            robot5.Stap(4); //4 stappen zetten
            robot5.Draai();
            robot5.Draai();
            robot5.Draai();
            robot5.Stap(); //2 stappen zetten
                           // ----controles uitvoeren
            Console.WriteLine(robot5.Naam == "Marleen");
            Console.WriteLine(robot5.Positie.X == 2);
            Console.WriteLine(robot5.Positie.Y == 12);
            Console.WriteLine(robot5.Richting == Richting.Links);
            
            // Toon de sporen van de robots
            Console.WriteLine("11 ------------------------------------------");
            robot1.Spoor.ToonSpoor();       // 2 - 3 -> 2 - 4 -> 2 - 5
            
            Console.WriteLine("12 ------------------------------------------");
            robot5.Spoor.ToonSpoor();       // 4 - 6 -> 4 - 8 -> 4 - 12 -> 2 - 12
            Console.WriteLine();
            
            // Maak een collectie van Robot-objecten
            Console.WriteLine("13 ------------------------------------------");
            Robots robots1 = new Robots();
            robots1.Add(new Robot("Katrien"));
            robots1.Add(new Robot("Frederick", new Positie(2, 3)));
            // ----controles uitvoeren
            Console.WriteLine(robots1[0].Naam == "Katrien");
            Console.WriteLine(robots1[0].Positie.X == 0);
            Console.WriteLine(robots1[0].Positie.Y == 0);
            Console.WriteLine(robots1[0].Richting == Richting.Boven);
            
            Console.WriteLine(robots1["Frederick"].Naam == "Frederick");
            Console.WriteLine(robots1["Frederick"].Positie.X == 2);
            Console.WriteLine(robots1["Frederick"].Positie.Y == 3);
            Console.WriteLine(robots1["Frederick"].Richting == Richting.Boven);
            

            // Laat alle robot-objecten binnen de collectie bepaalde methoden uitvoeren
            Console.WriteLine("14 ------------------------------------------");
            robots1.StapAllemaal();
            robots1.StapAllemaal();

            Console.WriteLine(robots1[0].Positie.X == 0);
            Console.WriteLine(robots1[0].Positie.Y == 2);
            Console.WriteLine(robots1[0].Richting == Richting.Boven);

            Console.WriteLine(robots1[1].Positie.X == 2);
            Console.WriteLine(robots1[1].Positie.Y == 5);
            Console.WriteLine(robots1[1].Richting == Richting.Boven);
            
            Console.WriteLine("15 ------------------------------------------");
            robots1.DraaiAllemaal();

            Console.WriteLine(robots1[0].Positie.X == 0);
            Console.WriteLine(robots1[0].Positie.Y == 2);
            Console.WriteLine(robots1[0].Richting == Richting.Rechts);

            Console.WriteLine(robots1[1].Positie.X == 2);
            Console.WriteLine(robots1[1].Positie.Y == 5);
            Console.WriteLine(robots1[1].Richting == Richting.Rechts);
            
            Console.WriteLine("16 ------------------------------------------");
            robots1[0].Draai();

            Console.WriteLine(robots1["Katrien"].Positie.X == 0);
            Console.WriteLine(robots1["Katrien"].Positie.Y == 2);
            Console.WriteLine(robots1["Katrien"].Richting == Richting.Beneden);

            Console.WriteLine(robots1[1].Positie.X == 2);
            Console.WriteLine(robots1[1].Positie.Y == 5);
            Console.WriteLine(robots1[1].Richting == Richting.Rechts);
            
            Console.WriteLine("17 ------------------------------------------");
            robots1[1].Stap();

            Console.WriteLine(robots1[0].Positie.X == 0);
            Console.WriteLine(robots1[0].Positie.Y == 2);
            Console.WriteLine(robots1[0].Richting == Richting.Beneden);

            Console.WriteLine(robots1[1].Positie.X == 3);
            Console.WriteLine(robots1[1].Positie.Y == 5);
            Console.WriteLine(robots1[1].Richting == Richting.Rechts);
            
            Console.WriteLine("18 ------------------------------------------");
            // Schrijf een methode om te testen wie het verst staat op de x-as
            Console.WriteLine(robots1.VerstOpX().Naam == "Frederick");

            // Schrijf een methode om te testen wie het verst staat op de y-as
            Console.WriteLine(robots1.VerstOpY().Naam == "Conny"); 
            //conny is niet aangemaakt --> false

            
            Console.WriteLine("19 ------------------------------------------");
            // Schrijf een methode om te testen wie reeds de meeste stappen heeft gezet
            Console.WriteLine(robots1.MeesteStappen().Naam == "Katrien"); 
            
            Console.WriteLine("20 ------------------------------------------");
            // Schrijf een methode om te testen wie allemaal op het punt (0,2) staat? Indien niemand, geef dan een mooie melding. Indien meerdere, geef dan alle namen terug (neem een andere punt bijvoorbeeld om dit te testen).
            robots1.RobotsOpPunt(0, 2);
            robots1.RobotsOpPunt(2, 6);

            //robots1.PrintRobots();
            //robots1["Katrien"].Draai();
            //robots1.PrintRobots();
            //robots1["Katrien"].Draai();
            //robots1.PrintRobots();
            //robots1["Katrien"].Stap(3);
            //robots1["Katrien"].Draai();
            //robots1["Katrien"].Stap(3);
            //robots1.PrintRobots();
            //robots1.RobotsOpPunt(3, 5);

            /*
            Console.WriteLine("21 ------------------------------------------");
            // Schrijf een methode om te testen wie allemaal op het punt (0,2) heeft gestaan? Indien niemand, geef dan een mooie melding. Indien meerdere, geef dan alle namen terug (neem een andere punt bijvoorbeeld om dit te testen).
            robots1["Katrien"].Stap();
            robots1["Frederick"].Draai();
            robots1["Frederick"].Stap(3);
            robots1["Frederick"].Draai();
            robots1["Frederick"].Stap(3);
            robots1["Frederick"].Draai();
            robots1["Frederick"].Stap();
            robots1.PrintRobots();
            robots1.RobotsOpPuntGestaan(0, 2);


            Console.WriteLine("22 ------------------------------------------");
            // Schrijf een methode die weergeeft of er ooit ergens op hetzelfde moment 2 robots op hetzelfde punt gestaan hebben. Eventueel moet je een bepaalde robot naar hetzelfde punt brengen om dit te testen
            */

            Console.WriteLine("23 ------------------------------------------");
            // Schrijf een methode die weergeeft waar iedereen momenteel staat (naam + welk punt + richting)
            robots1.PrintRobots();
            
            Console.ReadLine();
        }
    }
}
