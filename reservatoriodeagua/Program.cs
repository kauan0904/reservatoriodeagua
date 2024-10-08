using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o estado da boia A (1- cheia/0- vazio)");
        int boiaA = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o estado da boia B (1- cheia/0- vazio)");
        int boiaB = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o estado da boia C (1- cheia/0- vazio)");
        int boiaC = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (boiaA == 0 && boiaB == 0 && boiaC == 0)
        {
            Console.WriteLine("Ligar torneira");
        }
        else if (boiaA == 0 && boiaB == 0 && boiaC == 1)
        {
            Console.WriteLine("Ligar torneira");
        }
        else if (boiaA == 0 && boiaB == 1 && boiaC == 0)
        {
            Console.WriteLine("ERRO!");
        }
        else if (boiaA == 0 && boiaB == 1 && boiaC == 1)
        {
            Console.WriteLine("ERRO!");
        }
        else if (boiaA == 1 && boiaB == 0 && boiaC == 0)
        {
            Console.WriteLine("Ligar torneira e bomba");
        }
        else if (boiaA == 1 && boiaB == 0 && boiaC == 1)
        {
            Console.WriteLine("Ligar bomba");
        }
        else if (boiaA == 1 && boiaB == 1 && boiaC == 0)
        {
            Console.WriteLine("Ligar bomba");
        }
        else if (boiaA == 1 && boiaB == 1 && boiaC == 1)
        {
            Console.WriteLine("Desligar torneira e bomba");
        }
    }
}
