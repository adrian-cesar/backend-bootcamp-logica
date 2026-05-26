/*  Matriz transposta
Leia uma matriz e exiba a matriz transposta no console.*/

class MatrizTransposta
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

            Console.WriteLine("ERRO! Digite um valor valido maior que zero");
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

        int[,] matriz = new int[linhas, colunas];
        int maior = 0;

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

                        int tamanho = matriz[i, j].ToString().Length;

                        if (tamanho > maior)

                            maior = tamanho;
                    }

                    break;
                }

                Console.WriteLine($"ERRO! Digite os {colunas} valores validos");
                Console.WriteLine("Pressione qualquer tecla para digitar novamente.");
                Console.ReadKey();
            }
        }

        Console.Clear();
        Console.WriteLine("Sua matriz Digitada e: ");

        for (int i = 0; i < linhas; i++)
        {
            Console.Write("| ");

            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"{matriz[i, j]}".PadRight(maior + 4));
            }

            Console.WriteLine(" |");
        }

        Console.WriteLine();
        Console.WriteLine("Matriz transposta:");

        for (int i = 0; i < colunas; i++)
        {
            Console.Write("| ");

            for (int j = 0; j < linhas; j++)
            {
                Console.Write($"{matriz[j, i]}".PadRight(maior + 4));
            }

            Console.WriteLine(" |");
        }

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }
}