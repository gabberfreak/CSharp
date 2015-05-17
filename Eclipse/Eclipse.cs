using System;
using System.Linq;

class Eclipse
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());

        char asteriks = '*';
        char character = '/';
        char character2 = '|';
        char bridge = '-';
        char whitespace = ' ';

        Console.WriteLine(' ' + new string(asteriks, height * 2 - 2) + new string(whitespace, height + 1)
                             + new string(asteriks, height * 2 - 2));

        for (int i = 1; i < height / 2; i++)
        {
            Console.WriteLine('*' + new string(character, height * 2 - 2) + '*' + new string(whitespace, height - 1) +
                              '*' + new string(character, height * 2 - 2) + '*');
        }
        Console.WriteLine('*' + new string(character, height * 2 - 2) + '*' + new string(bridge, height - 1) +
                              '*' + new string(character, height * 2 - 2) + '*');
        for (int i = 1; i < height / 2; i++)
        {
            Console.WriteLine('*' + new string(character, height * 2 - 2) + '*' + new string(whitespace, height - 1) +
                              '*' + new string(character, height * 2 - 2) + '*');
        }
        Console.WriteLine(' ' + new string(asteriks, height * 2 - 2) + new string(whitespace, height + 1)
                            + new string(asteriks, height * 2 - 2));
    }
}