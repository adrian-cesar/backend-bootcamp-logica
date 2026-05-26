/*  Soma por linha
Leia uma matriz e exiba a soma de cada linha separadamente.  */

class SomaPorLinha
{
    public static void Executar()
    {
        int linhas, colunas;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite quantas linhas tera sua matriz: ");

            if (int.TryParse(Console.ReadLine(), out linhas) && linhas > 0)
                break;

            Console.WriteLine("ERRO! Digite um valor valido maior que 0");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
            Console.ReadKey();
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite quantas colunas tera sua matriz: ");

            if (int.TryParse(Console.ReadLine(), out colunas) && colunas > 0)
                break;

            Console.WriteLine("ERRO! Digite um valor valido maior que 0");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
            Console.ReadKey();
        }

        int[,] matriz = new int [linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Digite os {colunas} valores da linha {i + 1} da sua matriz separado por espaço: ");

                string[] valores = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                bool valido = valores.Length == colunas && valores.All(x => int.TryParse(x, out _));

                if (valido)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        matriz[i, j] = int.Parse(valores[j]);
                    }

                    break;
                }

                Console.WriteLine($"ERRO! Digite os {colunas} valores validos");
                Console.WriteLine("Pressione qualquer tecla para digitar novamente.");
                Console.ReadKey();
            }
        }

        Console.Clear();

        for (int i = 0; i < linhas; i++)
        {
            int somaDaLinha = 0;

            Console.Write($"Linha {i + 1}: ");

            for (int j = 0; j < colunas; j++)
            {
                somaDaLinha += matriz[i, j];
                
                if (j == 0)
                    Console.Write($"{matriz[i,j]}");
                else
                    Console.Write($" + {matriz[i, j]}");
            }

            Console.WriteLine($" = {somaDaLinha}");
            Console.WriteLine();
        }

        Console.WriteLine("Sua matriz Digitada e: ");

        for (int i = 0; i < linhas; i++)
        {
            Console.Write("|");

            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"{matriz[i, j], 4}");
            }

            Console.WriteLine(" |");
        }

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }
}