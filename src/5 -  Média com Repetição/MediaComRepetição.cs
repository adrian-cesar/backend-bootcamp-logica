/* ## 5. Média com repetição
 * 
 * Peça ao usuário quantas notas ele quer cadastrar. 
 * Em seguida, leia cada nota em loop e exiba a média ao final. 
 * Use `for` para controlar o número de iterações.
 */

class MediaComRepeticao
{
    public static void Executar()
    {
        Console.Clear();

        double media, soma = 0;
        int quantidade = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Quantas notas deseja cadastrar no sistema? ");
            if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade > 0)
                break;

            Console.WriteLine("Digite um valor valido!");
            Console.ReadKey();
        }

        for (int i = 1; i <= quantidade; i++)
        {
            double valor;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Digite a nota {i}: ");
                if (double.TryParse(Console.ReadLine(), out valor))
                    break;

                Console.WriteLine("Digite um valor valido!");
                Console.ReadKey();
            }

            soma += valor;

            Console.Clear();
        }

        Console.WriteLine($"Sua media e: {media = soma / quantidade}");
        Console.ReadKey();

    }
}

