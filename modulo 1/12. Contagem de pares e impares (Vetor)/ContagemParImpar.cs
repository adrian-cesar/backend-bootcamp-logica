/*Contagem de pares e ímpares
Leia 12 números inteiros em um vetor e informe quantos são pares e quantos são ímpares.*/

class ContagemParImpar
{
    public static void Executar()
    {
        int quantidade;
        int[] numeros;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite quantos numeros quer armazenar: ");

            if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade > 0)
                break;

            Console.WriteLine("Digite um numero valido maior que 0!");
            Console.WriteLine("Pressione qualquer tecla para digitar novamente");
            Console.ReadKey();
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Digite os {quantidade} numeros separados por virgula: ");

            string entrada = Console.ReadLine()!;
            string[] partes = entrada
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            bool isValid = partes.Length == quantidade &&
                partes.All(x => int.TryParse(x, out _));

            if (!isValid)
            {
                Console.WriteLine($"ERRO! Digite {quantidade} valores validos.");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
                Console.ReadKey();
                continue;
            }

            numeros = partes
                .Select(x => int.Parse(x))
                .ToArray();

            break;
        }

        int qntPar = 0, qntImpar = 0;
        
        for (int i = 0; i < quantidade; i++)
        {
            if (numeros[i] %2 == 0)
            {
                qntPar ++;
            }
            else
            {
                qntImpar ++;
            }
        }

        int[] pares = new int[qntPar];
        int[] impares = new int[qntImpar];

        int indexPar = 0;
        int indexImpar = 0;

        for (int i = 0; i < quantidade; i++)
        {
            if(numeros[i] %2 == 0)
            {
                pares[indexPar] = numeros[i];
                indexPar++;
            }
            else
            {
                impares[indexImpar] = numeros[i];
                indexImpar++;
            }
        }

        Console.Clear();
        Console.WriteLine($"Voce digitou {qntPar} numeros pares, seus numeros pares sao [{String.Join(" ,", pares)}]\n");
        Console.WriteLine($"Voce digitou {qntImpar} numeros pares, seus numeros pares sao [{String.Join(" ,", impares)}]\n");
        Console.WriteLine($"Seus numeros digitados sao [{String.Join(" ,", numeros)}]\n");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu,");
        Console.ReadKey();

    }
}