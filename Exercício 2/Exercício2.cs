
    double IngressosPadraoValor = 30.00;
    double IngressosVIPValor = 60.00;
    int EstoIngrePadrao = 100;
    int EstoIngreVIP = 50;
    double VendIngrePadrao = 0;
    double VendIngreVIP = 0;
    int QuantIngrePadrao = 0;
    int QuantIngreVIP = 0;

Console.WriteLine("Ingressos padrão disponíveis: 100");
Console.WriteLine("Ingressos VIP disponíveis: 50");

    Console.Write("Quantos ingressos padrão você deseja? ");
    QuantIngrePadrao = int.Parse(Console.ReadLine());

    Console.Write("Quantos ingressos VIP você deseja? ");
    QuantIngreVIP = int.Parse(Console.ReadLine());

if (QuantIngrePadrao > EstoIngrePadrao || QuantIngreVIP > EstoIngreVIP)
{
    Console.WriteLine("\n Não tem ingressos disponíveis!");
    Console.WriteLine($"Ingressos padrão diponíveis : {EstoIngrePadrao}");
    Console.WriteLine($"Ingressos VIP disponíveis: {EstoIngreVIP}");
}
else
{
    EstoIngrePadrao -= QuantIngrePadrao;
    EstoIngreVIP -= QuantIngreVIP;
    VendIngrePadrao = QuantIngrePadrao * IngressosPadraoValor;
    VendIngreVIP = QuantIngreVIP * IngressosVIPValor;
}
    int TotalIngreVendido = QuantIngrePadrao + QuantIngreVIP;   
    double ValorTotal = VendIngrePadrao + VendIngreVIP;

    
Console.WriteLine("Total vendidos: " + TotalIngreVendido);
Console.WriteLine("Total arrecadado: R$" + ValorTotal.ToString ("F2"));
Console.WriteLine("Ingressos padrão restante: " + EstoIngrePadrao);
Console.WriteLine("Ingressos VIP restante: " + EstoIngreVIP);










