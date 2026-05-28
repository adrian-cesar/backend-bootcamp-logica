/* Maior e menor valor:
Leia quantos números inteiros o usuario quer armazenar em um vetor. Ao final, exiba o maior valor, o menor valor e as posições de cada um.
*/

class MaiorMenorValor
{
    public static void Executar()
    {
        int quantidade;
        int[] numeros;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Digite quantos valores quer armazenar: ");
            if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade > 0)
                break;

            Console.WriteLine("Digite um valor valido maior que 0!");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
            Console.ReadKey();
        }
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Digite {quantidade} valores separados por virgula: ");

            string entrada = Console.ReadLine()!; // coloquei o "!" pois garanto que a entrada nao sera nula
            string[] validacao = entrada
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            bool valido = validacao.Length == quantidade &&
                validacao.All(x => int.TryParse(x, out _));

            if (!valido)
            {
                Console.WriteLine($"ERRO! Verifique se sao todos numeros e se sao {quantidade} valores digitados.");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
                Console.ReadKey();
                continue;
            }

            numeros = validacao
                .Select(x => int.Parse(x))
                .ToArray();

            break;
        }
          
        int numMaior = numeros[0];
        int numMenor = numeros[0];
        int posicaoMaior = 0;
        int posicaoMenor = 0;

        for (int i = 0; i < quantidade; i++)
        {
            if (numeros[i] > numMaior)
            {
                numMaior = numeros[i];
                posicaoMaior = i;
            }

            if (numeros[i] < numMenor)
            {
                numMenor = numeros[i];
                posicaoMenor = i;
            }
        }

        Console.Clear();
        Console.WriteLine($"O seu maior numero digitado e o: {numMaior}, se encontra na posicao: {posicaoMaior}");
        Console.WriteLine($"O seu menor numero digitado e o: {numMenor}, se encontra na posicao: {posicaoMenor}");
        Console.WriteLine();
        Console.WriteLine($"Seus numeros sao: [{string.Join(", ", numeros)}] ");
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
    }
}

   