using System;
using System.ComponentModel.Design;

class tabuada1
{
    public static int menu()
    {
        Console.Clear();
        var option = 0;
        Console.WriteLine("1 - Nova tabuada.");
        Console.WriteLine("2 - Sair.");

        int.TryParse(Console.ReadLine(), out option);
        if (option == 0)
            int.TryParse(Console.ReadLine(), out option);

        return option;
    }

    static void multipli()
    {
        Console.Clear();
        var multi = 0;
        Console.Write("Digite o multiplicador: ");
        int.TryParse(Console.ReadLine(), out multi);
        if (multi == 0)
            int.TryParse(Console.ReadLine(), out multi);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{multi} x {i} = {multi * i}");
        }
    }


    public static void Main(string[] args)
    {
        var option = menu();
        while (option == 2 || option == 1)
        {
            switch (option)
            {
                case 1:
                    multipli();
                    Console.Write("Press enter...");
                    Console.Read();
                    option = menu();
                    break;
                case 2:
                    Console.WriteLine("Até logo.");
                    option = 0;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }
        }
    }
}