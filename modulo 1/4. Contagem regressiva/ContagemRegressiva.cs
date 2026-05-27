/* ## 4. Contagem regressiva
 * 
 * Exiba uma contagem regressiva de 10 até 1 usando `for` 
 * e ao final exiba `"Feliz Ano Novo!"`.
 */

class ContagemRegressiva
{
    public static async Task Executar()
    {
        Console.Clear();
        Console.WriteLine("Contagem regressiva iniciada: \n");

        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"{i}");
            await Task.Delay(1000);
        }

        Console.WriteLine("Feliz Ano Novo");
        Console.Read();

    }
}

