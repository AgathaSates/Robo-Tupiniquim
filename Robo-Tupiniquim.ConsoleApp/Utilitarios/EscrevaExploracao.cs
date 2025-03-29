using Robo_Tupiniquim.ConsoleApp.Entidades;

namespace Robo_Tupiniquim.ConsoleApp.Utilitários;

class EscrevaExploracao
{
    static Random random = new Random();
    public static int duracao = random.Next(10, 60);
    public static int amostras = random.Next(1, 15);
    public static string[] Clima = { "Tempestade de Poeira", "Tempestade de Areia", "Auroras", "Ventos Fortes", "Nebuloso", "Chuva de Metano", "Frio Inteso" };
    public static string climaAtual = Clima[random.Next(Clima.Length)];
    public static int progresso = random.Next(1, 101);

    public static void TituloIniciodaMissao()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Colorir.EscreverEmAzul("-----------------------------------------------------------------");
        Colorir.EscreverEmAzul("                      Iniciando missão...");
        Colorir.EscreverEmAzul("-----------------------------------------------------------------");
        Thread.Sleep(1500);
        Colorir.EscreverEmVerde("Comandante, estamos prontos para iniciar uma nova missão.");
        Colorir.EscreverEmVerde("Prepare-se para desbravar o desconhecido e explorar\nos mistérios do Planeta Vermelho.");
        Colorir.EscreverEmAzul("------------------------------------------------------------------");
        Colorir.EscreverEmCiano(">> Lembre-se: as informações são separadas por 1 espaço");
        Colorir.EscreverEmAzul("------------------------------------------------------------------");
    }

    public static void PosicaoInicialRobo(string nome, int robox, int roboy, char robodirecao)
    {
        Console.WriteLine();
        Colorir.EscreverEmVerde($"-> O Robô {nome} está posicionado em: {robox} {roboy} olhando para o {robodirecao}");
        Console.WriteLine();
    }

    public static void PedirNomeRobo1()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Colorir.EscreverEmAzul("-------------------------------------------------------------------------------");
        Colorir.EscreverEmRosa(" Comandante, chegou o momento de nomear seu fiel companheiro.");
        Colorir.EscreverEmRosa(" Escolha um nome digno, que ressoe nas estrelas e nas vastas terras de Marte.");
        Colorir.EscreverEmAzul("-------------------------------------------------------------------------------");
        Colorir.EscreverEmAmareloEscuroLinha("-> Digite o nome do 1° robô: ");
    }

    public static void PedirPosicaoRobo1(string nomeRobo1) 
    {       
        Console.WriteLine();
        Colorir.EscreverEmAmareloEscuroLinha($"-> Digite a posição inicial do Robô {nomeRobo1} (x y direção(N,S,L,O)): ");
    }

    public static void PedirNomeRobo2()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Colorir.EscreverEmAzul("-------------------------------------------------------------------------------");
        Colorir.EscreverEmRosa(" Seu 2° robô também está pronto e precisa de um nome!");
        Colorir.EscreverEmRosa(" Dê um nome justo do Planeta Vermelho, algo que o acompanhará nesta jornada!");
        Colorir.EscreverEmAzul("-------------------------------------------------------------------------------");
        Colorir.EscreverEmAmareloEscuroLinha("-> Digite o nome do 2° robô: ");
    }

    public static void PedirPosicaoRobo2(string nomeRobo2)
    {    
        Console.WriteLine();
        Colorir.EscreverEmAmareloEscuroLinha($"-> Digite a posição inicial do Robô {nomeRobo2} (x y direção(N,S,L,O)): ");
    }

    public static void MensagemInicioDaMissao()
    {
        Console.WriteLine();
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Colorir.EscreverEmAzul("---------------------------------------------------------------");
        Colorir.EscreverEmAzul(" Missão iniciada! O robô começará a explorar a área designada.");
        Colorir.EscreverEmAzul("---------------------------------------------------------------");
        Thread.Sleep(800);
    }

    public static void UltrapassouArea(string nomerobo, int x, int y, char direcao)
    {
        Colorir.EscreverEmVermelho("---------------------------------------------------------------");
        Colorir.EscreverEmVermelho($"> O Robô {nomerobo} havia chegado a {x} {y} {direcao}.");
        Colorir.EscreverEmVermelho($"> Infelizmente {nomerobo} ultrapassou os limites da área de exploração");
        Thread.Sleep(1500);
        Colorir.EscreverEmVermelho($"> E Caiu em um buraco negro!\n> A missão acabou para {nomerobo}");
        Colorir.EscreverEmVermelho("> Que descanse paz...");
        Colorir.EscreverEmVermelho("---------------------------------------------------------------");
        HistoricodeExploracao.AdicionarnoHistorico($" O Robo {nomerobo} ultrapassou os limites da área de exploração\n     Ele havia chegado a {x} {y} {direcao}.");
    }

    public static void PosicaoFinalRobo(string nomerobo, int x, int y, char direcao)
    {
        Console.WriteLine();
        Colorir.EscreverEmVerde("---------------------------------------------------------------");
        Colorir.EscreverEmVerde($"> A posição final do Robô {nomerobo} é: {x} {y} {direcao}");
        Colorir.EscreverEmVerde("---------------------------------------------------------------");
        HistoricodeExploracao.AdicionarnoHistorico($" A posição final do Robo {nomerobo} foi: {x} {y} {direcao}");
    } 

    public static void StatusFinaldaMissao()
    {
        Colorir.EscreverEmAzul("          ------------------------------------------");
        Colorir.EscreverEmAzul("                   Status Final da missão");
        Colorir.EscreverEmAzul("          ------------------------------------------");
        Colorir.EscreverEmVermelho($"            Duração total: {duracao} minutos");
        Colorir.EscreverEmVerde($"            Amostras Coletadas: {amostras}");
        Colorir.EscreverEmCiano($"            Condições Climáticas: {climaAtual}");
        Colorir.EscreverEmRosa($"            Reconhecimento da Área: {progresso}% Completo");
        Colorir.EscreverEmAzul("          ------------------------------------------");
        Console.WriteLine();
        Thread.Sleep(800);
        Colorir.EscreverEmAmareloEscuroLinha("-> Pressione qualquer tecla para voltar ao menu");
    }
}
