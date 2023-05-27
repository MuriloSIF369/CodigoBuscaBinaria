using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        string[] nomes = { "Alface", "Caramelo", "Escova", "Mesa", "Motor", "Salada", "Tigre" };

        Console.Write("Pesquisa de palavra: ");
        string pesquisa = Console.ReadLine();

        int resultado = BuscaBinaria(nomes, pesquisa);

        if (resultado >= 0)
        {
            Console.WriteLine($"Palavra encontrada na posição {resultado + 1}.");
        }
        else
        {
            Console.WriteLine("A palavra não está na lista.");
        }
    }

    static int BuscaBinaria(string[] nomes, string pesquisa)
    {
        int esquerda = 0;
        int direita = nomes.Length - 1;

        while (esquerda <= direita)
        {
            int meio = (esquerda + direita) / 2;
            int comparador = pesquisa.CompareTo(nomes[meio]);

            if (comparador == 0)
            {
                return meio;
            }
            else if (comparador < 0)
            {
                direita = meio - 1;
            }
            else
            {
                esquerda = meio + 1;
            }
        }
        return -1;
    }
}