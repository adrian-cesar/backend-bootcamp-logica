/*Soma total da matriz
Crie uma matriz 3x3, leia os valores digitados pelo usuário e exiba a soma de todos os elementos.*/

class SomaDaMatriz
{
    public static void Executar()
    {
        int linhas, colunas, soma = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite quantas linhas tera sua matriz: ");

            if (int.TryParse(Console.ReadLine(), out linhas))
                break;

            Console.WriteLine("ERRO! Digite um valor valido");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente");
            Console.ReadKey();
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite quantas colunas tera sua matriz: ");

            if (int.TryParse(Console.ReadLine(), out colunas))
                break;

            Console.WriteLine("ERRO! Digite um valor valido");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente");
            Console.ReadKey();
        }

        int[,] matriz = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Digite os {colunas} valores da linha {i} separados por espaço");

                string[] valores = Console.ReadLine()!.Split(' ');

                bool valido = valores.Length == colunas && valores.All(x => int.TryParse(x, out _));

                if (valido)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        matriz[i,j] = int.Parse(valores[j]);
                    }

                    break;
                }

                Console.WriteLine("ERRO! Digite apenas numeros validos");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente");
                Console.ReadKey();
            } 
        }

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma += matriz[i, j];
            }
        }

        Console.Clear();
        Console.WriteLine($"A soma da sua matriz e igual a: {soma}");
        Console.WriteLine("Sua matriz e: ");

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.Write("[");

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"{matriz[i, j],4}");
            }

            Console.WriteLine("]");
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
    }
}