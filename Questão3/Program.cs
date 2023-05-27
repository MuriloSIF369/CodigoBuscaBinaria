using System;
using System.ComponentModel.Design;
using System.Numerics;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
    #region Menu
    menu:
        Console.Write("1 - Inserir um número no vetor.\n" +
                        "2 - Pesquisar um número por busca binária.\n" +
                        "3 - Pesquisar um número por busca linear.\n" +
                        "4 - Sair\n" +
                        "Opção: "); int choice = int.Parse(Console.ReadLine());
        #endregion
        while (choice != 4)
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Número à adicionar: ");
                    int numbertoinsert = int.Parse(Console.ReadLine());
                    int[] vector = { 10, 20, 30, 40, 50, 60, 70, 80, 90, numbertoinsert };
                    BubbleSortOrdanator(vector);

                    Console.Write("Aperte uma tecla para continuar...");
                    Console.ReadKey();
                    goto menu;

                case 2:
                    Console.Write("Número à pesquisar: ");
                    int numbertosearch1 = int.Parse(Console.ReadLine());
                    int[] vector2 = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
                    int index = BinarySearch(vector2, numbertosearch1);

                    if (index != -1)
                    {
                        Console.WriteLine("Elemento encontrado na posição " + index);
                    }
                    else
                    {
                        Console.WriteLine("Elemento não encontrado.");
                    }

                    Console.Write("Aperte uma tecla para continuar...");
                    Console.ReadKey();
                    goto menu;
                case 3:
                    Console.Write("Número à pesquisar: ");
                    int numbertosearch = int.Parse(Console.ReadLine());
                    int[] vector1 = { 20, 10, 30, 90, 50, 80, 10, 40, 60 };

                    BubbleSortOrdanator(vector1);
                    LinearSearch(numbertosearch, vector1);

                    Console.Write("Aperte uma tecla para continuar...");
                    Console.ReadKey();
                    goto menu;

            }
        }

    }
    static void BubbleSortOrdanator(int[] vector)
    {
        int width = vector.Length;

        for (int i = 0; i < width - 1; i++)
        {
            for (int j = 0; j < width - i - 1; j++)
            {
                if (vector[j] > vector[j + 1])
                {
                    int switcher = vector[j];
                    vector[j] = vector[j + 1];
                    vector[j + 1] = switcher;
                }
            }
        }
        Console.WriteLine("Vetor ordenado:");
        for (int i = 0; i < width; i++)
        {
            Console.WriteLine(vector[i]);
        }
    }

    static int LinearSearch(int target, int[] vector)
    {
        int counter = 0;
        int width = vector.Length;
        for (int i = 0; i < width; i++)
        {
            counter++;
            if (vector[i] == target)
            {
                Console.WriteLine($"Número {target}, na posição {i}");
                Console.WriteLine("Feitas {0} análises", counter);
                return i;
            }
        }
        return -1;
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}