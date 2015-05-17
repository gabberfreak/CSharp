using System;
using System.Collections.Generic;
using System.Linq;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        double hometown = double.Parse(Console.ReadLine());

        double playsInHometown = hometown;
        double playsInHometownCounter = 48 - hometown;
        double playsInNormalWeekend = playsInHometownCounter * 3 / 4;
        double playInHolidays = holidays * 2 / 3;
        double totalPlays = playsInHometown + playsInNormalWeekend + playInHolidays;


        if (year == "leap")
        {
            double leapPlays = totalPlays * 0.15;
            Console.WriteLine(Math.Floor(totalPlays + leapPlays));
        }
        else
        {
            Console.WriteLine(Math.Floor(totalPlays));
        }
    }
}