using System;
namespace Exercise_List_08
{
    class Exercise_02
    //Desenvolva um programa que solicite ao usuário para inserir um número
    //inteiro positivo e, em seguida, exiba todos os números pares entre 0 e o
    //número inserido.
    {
        public static void Execute()
        {
            Console.Clear();
            int userNumber;
            string numbersList;
            Console.Write("Digite um número positivo: ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out userNumber))
                {

                }
            } while (true);
        }
    }
}
