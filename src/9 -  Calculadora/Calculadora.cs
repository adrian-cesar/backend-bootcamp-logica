/* ## 9. Calculadora
 * 
 * Uma calculadora simples que realiza as operações básicas: soma, subtração, multiplicação e divisão.
 */

using System;
using System.Net.Http.Headers;

class Calculadora
{
    public static void Executar()
    {
        Console.Clear();

        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("Digite a opcao desejada \n");

            Console.WriteLine("1. somar +");
            Console.WriteLine("2. subtrair -");
            Console.WriteLine("3. multiplicar X");
            Console.WriteLine("4. dividir /");
            Console.WriteLine("5. sair \n");

            bool IsSucess = int.TryParse(Console.ReadLine(), out int opcao);

            if (!IsSucess)
            {
                Console.WriteLine("Digite uma opcao valida!");
            }

            Console.Clear();

            switch (opcao)
            {
                case 1:

                    bool isSucess2 = false;
                    int numSoma1 = 0;

                    while (!isSucess2)
                    {
                        Console.WriteLine("Digite o primeiro numero :");
                        isSucess2 = int.TryParse(Console.ReadLine(), out numSoma1);

                        Console.Clear();

                        if (!isSucess2)
                        {
                            Console.WriteLine("Digite um numero valido!");
                        }
                    }

                    Console.Clear();

                    bool isSucess3 = false;
                    int numSoma2 = 0;

                    while (!isSucess3)
                    {
                        Console.WriteLine("Digite o segundo numero :");
                        isSucess3 = int.TryParse(Console.ReadLine(), out numSoma2);

                        Console.Clear();

                        if (!isSucess3)
                        {
                            Console.WriteLine("Digite um numero valido!");
                        }
                    }

                    Console.Clear();

                    int resultadoSoma;

                    Console.WriteLine($"{numSoma1} + {numSoma2} = {resultadoSoma = numSoma1 + numSoma2}");

                    break;

                case 2:

                    bool isSucess4 = false;
                    int numSub1 = 0;

                    while (!isSucess4)
                    {
                        Console.WriteLine("Digite o primeiro numero :");
                        isSucess4 = int.TryParse(Console.ReadLine(), out numSub1);

                        Console.Clear();

                        if (!isSucess4)
                        {
                            Console.WriteLine("Digite um numero valido!");
                        }
                    }

                    Console.Clear();

                    bool isSucess5 = false;
                    int numSub2 = 0;

                    while (!isSucess5)
                    {
                        Console.WriteLine("Digite o segundo numero :");
                        isSucess5 = int.TryParse(Console.ReadLine(), out numSub2);

                        Console.Clear();

                        if (!isSucess5)
                        {
                            Console.WriteLine("Digite um numero valido!");
                        }
                    }

                    Console.Clear();

                    int resultadoSub;

                    Console.WriteLine($"{numSub1} - {numSub2} = {resultadoSub = numSub1 - numSub2}");

                    break;

                case 3:

                    bool isSucess6 = false;
                    int numMult1 = 0;

                    while (!isSucess6)
                    {
                        Console.WriteLine("Digite o primeiro numero: ");
                        isSucess6 = int.TryParse(Console.ReadLine(), out numMult1);

                        Console.Clear();

                        if (!isSucess6)
                        {
                            Console.WriteLine("Digite um numero valido!");
                        }
                    }

                    Console.Clear();

                    bool isSucess7 = false;
                    int numMult2 = 0;

                    while (!isSucess7)
                    {
                        Console.WriteLine("Digite o segundo numero: ");
                        isSucess7 = int.TryParse(Console.ReadLine(), out numMult2);

                        Console.Clear();

                        if (!isSucess7)
                        {
                            Console.WriteLine("Digite um numero valido!");
                        }
                    }

                    Console.Clear();

                    int resultadoMult;

                    Console.WriteLine($"{numMult1} X {numMult2} = {resultadoMult = numMult1 * numMult2}");

                    break;

                case 4:

                    bool isSucess8 = false;
                    int numDiv1 = 0;

                    while (!isSucess8)
                    {

                        Console.WriteLine("Digite o primeiro numero :");
                        isSucess8 = int.TryParse(Console.ReadLine(), out numDiv1);

                        Console.Clear();

                        if (!isSucess8)
                        {
                            Console.WriteLine("Digite um numero valido!");
                        }
                    }

                    Console.Clear();

                    bool isSucess9 = false;
                    int numDiv2 = 0;

                    while (!isSucess9)
                    {
                        Console.WriteLine("Digite o segundo numero :");
                        isSucess9 = int.TryParse(Console.ReadLine(), out numDiv2);

                        Console.Clear();

                        if (!isSucess9)
                        {
                            Console.WriteLine("Digite um numero valido!");
                        }
                    }

                    Console.Clear();

                    int resultadoDiv;

                    Console.WriteLine($"{numDiv1} / {numDiv2} = {resultadoDiv = numDiv1 / numDiv2}");

                    break;

                case 5:

                    Console.WriteLine("Programa finalizado....");
                    Thread.Sleep(1000);
                    sair = true;

                    break;

                default:

                    Console.WriteLine("Digite uma opcao valida!");
                    break;
            }
        }
    }
}

