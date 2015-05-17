using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Exam
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine()); // start day
        int inRow = int.Parse(Console.ReadLine()); // number of consecutive days Didko eats

        int sumM = 0; // sum of melons
        int sumW = 0; // sum of watermelons

        // the loop cycles inRow times; i is a counter
        for (int i = 0; i < inRow; i++)
        {
            // day shows the current day of the week, when it reaches 8 it's reset to 1 (Monday)
            if (day == 8)
            {
                day = 1;
            }

            // for the current day of the week add the specified number of melons and watermelons
            switch (day)
            {

                case 1:
                    sumW = sumW + 1;
                    sumM = sumM + 0;
                    break;
                case 2: sumW = sumW + 0; sumM = sumM + 2; break;
                case 3: sumW = sumW + 1; sumM = sumM + 1; break;
                case 4: sumW = sumW + 2; sumM = sumM + 0; break;
                case 5: sumW = sumW + 2; sumM = sumM + 2; break;
                case 6: sumW = sumW + 1; sumM = sumM + 2; break;
                case 7: sumW = sumW + 0; sumM = sumM + 0; break;

                default:
                    break;
            }

            // go to the next day (i is just a counter, so this isn't automatic)
            day++;



        }

        // tuka e qsno maj ko stawa
        if (sumW > sumM)
        {
            Console.WriteLine("{0} more watermelons", sumW - sumM);
        }
        else if (sumM > sumW)
        {
            Console.WriteLine("{0} more melons", sumM - sumW);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}", sumW);
        }

    }
}

