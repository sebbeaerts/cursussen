using System;

namespace Oefening_14._4._4
{
    class Positie
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
    }

    class Robot
    {

        public int Richting { get; private set; } = 0;

        public Positie Positie { get; private set; } = new Positie();

        public void Stap()
        {
            switch (Richting)
            {
                case 0: Positie.Y = Positie.Y + 1; break;
                case 1: Positie.X = Positie.X + 1; break;
                case 2: Positie.Y = Positie.Y + 1; break;
                case 3: Positie.X = Positie.X + 1; break;
            }
        }

        public void Draai()
        {
            Richting = Richting + 1;

            if (Richting == 4)
            {
                Richting = 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot1 = new Robot();
            Console.WriteLine(robot1.Positie.X == 0);
            Console.WriteLine(robot1.Positie.Y == 0);
            Console.WriteLine(robot1.Richting == 0);
            //
            robot1.Stap();
            Console.WriteLine(robot1.Positie.X == 0);
            Console.WriteLine(robot1.Positie.Y == 1);
            Console.WriteLine(robot1.Richting == 0);
            //
            robot1.Stap();
            Console.WriteLine(robot1.Positie.X == 0);
            Console.WriteLine(robot1.Positie.Y == 2);
            Console.WriteLine(robot1.Richting == 0);
            //
            robot1.Draai();
            Console.WriteLine(robot1.Positie.X == 0);
            Console.WriteLine(robot1.Positie.Y == 2);
            Console.WriteLine(robot1.Richting == 1);
            //
            robot1.Stap();
            robot1.Stap();
            Console.WriteLine(robot1.Positie.X == 2);
            Console.WriteLine(robot1.Positie.Y == 2);
            Console.WriteLine(robot1.Richting == 1);
            //
            robot1.Draai();
            robot1.Draai();
            robot1.Draai();
            Console.WriteLine(robot1.Positie.X == 2);
            Console.WriteLine(robot1.Positie.Y == 2);
            Console.WriteLine(robot1.Richting == 0);
            Console.ReadLine();
            //
            robot1.Stap();
            robot1.Stap();
            Console.WriteLine(robot1.Positie.X == 2);
            Console.WriteLine(robot1.Positie.Y == 4);
            Console.WriteLine(robot1.Richting == 0);
            //
            robot1.Draai();
            robot1.Draai();
            robot1.Stap();
            Console.WriteLine(robot1.Positie.X == 2);
            Console.WriteLine(robot1.Positie.Y == 1);
            Console.WriteLine(robot1.Richting == 2);
            //
            Console.ReadLine();
        }
    }
}
