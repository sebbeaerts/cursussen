using System;

namespace Oefening_6._6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seconds ?");
            int input = Convert.ToInt32(Console.ReadLine());

            //input in andere variabele steken zodat de input ongewijzigd kan worden.
            //int rest = input;

            while (input != 0)
            {
                if (input < 0)
                {
                    Console.WriteLine("Error: Only positive values are accepted !");
                }
                else
                {

                    int minuteInSeconds = 60;
                    int hourInMinutes = 60;
                    int dayInHours = 24;

                    int days = input / (dayInHours * hourInMinutes * minuteInSeconds);  //seconden delen door 86400
                    int hours = (input % (dayInHours * hourInMinutes * minuteInSeconds)) / (minuteInSeconds * hourInMinutes); //rest seconden delen door 3600
                    int minutes = ((input % (dayInHours * hourInMinutes * minuteInSeconds)) % (minuteInSeconds * hourInMinutes))/minuteInSeconds; //rest seconden delen door 60
                    int seconds = ((input % (dayInHours * hourInMinutes * minuteInSeconds)) % (minuteInSeconds * hourInMinutes)) % minuteInSeconds; //rest seconden

                    Console.WriteLine("Result:");
                    if (days != 0)
                    {
                        Console.WriteLine(days + " days");
                    }
                    if (hours != 0)
                    {
                        Console.WriteLine(hours + " hours");
                    }
                    if (minutes != 0)
                    {
                        Console.WriteLine(minutes + " minutes");
                    }
                    if (seconds != 0)
                    {
                        Console.WriteLine(seconds + " seconds");
                    }
                }

                Console.WriteLine("Seconds ?");
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("End.");
            //
            Console.ReadLine();
        }
    }
}
