/* ## 1. Tabuada
 * 
 * Peça ao usuário um número inteiro e exiba a tabuada dele de 1 a 10 usando `for`.
 */

class Tabuada
{
    public static void Executar()
    {
        Console.Clear();

        int num, opcao;
        bool sair = false;

        while (!sair)
        {
            while (true)
            {
                Console.WriteLine("Digite um numero para saber a tabuada do 1 - 10 :");

                if (int.TryParse(Console.ReadLine(), out num))
                    break;

                Console.WriteLine("Digite um numero valido!");
                Console.ReadKey();
                Console.Clear(); 
            }


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }

            while (true)
            {
                Console.WriteLine("\n 1. Digitar outro numero.\n 2. sair.");

                if (int.TryParse(Console.ReadLine(), out opcao) && (opcao == 1 || opcao == 2) )
                    break;

                Console.WriteLine("Digite uma opcao valida!");
                Console.ReadKey();
                Console.Clear();
            }
            

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Progama finalizado...");
                    Thread.Sleep(1000);
                    sair = true;
                    break;
            }
        }
    }
}
