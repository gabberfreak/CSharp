using System;
using System.Linq;



class StudentCables
{
    static void Main()
    {
        int cables = int.Parse(Console.ReadLine());

        int sumOfCables = 0;
        int countCables = 0;

        for (int i = 0; i < cables; i++)
        {
            int cableLength = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();
            if (measure == "meters")
            {
                cableLength = cableLength * 100;
                sumOfCables += cableLength;
                countCables++;
            }
            if (cableLength < 20 && measure != "meters")
            {
                cableLength = 0;
            }
            if (measure == "centimeters" && cableLength >= 20)
            {
                sumOfCables += cableLength;
                countCables++;
            }

        }
        sumOfCables -= 3 * (countCables - 1);

        int leftCables = (sumOfCables / 504);
        int remainder = sumOfCables % 504;

        Console.WriteLine(leftCables);
        Console.WriteLine(remainder);
    }
}