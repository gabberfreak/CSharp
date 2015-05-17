using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PandaScotlandFlag
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        char currentChar = 'A';

        // Upper half of flag
        for (int i = 0; i < size / 2; i++)
        {
            int outerTilde = i;
            int innerSymbols = size - 2 - 2 * i;
            char char1 = currentChar;
            char char2 = (char)(currentChar + 1);
            Console.WriteLine("{0}{1}{2}{3}{0}", new string('~', outerTilde), char1, new string('#', innerSymbols), char2);

            currentChar = (char)(currentChar + 2);

            if (char2 == 'Z')
            {
                currentChar = 'A';
            }
        }

        // Middle of flag
        Console.WriteLine("{0}{1}{0}", new string('-', size / 2), currentChar);
        currentChar = (char)(currentChar + 1);


        // Bottom half of flag
        for (int i = 0; i < size / 2; i++)
        {
            if (currentChar == (char)('Z' + 2))
            {
                currentChar = 'B';
            }

            char char1 = currentChar;

            char char2 = (char)(currentChar + 1);

            if (char1 == 'Z')
            {
                char2 = 'A';
            }


            int outerTilde = (size - 3) / 2 - i;
            int innerSymbols = 1 + 2 * i;
            Console.WriteLine("{0}{1}{2}{3}{0}", new string('~', outerTilde), char1, new string('#', innerSymbols), char2);

            currentChar = (char)(currentChar + 2);


        }

    }
}
