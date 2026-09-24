using System;
namespace Exercise_List_08
{
    class ProgramHome
    {
        static void Main(String[] args)
        {
            string userMenuAnswer;
            bool menuDisplayVerifier = true;
            do
            {
                if (menuDisplayVerifier)
                {
                    Console.WriteLine("Atividades da lista 8 em C#");
                    Console.WriteLine("Selecione a atividade desejada -> \n" +
                        "->> 1, 2, 3, 4, 5, 6, 7, 8, 9 ou 10 para atividades \n" +
                        "->> 0 ou Sair para encerrar");
                    Console.Write("Aguardando resposta -> ");
                }
                menuDisplayVerifier = true;
                userMenuAnswer = Console.ReadLine().ToLower().Trim();
                switch (userMenuAnswer)
                {
                    case "1":
                        Exercise_01.Execute();
                        Console.Clear();
                        break;
                    case "2":
                        Exercise_02.Execute();
                        Console.Clear();
                        break;
                    case "3":
                        //Exercise_03.Execute();
                        Console.Clear();
                        break;
                    case "4":
                        //Exercise_04.Execute();
                        Console.Clear();
                        break;
                    case "5":
                        //Exercise_05.Execute();
                        Console.Clear();
                        break;
                    case "6":
                        //Exercise_06.Execute();
                        Console.Clear();
                        break;
                    case "7":
                        //Exercise_07.Execute();
                        Console.Clear();
                        break;
                    case "8":
                        //Exercise_08.Execute();
                        Console.Clear();
                        break;
                    case "9":
                        //Exercise_09.Execute();
                        Console.Clear();
                        break;
                    case "10":
                        //Exercise_10.Execute();
                        Console.Clear();
                        break;
                    case "0":
                        Console.WriteLine("Finalizando!");
                        return;
                    case "sair":
                        Console.WriteLine("Finalizando!");
                        return;
                    default:
                        Console.Write("Resposta inválida. \n" + "Tente novamente: ");
                        menuDisplayVerifier = false;
                        continue;
                }
            } while (true);
        }
    }
}
