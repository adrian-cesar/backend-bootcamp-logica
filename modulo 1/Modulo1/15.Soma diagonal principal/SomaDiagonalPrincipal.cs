/*Diagonal principal

Peca a o usuario o tamanho de uma matriz, leia e mostre apenas os elementos da diagonal principal, além da soma desses elementos.
+*/

class SomaDiagonalPrincipal
{
    public static void Executar()
    {
        int linhas, colunas, somaDaMatriz = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite quantas linhas tera sua matriz: ");

            if (int.TryParse(Console.ReadLine(), out linhas) && linhas > 0)
                    break;

            Console.WriteLine("ERRO! Digite um valor valido maior que 0");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente");
            Console.ReadKey();
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite quantas colunas tera sua matriz: ");

            if (int.TryParse(Console.ReadLine(), out colunas) && colunas > 0)
                break;

            Console.WriteLine("ERRO! Digite um valor valido maior que 0");
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }

        int[,] matriz = new int [linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Digite os {colunas} valores da linha {i + 1} separados por espaço: ");

                string[] valores = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                bool valido = valores.Length == colunas && valores.All(x => int.TryParse(x, out _));

                if (valido)
                {
                    for (int j = 0;j < colunas; j++)
                    {
                        matriz[i, j] = int.Parse(valores[j]);
                    }

                    break;
                }

                Console.WriteLine($"ERRO! Digite os {colunas} valores validos");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente");
                Console.ReadKey();
            }
        }

        int limite = Math.Min(matriz.GetLength(0), matriz.GetLength(1));

        for (int i = 0; i < limite; i++)
        {
            somaDaMatriz += matriz[i, i];
        }

        Console.Clear();
        Console.WriteLine($"A soma da diagonal principal da sua matriz e = {somaDaMatriz}");
        Console.WriteLine("A diagonal principal e: ");
        Console.WriteLine();

        int maior = 0;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                int tamanho = matriz[i, j].ToString().Length;

                if (tamanho > maior)

                    maior = tamanho;
            }
        }

        for (int i = 0; i < linhas; i++)
        {
            Console.Write("| ");

            for (int j = 0; j < colunas; j++)
            {
                string valor;

                if (i == j)

                    valor = $"[{matriz[i, j]}]";
                else
                    valor = matriz[i,j].ToString();

                Console.Write(valor.PadRight(maior + 4));
            }

            Console.WriteLine(" |");
        }

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}