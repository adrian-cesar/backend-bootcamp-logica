using Spectre.Console;

class Program
{
    public static async Task Main()
    {
        string escolha;

        do
        {
            AnsiConsole.Clear();

            // Título bonito
            AnsiConsole.Write(
                new FigletText("EXERCICIOS")
                .Centered()
                .Color(Color.Cyan1));

            // Painel
            var painel = new Panel(
                "[yellow]Escolha uma opção usando as setas do teclado[/]")
                .Border(BoxBorder.Double)
                .BorderColor(Color.Cyan1)
                .Padding(1, 1);

            AnsiConsole.Write(painel);

            // Menu interativo
            escolha = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("\n[green]MENU PRINCIPAL[/]")
                .PageSize(10)
                .HighlightStyle(new Style(Color.Black, Color.Cyan1))
                .AddChoices(new[]
                {
                    "1 - Tabuada",
                    "2 - Soma acumulada",
                    "3 - Validacao de entrada",
                    "4 - Contagem regressiva",
                    "5 - Media com repeticao",
                    "6 - Media aritmetica",
                    "7 - Par ou impar",
                    "8 - Conversor de temperatura",
                    "9 - Calculadora",
                    "10 - Maior e menor valor (vetor)",
                    "11 - Media da turma (vetor)",
                    "12 - Contagem de Par e Impar (Vetor)",
                    "13 - Buscar valor (Vetor)",
                    "14 - Soma da matriz (Matriz)",
                    "15 - Soma da diagonal principal",
                    "16 - Soma por linha",
                    "17 - Maior elemento e sua posicao",
                    "18 - Matriz transposta",
                    "19 - Sair"
                }));

            switch (escolha)
            {
                case "1 - Tabuada":
                    Tabuada.Executar();
                    break;

                case "2 - Soma acumulada":
                    SomaAcumulada.Executar();
                    break;

                case "3 - Validacao de entrada":
                    ValidacaoDeEntrada.Executar();
                    break;

                case "4 - Contagem regressiva":
                    await ContagemRegressiva.Executar();
                    break;

                case "5 - Media com repeticao":
                    MediaComRepeticao.Executar();
                    break;

                case "6 - Media aritmetica":
                    MediaAritmetica.Executar();
                    break;

                case "7 - Par ou impar":
                    ParOuImpar.Executar();
                    break;

                case "8 - Conversor de temperatura":
                    ConversorDeTemperatura.Executar();
                    break;

                case "9 - Calculadora":
                    Calculadora.Executar();
                    break;

                case "10 - Maior e menor valor (vetor)":
                    MaiorMenorValor.Executar();
                    break;

                case "11 - Media da turma (vetor)":
                    MediaTurma.Executar();
                    break;

                case "12 - Contagem de Par e Impar (Vetor)":
                    ContagemParImpar.Executar();
                    break;

                case "13 - Buscar valor (Vetor)":
                    BuscaDeValorVetor.Executar();
                    break;

                case "14 - Soma da matriz (Matriz)":
                    SomaDaMatriz.Executar();
                    break;

                case "15 - Soma da diagonal principal":
                    SomaDiagonalPrincipal.Executar();
                    break;

                case "16 - Soma por linha":
                    SomaPorLinha.Executar();
                    break;

                case "17 - Maior elemento e sua posicao":
                    MaiorElementoPosicao.Executar();
                    break;

                case "18 - Matriz transposta":
                    MatrizTransposta.Executar();
                    break;

                case "19 - Sair":

                    await AnsiConsole.Status()
                        .StartAsync("[yellow]Saindo do sistema...[/]", async ctx =>
                        {
                            await Task.Delay(1500);
                        });

                    break;
            }

        } while (escolha != "19 - Sair");

        // Mensagem final
        AnsiConsole.Clear();

        var sair = new Panel("[red]Programa encerrado![/]")
            .Border(BoxBorder.Rounded)
            .BorderColor(Color.Red);

        AnsiConsole.Write(sair);
    }
}