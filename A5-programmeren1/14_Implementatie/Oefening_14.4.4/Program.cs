using System;

namespace Oefening_14._4._4
{
    class Robot
    {
        public int X { get; private set; } = 0;
        public int Y { get; private set; } = 0;
        public int Richting { get; private set; } = 0;

        public void Stap()
        {
            switch(Richting)
            {
                case 0: Y = Y + 1; break;
                case 1: X = X + 1; break;
                case 2: Y = Y + 1; break;
                case 3: X = X + 1; break;
            }
        }

        public void Draai()
        {
            Richting = Richting + 1;

            if(Richting == 4)
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
            Console.WriteLine(robot1.X == 0);
            Console.WriteLine(robot1.Y == 0);
            Console.WriteLine(robot1.Richting == 0);
            //
            robot1.Stap();
            Console.WriteLine(robot1.X == 0);
            Console.WriteLine(robot1.Y == 1);
            Console.WriteLine(robot1.Richting == 0);
            //
            robot1.Stap();
            Console.WriteLine(robot1.X == 0);
            Console.WriteLine(robot1.Y == 2);
            Console.WriteLine(robot1.Richting == 0);
            //
            robot1.Draai();
            Console.WriteLine(robot1.X == 0);
            Console.WriteLine(robot1.Y == 2);
            Console.WriteLine(robot1.Richting == 1);
            //
            robot1.Stap();
            robot1.Stap();
            Console.WriteLine(robot1.X == 2);
            Console.WriteLine(robot1.Y == 2);
            Console.WriteLine(robot1.Richting == 1);
            //
            robot1.Draai();
            robot1.Draai();
            robot1.Draai();
            Console.WriteLine(robot1.X == 2);
            Console.WriteLine(robot1.Y == 2);
            Console.WriteLine(robot1.Richting == 0);
            Console.ReadLine();
            //
            robot1.Stap();
            robot1.Stap();
            Console.WriteLine(robot1.X == 2);
            Console.WriteLine(robot1.Y == 4);
            Console.WriteLine(robot1.Richting == 0);
            //
            robot1.Draai();
            robot1.Draai();
            robot1.Stap();
            Console.WriteLine(robot1.X == 2);
            Console.WriteLine(robot1.Y == 1);
            Console.WriteLine(robot1.Richting == 2);
            //
            Console.ReadLine();
        }
    }
}
