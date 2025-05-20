using System;

class Program
{
    static void Main();
    double IngressosPadraoValor = 30.00;
    double IngressosVIPValor = 60.00;
    int EstoIngrePadrao = 100;
    int EstoIngreVIP = 50;
    int VendIngrePadrao = 0;
    int VendIngreVIP = 0;

    Console.WriteLine("Ingressos padrão disponíveis: 100")
    Console.WriteLine("Ingressos VIP disponíveis: 50")

    Console.Write("Quantos ingressos padrão você deseja? ");
    int QuantIngrePadrao = int.Parse(Console.ReadLine());

    Console.Write("Quantos ingressos VIP você deseja? ");
    int QuantIngreVIP = int.Parse(Console.ReadLine());

    if (QuantIngrePadrao < EstoIngrePadrao || QuantIngreVIP < EstoIngreVIP)
    {
        Console.WriteLine("\n Não tem ingressos disponíveis!");
        Console.WriteLine($"Ingressos padrão diponíveis : {EstoIngrePadrao}");
        Console.WriteLine($"Ingressos VIP disponíveis: {EstoIngreVIP}");
    }
    else
    {
    EstoIngrePadrao -= QuantIngrePadrao;
    EstoIngreVIP -= QuantIngreVIP;
    VendIngrePadrao = QuantIngrePadrao;
    VendIngreVIP = QuantIngreVIP;

    int TotalIngreVendido = VendIngrePadrao + VendIngreVIP;   
    double ValorTotal = VendIngrePadrao + VendIngreVIP;
    int RestIngrePadrao = QuantIngrePadrao - EstoIngrePadrao;
    int RestIngreVIP = QuantIngreVIP - EstoIngreVIP;
    }
Console.WriteLine("Total vendidos: " + TotalIngreVendido);
Console.WriteLine("Total arrecadado: R$" + ValorTotal.ToString ("F2"));
Console.WriteLine("Ingressos padrão restante: " + RestIngrePadrao);
Console.WriteLine("Ingressos VIP restante: " + RestIngreVIP);
}









