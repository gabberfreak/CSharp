﻿using System;
using System.Numerics;


class TestingIssues
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Колко числа ще има в списъка? ");
        // Потребителят въвежда броя числа, които ще запазим в масив
        int reps = int.Parse(Console.ReadLine()); // Convert.ToInt32(Console.ReadLine());


        // декларираме масива, където ще запазваме числата; масивът ще съдъжа посоченият брой елементи
        // и числата в него ще са от тип float
        float[] listOfNumbers = new float[reps];

        // В цикъл, който ще мине reps брой пъти, искаме от потребителя да вкара едно релно число и това число го 
        // запзваме в масива
        for (int i = 0; i < reps; i++)
        {
            Console.Write("Число {0} в списъка е: ", i + 1);
            listOfNumbers[i] = Convert.ToSingle(Console.ReadLine()); // float.Parse(Console.ReadLine());
        }

        Console.Write("Въведете число, за да проверите дали е в списъка. Напишете \"end\", за да спрете въвеждането на числа: ");

        // потребителят въвежда вход - или ще е число, или "end"
        string input = Console.ReadLine();

        // ако не е въвел командата "end" влизаме в цикъла и излизаме когато въведе "end", междувременно той въвежда числа
        while (input != "end")
        {
            // потребителят не е въвел "end", значи е въвел число
            // конвертираме входа в число
            float number = float.Parse(input); // Convert.ToSingle(input);

            // В цикъл минаваме през списъка от числа и проверяваме всеки елемент дали е равен на въведеното от
            // потребителя число

            // булева променлива, която казва дали сме намерили числото в списъка; по начало е false, тъй като не сме
            // започнали проверката все още
            bool found = false;

            for (int i = 0; i < reps; i++)
            {
                // bool found = false; - променлива, която декларираш в тялото на цикъл
                // съществува само в тялото му и не може да се ползва извън него

                // ако намерим числото в списъка
                if (listOfNumbers[i] == number)
                {
                    Console.WriteLine("Числото съществува в списъка."); // изписваме, че съществува
                    found = true; // променяме булевата променлива, т.е. намерили сме числото
                    break; // излизаме от текущия цикъл
                    // ако намерим числото в списъка спираме проверката (може това число повече от веднъж 
                    // да го има, но нас ни интересува не колко пъти го има, а дали го има въобще)
                }
            }

            // след като сме проверили всички числа от масива, ако все още булевата променлива има стойност false,
            // значи числото го няма в масива
            if (found == false)
            {
                Console.WriteLine("Числото не съществува в списъка.");
            }

            Console.Write("Въведете следващото число: ");
            input = Console.ReadLine();
        }
    }
}