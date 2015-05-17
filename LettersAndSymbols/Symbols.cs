using System;

public class LettersSymbolsAndNumbers
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int sumOfLetters = 0;
        int sumOfNumbers = 0;
        int sumOfSymbols = 0;

        for (int i = 0; i < N; i++)
        {
            // Взимам входа, не го променям по никакъв начин
            string currentString = Console.ReadLine();

            // В цикъл минавам през всеки символ от низа
            for (int j = 0; j < currentString.Length; j++)
            {
                char currentChar = currentString[j]; // хващам текущия символ

                // между 48 и 57 в ASCII са цифрите
                if (currentChar >= 48 && currentChar <= 57)
                {
                    sumOfNumbers += (currentChar - 48) * 20; // currentChar - 48 дава като резултат самата цифра
                    // умножавам по 20 и добавям към сумата на цифрите
                }

                    // авторът предварително беше махнал тия whitespaces, аз ги разписах всичките, те и в условието са посочени кои са
                else if (currentChar == ' ' || currentChar == '\t' || currentChar == '\r' || currentChar == '\n')
                {
                    continue; // ако символът е whitespace, командата continue казвана цикъла директно да премине към следващото завъртане
                    /// т.е. като види continue не изпълнава повече код, а отива горе, увеличава брояча, в случая j и продължава нататък
                }

                    // това са буквите А-Z, главни
                else if (currentChar >= 65 && currentChar <= 90)
                {
                    sumOfLetters += (currentChar - 64) * 10;
                    // буквата А главно е с номер 65. currenChar - 64 е еквивалентно на currentChar - 65 + 1,или както беше 
                    // в авторското решение: currentChar - 'A' + 1;
                }

                    // това са малките букви a-z; аналогично с главните
                // ако в началото бях ползвал ToUpper() или ToLower(), една от тия две проверки за буквите щеше да отпадне
                else if (currentChar >= 97 && currentChar <= 122)
                {
                    sumOfLetters += (currentChar - 96) * 10;
                }

                    // всичко що не е буква, цифра или whitespace е символ
                else
                {
                    sumOfSymbols += 200;
                }
            }
        }

        Console.WriteLine(sumOfLetters);
        Console.WriteLine(sumOfNumbers);
        Console.WriteLine(sumOfSymbols);
    }
}
