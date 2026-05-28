/* ## 6. Média Aritmética
 * 
 * Crie um programa que solicite ao usuário que digite três notas, 
 * em seguida, converta cada valor para `double` 
 * e calcule a média final. Exiba a média no console formatada com duas casas decimais.
 * 
 * Saída esperada:
 * Digite a primeira nota: 7.5
 * Digite a segunda nota: 8.0
 * Digite a terceira nota: 6.5
 * A média das notas é: 7.33
 */

using System;

class MediaAritmetica
{
    public static void Executar()
    {
        Console.Clear();

        double nota1;
        double nota2;
        double nota3;

        while (true)
        {
            Console.WriteLine("Digite sua primeira nota :");
            if (double.TryParse(Console.ReadLine(), out nota1))
                break;

            Console.WriteLine("Digite um valor valido!");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
            Console.ReadKey();
            Console.Clear();
        }

        while (true)
        {
            Console.WriteLine("Digite sua segunda nota :");
            if (double.TryParse(Console.ReadLine(), out nota2))
                break;

            Console.WriteLine("Digite um valor valido!");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
            Console.ReadKey();
            Console.Clear();
        }
        

        
        while (true)
        {
            Console.WriteLine("Digite sua terceira nota :");
            if (double.TryParse(Console.ReadLine(), out nota3))
                break;

            Console.WriteLine("Digite um valor valido!");
            Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
            Console.ReadKey();
            Console.Clear();
        }

        double media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine($"Sua media e : {media}");
        Console.ReadKey();
    }
}

