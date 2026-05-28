/*Média da turma
Peça ao usuário quantas notas deseja inserir. Leia as notas em um vetor de double e exiba a média final com duas casas decimais.*/

class MediaTurma
{
    public static void Executar()
    {
        Console.Clear();

        int quantNotas;
        double[] notas;
        double media, somaNotas = 0;

        while (true)
        {
            Console.WriteLine("Digite quantas notas quer inserir: ");
            if (int.TryParse(Console.ReadLine(), out quantNotas) && quantNotas > 0)
                break;

            Console.WriteLine("ERRO! Digite um valor valido maior que 0!");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
            Console.ReadKey();
            Console.Clear();
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Digite as {quantNotas} notas separadas por ' - ': ");

            string entrada = Console.ReadLine()!;
            string[] partes = entrada
                .Split('-')
                .Select(x => x.Trim())
                .ToArray();

            bool valido = partes.Length == quantNotas &&
                partes.All(x => double.TryParse(x, out _));

            if (!valido)
            {
                Console.WriteLine($"ERRO! Verifique se sao todos numeros e se sao {quantNotas} notas digitadas.");
                Console.WriteLine("Pressione qualquer tecla para digitar novamente as notas.");
                Console.ReadKey();
                continue;
            }

            notas = partes
                .Select(x => double.Parse(x))
                .ToArray();

            break;
        }

        for (int i = 0; i < quantNotas; i++)
        {
            somaNotas += notas[i];
        }

        media = somaNotas / quantNotas;

        Console.Clear();
        Console.WriteLine($"A media da turma e: {media}");
        Console.WriteLine();
        Console.WriteLine($"As notas da turma sao [{string.Join(" - ", notas)}]");
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }
}