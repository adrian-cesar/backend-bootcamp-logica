/* Busca de valor no vetor:
Leia quantos números inteiros o usuario quer armazenar em um vetor.
Depois, leia um número para busca.
Ao final, informe se o número existe no vetor e em quais posições ele aparece.
*/

class BuscaDeValorVetor
{
    public static void Executar()
    {
        int[] numrs;
        int qnt, numrBusca;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite a quantidade de numeros que quer armazenar: ");

            if (int.TryParse(Console.ReadLine(), out qnt) && qnt > 0)
                break;

            Console.WriteLine("ERRO! Digite um valor valido maior que 0");
            Console.WriteLine("Pressione qualquer tecla para digitar novamente.");
            Console.ReadKey();
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Digite os {qnt} numeros separados por virgula: ");

            string entrada = Console.ReadLine()!;
            string[] partes = entrada
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            bool isValid = partes.Length == qnt &&
                partes.All(x => int.TryParse(x, out _));

            if (!isValid)
            {
                Console.WriteLine($"ERRO! Digite {qnt} numeros validos.");
                Console.WriteLine("Pressione qualquer tecla para digitar novamente");
                Console.ReadKey();
                continue;
            }

            numrs = partes
                .Select(x => int.Parse(x))
                .ToArray();

            break;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite o numero que deseja buscar no vetor: ");

            if(!int.TryParse(Console.ReadLine(),out numrBusca))
            {
                Console.WriteLine("ERRO! Digite um numero valido");
                Console.WriteLine("Pressione qualquer tecla para digitar novamente");
                Console.ReadKey();
                continue;
            }

            bool primeiro = true;
            bool encontrado = false;

            for (int i = 0; i < qnt; i++)
            {
                if (numrBusca == numrs[i])
                {
                   if (!encontrado)
                    {
                        Console.Clear();
                        Console.Write($"O numero {numrBusca} existe no vetor e se encontra nas posicoes: ");
                    }

                    if (!primeiro)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(i + 1);

                    primeiro = false;
                    encontrado = true;
                }
            }

            if(!encontrado)
            {
                Console.WriteLine("ERRO! O numero digitado nao existe no vetor");
                Console.WriteLine("Pressione qualquer tecla para buscar outro numero");
                Console.ReadKey();
                continue;
            }

            break;
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Seu vetor digitado e: [{string.Join(", ", numrs)}]\n");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
    }
}