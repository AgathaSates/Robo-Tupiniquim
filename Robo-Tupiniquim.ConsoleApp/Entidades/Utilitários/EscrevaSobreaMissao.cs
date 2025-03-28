namespace Robo_Tupiniquim.ConsoleApp.Entidades.Utilitários;

class EscrevaSobreaMissao
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
        Console.WriteLine($"> {nome} posicionado em: ({robox} {roboy}) olhando para o {robodirecao}");
        Console.WriteLine();
    }

    public static void UltrapassouArea(string nomerobo)
    {
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine($"> {nomerobo} ultrapassou os limites da área de exploração...");
        Thread.Sleep(1500);
        Console.WriteLine($"> Caiu em um buraco negro!\n> A missão acabou para {nomerobo}");
        Console.WriteLine("> Que descanse paz...");
        Console.WriteLine("---------------------------------------------------------------");
    }

    public static void PosicaoFinalRobo(string nomerobo, int x, int y, char direcao)
    {
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"> A posição final do {nomerobo} é: {x} {y} {direcao}");
        Console.WriteLine("----------------------------------------------------");
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

    public static void StatusFinaldaMissao()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("        Status Final da missão");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Duração total: {duracao} minutos");
        Console.WriteLine($"Amostras Coletadas: {amostras}");
        Console.WriteLine($"Condições Climáticas: {climaAtual}");
        Console.WriteLine($"Reconhecimento da Área: {progresso}% Completo");
        Console.WriteLine("--------------------------------------");
    }
}
