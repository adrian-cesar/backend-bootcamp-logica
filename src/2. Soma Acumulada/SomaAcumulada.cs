/* ## 2. Soma acumulada
 * 
 * Leia números inteiros do usuário em loop usando `while` até que ele digite `0`. 
 * Ao final, exiba a soma de todos os números digitados.
 */

class SomaAcumulada
{
    public static void Executar()
    {
        Console.Clear();

        bool isSucess = false;
        bool sair = false;
        int num = 0;
        int soma = 0;

        while (!sair)
        {
            while (!isSucess)
            {
                Console.WriteLine("Digite um numero para ser somado ou digite 0 para sair e exibir a soma: ");
                isSucess = int.TryParse(Console.ReadLine(), out num);

                Console.Clear();

                if (!isSucess)
                {
                    Console.WriteLine("Digite um numero valido!");
                }
            }

            if (num == 0)
            {
                sair = true;
            }

            soma += num;
            isSucess = false;

            Console.Clear();
        }

        Console.WriteLine($"A soma dos numeros digitados e: {soma}");
        Console.ReadKey();
    }
}
