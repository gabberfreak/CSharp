using System;
using System.Collections.Generic;
using System.Linq;

class HalfSum
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n * 2];

        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length / 2; i++)
        {
            sum1 = sum1 + numbers[i];
        }
        for (int i = numbers.Length / 2; i < numbers.Length; i++)
        {
            sum2 = sum2 + numbers[i];
        }
        if (sum1 == sum2)
        {
            Console.WriteLine("Yes, sum={0}", sum1);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sum1 - sum2));
        }
    }
}