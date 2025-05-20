using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> participantes = new List<string>();
        
        Console.Write(" Digite a quantidade máxima de participantes: ");
        int NumMaxPart = int.Parse(Console.ReadLine());

        while (participantes.Count < NumMaxPart)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            if (participantes.Contains(nome))
            {
                Console.Write("Usuário já cadastrado.");
            }
            else
            {
                participantes.Add(nome);
            }
        }
        participantes.Sort();

        Console.WriteLine("\nLista Participantes (ordenada)");
        foreach (string nome in participantes)
        {
            Console.WriteLine(nome);
        }
    }
}



