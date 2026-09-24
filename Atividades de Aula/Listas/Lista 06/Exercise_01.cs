using System;
using System.Text.RegularExpressions;
namespace Exercise_List_08
{
    class Exercise_01
    //Crie um programa que exiba todos os números pares entre 0 e 100.
    {
        public static void Execute()
        {
            Console.Clear();
            int maxNumber = 100;
            string result = "";
            Console.Write("Aperte Enter para iniciar -> ");
            Console.ReadLine();
            Console.WriteLine($"Os números pares de 0 a {maxNumber} são: ");
            for (int i = 0; i <= maxNumber; i += 2)
            {
                if (i % 2 == 0)
                {
                    result += i % 10 != 0 || i == 0 ? $"{i}, " : $"{i}, \n";
                }
            }
            result = Regex.Replace(result, ", $", ".");
            Console.WriteLine(result);
            Console.Write("Aperte Enter para retornar -> ");
            Console.ReadLine();
        }
    }
}
