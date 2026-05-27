/* ## 7. Par ou Ímpar
 * 
 * Crie um programa que solicite ao usuário que digite um número, 
 * em seguida, converta para `int` e exiba no console se o número é par ou ímpar.
 * 
 * Saída esperada:
 * Digite um número: 4
 * O número 4 é par
 */

using System;

class ParOuImpar
{
    public static void Executar()
    {
        Console.Clear();
        Console.WriteLine("Digite um numero :");
        bool IsSucess = int.TryParse(Console.ReadLine(), out int num);

        if (!IsSucess)
        {
            Console.WriteLine("Digite um numero valido");
        }
        else
        {
            string resultado = num % 2 == 0 ? "par" : "impar";

            Console.WriteLine($"seu numero e {resultado}");
            Console.ReadKey();
        }
    }
}

