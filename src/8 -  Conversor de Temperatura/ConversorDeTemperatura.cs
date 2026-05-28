/* ## 8. Conversor de Temperatura
 * 
 * Crie um programa que solicite ao usuário que informe a temperatura em graus Celsius, 
 * em seguida, converta para `double` e calcule a temperatura em Fahrenheit. 
 * Exiba a temperatura em Fahrenheit formatada com duas casas decimais.
 * 
 * Fórmula: (0 °C × 9/5) + 32 = 32 °F
 * 
 * Saída esperada:
 * Digite a temperatura em graus Celsius: 25
 * A temperatura em Fahrenheit é: 77,00°F
 */

using System;

class ConversorDeTemperatura
{
    public static void Executar()
    {
        Console.Clear();

        double temp = 0;
        bool isSucess = false;

        while (!isSucess)
        {
            Console.WriteLine("Digite a temperatuta em graus celsios :");
            isSucess = double.TryParse(Console.ReadLine(), out temp);

            if (!isSucess)
            {
                Console.Clear();
                Console.WriteLine("Digite um numero valido");
            }
        }

        double tempFah = (temp * 9 / 5) + 32;

        Console.Clear();
        Console.WriteLine($"sua temperatura em celsius e {temp} e em Fahrenheit ela e {tempFah} ");
        Console.ReadKey();
    }
}

