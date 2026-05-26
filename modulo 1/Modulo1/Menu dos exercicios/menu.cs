class Program
{
    public static async Task Main()
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("==== Menu de exercicios ====");
            Console.WriteLine("1 - Tabuada");
            Console.WriteLine("2 - Soma acumulada");
            Console.WriteLine("3 - Validacao de entrada");
            Console.WriteLine("4 - Contagem regressiva");
            Console.WriteLine("5 - Media com repeticao");
            Console.WriteLine("6 - Media aritmetica");
            Console.WriteLine("7 - Par ou impar");
            Console.WriteLine("8 - Conversor de temperatura");
            Console.WriteLine("9 - Calculadora");
            Console.WriteLine("10 - Maior e menor valor (vetor)");
            Console.WriteLine("11 - Media da turma (vetor)");
            Console.WriteLine("12 - Contagem de Par e Impar (Vetor)");
            Console.WriteLine("13 - Buscar valor (Vetor)");
            Console.WriteLine("14 - Soma da matriz (Matriz)");
            Console.WriteLine("15 - Soma da diagonal principal (Matriz)");
            Console.WriteLine("16 - Soma por linha (Matriz)");
            Console.WriteLine("17 - Maior elemento e sua posição (Matriz)");
            Console.WriteLine("18 - Matriz transposta (Matriz)");
            Console.WriteLine("19 - Sair \n");
            Console.WriteLine("Escolha: ");

            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao)
            {
                case 1:
                    Tabuada.Executar();
                    break;

                case 2:
                    SomaAcumulada.Executar();
                    break;

                case 3:
                    ValidacaoDeEntrada.Executar();
                    break;

                case 4:
                    await ContagemRegressiva.Executar();
                    break;

                case 5:
                    MediaComRepeticao.Executar();
                    break;

                case 6:
                    MediaAritmetica.Executar();
                    break;

                case 7:
                    ParOuImpar.Executar();
                    break;

                case 8:
                    ConversorDeTemperatura.Executar();
                    break;

                case 9:
                    Calculadora.Executar();
                    break;

                case 10:
                    MaiorMenorValor.Executar();
                    break;

                case 11:
                    MediaTurma.Executar();
                    break;

                case 12:
                    ContagemParImpar.Executar();
                    break;

                case 13:
                    BuscaDeValorVetor.Executar();
                    break;

                case 14:
                    SomaDaMatriz.Executar();
                    break;

                case 15:
                    SomaDiagonalPrincipal.Executar();
                    break;

                case 16:
                    SomaPorLinha.Executar();
                    break;

                case 17:
                    MaiorElementoPosicao.Executar();
                    break;

                case 18:
                    MatrizTransposta.Executar();
                    break;

                case 19:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opcao invalida!");
                    break;
            }

        } while (opcao != 19);
    }
}