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
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("                      Iniciando missão...");
        Console.WriteLine("-----------------------------------------------------------------");
        Thread.Sleep(1500);
        Console.WriteLine("Comandante, estamos prontos para iniciar uma nova missão.");
        Console.WriteLine("Prepare-se para desbravar o desconhecido e explorar\nos mistérios do Planeta Vermelho.");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("Forneça as informações para configurar a missão");
        Console.WriteLine("Lembre-se: as informaçoes são separadas por espaço");
        Console.WriteLine("------------------------------------------------------------------");
    }

    public static void PosicaoInicialRobo(string nome, int robox, int roboy, char robodirecao)
    {
        Console.WriteLine();
        Console.WriteLine($"-> O Robô {nome} está posicionado em: ({robox} {roboy}) olhando para o {robodirecao}");
        Console.WriteLine();
    }

    public static void PedirNomeRobo1()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.WriteLine(" Comandante, chegou o momento de nomear seu fiel companheiro.");
        Console.WriteLine(" Escolha um nome digno, que ressoe nas estrelas e nas vastas terras de Marte.");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.Write("-> Digite o nome do 1° robô: ");
    }

    public static void PedirPosicaoRobo1(string nomeRobo1) 
    {
        
        Console.WriteLine();
        Console.Write($"-> Digite a posição inicial do Robô {nomeRobo1} (x y direção): ");
    }

    public static void PedirNomeRobo2()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.WriteLine(" Seu 2° robô também está pronto e precisa de um nome!");
        Console.WriteLine(" Dê um nome justo do Planeta Vermelho, algo que o acompanhará nesta jornada!");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.Write("-> Digite o nome do 2° robô: ");
    }

    public static void PedirPosicaoRobo2(string nomeRobo2)
    {
        
        Console.WriteLine();
        Console.Write($"-> Digite a posição inicial do {nomeRobo2} (x y direção): ");
    }

    public static void MensagemInicioDaMissao()
    {
        Console.WriteLine();
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine(" Missão iniciada! O robô começará a explorar a área designada.");
        Console.WriteLine("---------------------------------------------------------------");
        Thread.Sleep(800);
    }

    public static void UltrapassouArea(string nomerobo)
    {
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine($"> O Robô {nomerobo} ultrapassou os limites da área de exploração");
        Thread.Sleep(1500);
        Console.WriteLine($"> E Caiu em um buraco negro!\n> A missão acabou para {nomerobo}");
        Console.WriteLine("> Que descanse paz...");
        Console.WriteLine("---------------------------------------------------------------");
        HistoricodeExploracao.AdicionarnoHistorico($" O Robo {nomerobo} ultrapassou os limites da área de exploração.");
    }

    public static void PosicaoFinalRobo(string nomerobo, int x, int y, char direcao)
    {
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine($"> A posição final do Robô {nomerobo} é: {x} {y} {direcao}");
        Console.WriteLine("---------------------------------------------------------------");
        HistoricodeExploracao.AdicionarnoHistorico($" A posição final do Robo {nomerobo} foi: {x} {y} {direcao}");
    }

    

    public static void StatusFinaldaMissao()
    {
        Console.WriteLine("          ------------------------------------------");
        Console.WriteLine("                   Status Final da missão");
        Console.WriteLine("          ------------------------------------------");
        Console.WriteLine($"            Duração total: {duracao} minutos");
        Console.WriteLine($"            Amostras Coletadas: {amostras}");
        Console.WriteLine($"            Condições Climáticas: {climaAtual}");
        Console.WriteLine($"            Reconhecimento da Área: {progresso}% Completo");
        Console.WriteLine("          ------------------------------------------");
        Console.WriteLine();
        Console.Write("-> Pressione qualquer tecla para voltar ao menu:");
    }
}
